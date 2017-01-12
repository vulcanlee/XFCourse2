using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFMDStatusBar.ViewModels
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

        public DelegateCommand 正常模式的導航抽屜Command { get; set; }
        public DelegateCommand 使用Padding的導航抽屜Command { get; set; }
        public DelegateCommand 使用Renderer的導航抽屜Command { get; set; }

        private readonly INavigationService _navigationService;
        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            正常模式的導航抽屜Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("xf:///MDPage/NaviPage/MainPage?title=Hello%20from%20Xamarin.Forms");
            });
            使用Padding的導航抽屜Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("xf:///MDPadding/NaviPage/MainPage?title=Hello%20from%20Xamarin.Forms");
            });
            使用Renderer的導航抽屜Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("xf:///MDRenderer/NaviPage/MainPage?title=Hello%20from%20Xamarin.Forms");
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
