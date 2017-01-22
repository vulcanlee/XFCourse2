using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFSelector.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region Repositories (遠端或本地資料存取)
        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        #endregion

        #region Field 欄位

        public DelegateCommand 沒有使用資料樣板選擇器Command { get; set; }
        public DelegateCommand 有使用資料樣板選擇器Command { get; set; }

        private readonly INavigationService _navigationService;
        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            沒有使用資料樣板選擇器Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("NoSelectorPage");
            });
            有使用資料樣板選擇器Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("HasSelectorPage");
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
