using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFNaviBarColor.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
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

        public DelegateCommand 下一頁Command { get; set; }

        private readonly INavigationService _navigationService;
        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            下一頁Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Next1Page");
            });
        }
        #endregion

        #region Navigation Events (頁面導航事件)
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
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
