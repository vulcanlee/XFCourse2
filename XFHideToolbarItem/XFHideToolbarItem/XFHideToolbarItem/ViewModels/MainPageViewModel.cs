using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFHideToolbarItem.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware // 這裡要加入與實作 INavigationAware
    {
        // 使用程式碼片段 vlv 產生這些程式碼片段碼，方便程式碼維護
        #region Repositories (遠端或本地資料存取)
        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region Title
        private string _Title;
        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return this._Title; }
            set { this.SetProperty(ref this._Title, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        public DelegateCommand 下一頁Command { get; set; } // 使用程式碼片段 vlprism 產生這些程式碼片段碼，方便程式碼維護

        private readonly INavigationService _navigationService; // 使用 vlin + ↓ [往下移動游標按鍵] 程式碼片段產生這個建構式注入程式碼
        #endregion

        #region Constructor 建構式

        public MainPageViewModel(INavigationService navigationService) // 使用 vlin 程式碼片段產生這個建構式注入程式碼
        {

            _navigationService = navigationService;  // 使用 vlin + ↓ [往下移動游標按鍵] 程式碼片段產生這個建構式注入程式碼

            下一頁Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Next1Page");
            });
        }

        #endregion

        #region Navigation Events (頁面導航事件)
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            // 記得要把這行刪除，要不然執行的時候，會閃退
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            // 記得要把這行刪除，要不然執行的時候，會閃退
            //throw new NotImplementedException();
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
        #endregion

        #region 設計時期或者執行時期的ViewModel初始化
        #endregion

        #region 相關事件
        #endregion

        #region 相關的Command定義
        #endregion

        #region 其他方法
        #endregion

    }
}
