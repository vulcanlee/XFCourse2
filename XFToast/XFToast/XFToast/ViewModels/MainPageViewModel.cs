using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XFToast.Services;

namespace XFToast.ViewModels
{

    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region MsgTitle
        private string _MsgTitle;
        /// <summary>
        /// MsgTitle
        /// </summary>
        public string MsgTitle
        {
            get { return this._MsgTitle; }
            set { this.SetProperty(ref this._MsgTitle, value); }
        }
        #endregion

        #region MsgDescription
        private string _MsgDescription;
        /// <summary>
        /// MsgDescription
        /// </summary>
        public string MsgDescription
        {
            get { return this._MsgDescription; }
            set { this.SetProperty(ref this._MsgDescription, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        public DelegateCommand SendMessage { get; set; }

        public readonly IPageDialogService _dialogService;
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator,
            IPageDialogService dialogService)
        {

            #region 相依性服務注入的物件

            _dialogService = dialogService;
            _eventAggregator = eventAggregator;
            _navigationService = navigationService;
            #endregion

            #region 頁面中綁定的命令
            SendMessage = new DelegateCommand(() =>
            {
                // 透過 Prism 的事件聚合器，送出事件到原生專案中，從原生專案產生 Toast
                _eventAggregator.GetEvent<ToastEvent>().Publish(new Models.ToastMessage
                {
                    Title = MsgTitle,
                    Description = MsgDescription,
                });
            });
            #endregion

            #region 事件聚合器訂閱

            #endregion
        }

        #endregion

        #region Navigation Events (頁面導航事件)
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            await ViewModelInit();
        }
        #endregion

        #region 設計時期或者執行時期的ViewModel初始化
        #endregion

        #region 相關事件
        #endregion

        #region 相關的Command定義
        #endregion

        #region 其他方法

        /// <summary>
        /// ViewModel 資料初始化
        /// </summary>
        /// <returns></returns>
        private async Task ViewModelInit()
        {
            await Task.Delay(100);
        }
        #endregion

    }
}
