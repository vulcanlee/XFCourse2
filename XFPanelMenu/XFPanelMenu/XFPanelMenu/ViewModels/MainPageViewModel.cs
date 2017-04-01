using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFPanelMenu.ViewModels
{

    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region MenuPanel
        private MyMenuPanelViewModel _MenuPanel = new MyMenuPanelViewModel();
        /// <summary>
        /// MenuPanel
        /// </summary>
        public MyMenuPanelViewModel MenuPanel
        {
            get { return this._MenuPanel; }
            set { this.SetProperty(ref this._MenuPanel, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        #region ViewModel 內使用到的欄位
        #endregion

        #region 命令物件欄位
        #endregion

        #region 注入物件欄位
        private readonly INavigationService _navigationService;
        #endregion

        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService)
        {

            #region 相依性服務注入的物件

            _navigationService = navigationService;
            #endregion

            #region 頁面中綁定的命令

            #endregion

            #region 事件聚合器訂閱

            #endregion
        }

        #endregion

        #region Navigation Events (頁面導航事件)
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
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
            MenuPanel.MyMenuButton1.Color = Color.Red;
            MenuPanel.MyMenuButton1.Text = "Button1";
            MenuPanel.MyMenuButton1.Visible = true;
            MenuPanel.MyMenuButton1.ButtonTapCommand = new DelegateCommand<MyMenuButtonViewModel>(CustomButtonPress);
            MenuPanel.MyMenuButton1.NaviService = _navigationService;

            MenuPanel.MyMenuButton2.Color = Color.Orange;
            MenuPanel.MyMenuButton2.Text = "Button2";
            MenuPanel.MyMenuButton2.Visible = true;
            MenuPanel.MyMenuButton2.ButtonTapCommand = new DelegateCommand<MyMenuButtonViewModel>(CustomButtonPress);

            MenuPanel.MyMenuButton3.Color = Color.Green;
            MenuPanel.MyMenuButton3.Text = "Button3";
            MenuPanel.MyMenuButton3.Visible = true;

            MenuPanel.MyMenuButton4.Color = Color.Pink;
            MenuPanel.MyMenuButton4.Text = "Button4";
            MenuPanel.MyMenuButton4.Visible = true;

            MenuPanel.MyMenuButton5.Color = Color.Lime;
            MenuPanel.MyMenuButton5.Text = "Button5";
            MenuPanel.MyMenuButton5.Visible = true;

            await Task.Delay(100);
        }

        private void CustomButtonPress(MyMenuButtonViewModel obj)
        {
            if (obj.Text == "Button1")
            {
                MenuPanel.MyMenuButton3.Visible = false;
                MenuPanel.MyMenuButton5.Visible = false;
            }
            else if (obj.Text == "Button2")
            {
                MenuPanel.MyMenuButton3.Visible = true;
                MenuPanel.MyMenuButton5.Visible = true;
            }
        }
        #endregion

    }

}
