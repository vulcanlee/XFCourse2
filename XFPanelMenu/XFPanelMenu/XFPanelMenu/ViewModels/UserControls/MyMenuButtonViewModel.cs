using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XFPanelMenu.ViewModels
{

    public class MyMenuButtonViewModel : BindableBase
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region Color
        private Color _Color;
        /// <summary>
        /// Color
        /// </summary>
        public Color Color
        {
            get { return this._Color; }
            set { this.SetProperty(ref this._Color, value); }
        }
        #endregion

        #region Text
        private string _Text;
        /// <summary>
        /// Text
        /// </summary>
        public string Text
        {
            get { return this._Text; }
            set { this.SetProperty(ref this._Text, value); }
        }
        #endregion

        #region ButtonTapCommand
        private DelegateCommand<MyMenuButtonViewModel> _ButtonTapCommand;
        /// <summary>
        /// ButtonTapCommand
        /// </summary>
        public DelegateCommand<MyMenuButtonViewModel> ButtonTapCommand
        {
            get { return this._ButtonTapCommand; }
            set { this.SetProperty(ref this._ButtonTapCommand, value); }
        }
        #endregion

        #region Visible
        private bool _Visible = true;
        /// <summary>
        /// Visible
        /// </summary>
        public bool Visible
        {
            get { return this._Visible; }
            set { this.SetProperty(ref this._Visible, value); }
        }
        #endregion

        #region NaviService
        private INavigationService _NaviService;
        /// <summary>
        /// NaviService
        /// </summary>
        public INavigationService NaviService
        {
            get { return this._NaviService; }
            set { this.SetProperty(ref this._NaviService, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        #endregion

        #region Constructor 建構式
        public MyMenuButtonViewModel()
        {

            #region 相依性服務注入的物件

            #endregion

            #region 頁面中綁定的命令

            #endregion

            #region 事件聚合器訂閱

            #endregion
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
