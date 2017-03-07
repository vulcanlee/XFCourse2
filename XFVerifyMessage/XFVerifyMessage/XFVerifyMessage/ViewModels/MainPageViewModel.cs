using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XFVerifyMessage.ViewModels
{

    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region 電子郵件信箱
        // 在這裡需要設定欄位的預設值
        private 具資料驗證的EntryViewModel _電子郵件信箱=new 具資料驗證的EntryViewModel();
        /// <summary>
        /// 電子郵件信箱
        /// </summary>
        public 具資料驗證的EntryViewModel 電子郵件信箱
        {
            get { return this._電子郵件信箱; }
            set { this.SetProperty(ref this._電子郵件信箱, value); }
        }
        #endregion

        #region 密碼
        // 在這裡需要設定欄位的預設值
        private 具資料驗證的EntryViewModel _密碼=new 具資料驗證的EntryViewModel();
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public 具資料驗證的EntryViewModel 密碼
        {
            get { return this._密碼; }
            set { this.SetProperty(ref this._密碼, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        public DelegateCommand 儲存Command { get; set; }

        public readonly IPageDialogService _dialogService;
        private readonly INavigationService _navigationService;
        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {

            #region 相依性服務注入的物件

            _dialogService = dialogService;
            _navigationService = navigationService;
            #endregion

            #region 頁面中綁定的命令
            儲存Command = new DelegateCommand(async () =>
            {
                await _dialogService.DisplayAlertAsync("", "已經儲存", "確定");
            });

            #region 若在 Button 上使用了 Command，則這個按鈕是否可以使用，需要使用canExecuteMethod
            //儲存Command = new DelegateCommand(async () =>
            //{
            //    await _dialogService.DisplayAlertAsync("", "已經儲存", "確定");
            //}, () =>
            //{
            //    return 電子郵件信箱.輸入的欄位文字驗證無誤 && 密碼.輸入的欄位文字驗證無誤;
            //});
            #endregion
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
            #region 進行 電子郵件信箱 欄位做初始化
            電子郵件信箱.輸入的欄位提示文字 = "請輸入電子郵件信箱";
            電子郵件信箱.輸入的欄位文字 = "";
            電子郵件信箱.資料驗證方式 = 資料驗證方式.電子郵件;
            電子郵件信箱.輸入的欄位文字驗證無誤 = false;
            電子郵件信箱.錯誤訊息文字 = "請輸入正確的電子郵件信箱";
            電子郵件信箱.顯示錯誤訊息文字 = false;
            #endregion

            #region 進行 密碼 欄位做初始化
            密碼.輸入的欄位提示文字 = "請輸入密碼";
            密碼.輸入的欄位文字 = "";
            密碼.資料驗證方式 = 資料驗證方式.密碼;
            密碼.輸入的欄位文字驗證無誤 = false;
            密碼.錯誤訊息文字 = "密碼長度須超過8個字元且強度須符合規定";
            密碼.顯示錯誤訊息文字 = false;
            #endregion

            await Task.Delay(100);
        }
        #endregion

    }
}
