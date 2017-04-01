using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFPanelMenu.ViewModels
{

    public class MyMenuPanelViewModel : BindableBase
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region MyMenuButton1
        private MyMenuButtonViewModel _MyMenuButton1= new MyMenuButtonViewModel();
        /// <summary>
        /// MyMenuButton1
        /// </summary>
        public MyMenuButtonViewModel MyMenuButton1
        {
            get { return this._MyMenuButton1; }
            set { this.SetProperty(ref this._MyMenuButton1, value); }
        }
        #endregion

        #region MyMenuButton2
        private MyMenuButtonViewModel _MyMenuButton2=new MyMenuButtonViewModel();
        /// <summary>
        /// MyMenuButton2
        /// </summary>
        public MyMenuButtonViewModel MyMenuButton2
        {
            get { return this._MyMenuButton2; }
            set { this.SetProperty(ref this._MyMenuButton2, value); }
        }
        #endregion

        #region MyMenuButton3
        private MyMenuButtonViewModel _MyMenuButton3 = new MyMenuButtonViewModel();
        /// <summary>
        /// MyMenuButton3
        /// </summary>
        public MyMenuButtonViewModel MyMenuButton3
        {
            get { return this._MyMenuButton3; }
            set { this.SetProperty(ref this._MyMenuButton3, value); }
        }
        #endregion

        #region MyMenuButton4
        private MyMenuButtonViewModel _MyMenuButton4 = new MyMenuButtonViewModel();
        /// <summary>
        /// MyMenuButton4
        /// </summary>
        public MyMenuButtonViewModel MyMenuButton4
        {
            get { return this._MyMenuButton4; }
            set { this.SetProperty(ref this._MyMenuButton4, value); }
        }
        #endregion

        #region MyMenuButton5
        private MyMenuButtonViewModel _MyMenuButton5=new MyMenuButtonViewModel();
        /// <summary>
        /// MyMenuButton5
        /// </summary>
        public MyMenuButtonViewModel MyMenuButton5
        {
            get { return this._MyMenuButton5; }
            set { this.SetProperty(ref this._MyMenuButton5, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        #endregion

        #region Constructor 建構式
        public MyMenuPanelViewModel()
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
