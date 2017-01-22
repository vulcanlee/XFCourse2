using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
// 加入 Prism.Navigation 方便底下 IntelliSense 自動識別出 INavigationAware
using Prism.Navigation;
using Prism.Services;

namespace XFHideToolbarItem.ViewModels
{
    public class Next1PageViewModel : BindableBase, INavigationAware // 這裡要加入與實作 INavigationAware
    {
        // 使用程式碼片段 vlv 產生這些程式碼片段碼，方便程式碼維護
        #region Repositories (遠端或本地資料存取)
        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        // 使用程式碼片段 vlm 產生這些程式碼片段碼，方便程式碼維護
        #region 顯示工具列按鈕  
        private bool _顯示工具列按鈕=true;
        /// <summary>
        /// 顯示工具列按鈕
        /// </summary>
        public bool 顯示工具列按鈕
        {
            get { return this._顯示工具列按鈕; }
            set { this.SetProperty(ref this._顯示工具列按鈕, value); }
        }
        #endregion

        // 使用程式碼片段 vlm 產生這些程式碼片段碼，方便程式碼維護
        #region 切換按鈕名稱
        private string _切換按鈕名稱= "隱藏";
        /// <summary>
        /// 切換按鈕名稱
        /// </summary>
        public string 切換按鈕名稱
        {
            get { return this._切換按鈕名稱; }
            set { this.SetProperty(ref this._切換按鈕名稱, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        public DelegateCommand 顯示工具列Command { get; set; } // 使用程式碼片段 vlprism 產生這些程式碼片段碼，方便程式碼維護
        public DelegateCommand 刪除Command { get; set; } // 使用程式碼片段 vlprism 產生這些程式碼片段碼，方便程式碼維護
        public DelegateCommand 匯出Command { get; set; } // 使用程式碼片段 vlprism 產生這些程式碼片段碼，方便程式碼維護

        public readonly IPageDialogService _dialogService; // 使用 vlip + ↓ [往下移動游標按鍵] 程式碼片段產生這個建構式注入程式碼
        private readonly INavigationService _navigationService; // 使用 vlin + ↓ [往下移動游標按鍵] 程式碼片段產生這個建構式注入程式碼
        #endregion

        #region Constructor 建構式

        public Next1PageViewModel(INavigationService navigationService,// 使用 vlin 程式碼片段產生這個建構式注入程式碼
                 IPageDialogService dialogService) // 使用 vlip 程式碼片段產生這個建構式注入程式碼
        {

            _dialogService = dialogService;     // 使用 vlip + ↓ [往下移動游標按鍵] 程式碼片段產生這個建構式注入程式碼
            _navigationService = navigationService;  // 使用 vlin + ↓ [往下移動游標按鍵] 程式碼片段產生這個建構式注入程式碼

            顯示工具列Command = new DelegateCommand(() =>
           {
               顯示工具列按鈕 = !顯示工具列按鈕;
               切換按鈕名稱 = (顯示工具列按鈕 ? "隱藏" : "顯示");
           });
            刪除Command = new DelegateCommand(async () =>
            {
                await _dialogService.DisplayAlertAsync("資訊", "資料已經刪除", "確定");
            });
            匯出Command = new DelegateCommand(async () =>
            {
                await _dialogService.DisplayAlertAsync("資訊", "資料已經刪除", "確定");
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
