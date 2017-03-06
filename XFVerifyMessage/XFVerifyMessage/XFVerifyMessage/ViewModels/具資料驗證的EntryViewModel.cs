using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using XFVerifyMessage.Helpers;

namespace XFVerifyMessage.ViewModels
{
    public enum 資料驗證方式
    {
        電子郵件,
        密碼
    }
    public class 具資料驗證的EntryViewModel : BindableBase
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region 輸入的欄位文字
        // 在這裡需要設定欄位的預設值
        private string _輸入的欄位文字 = "";
        /// <summary>
        /// 輸入的欄位文字
        /// </summary>
        public string 輸入的欄位文字
        {
            get { return this._輸入的欄位文字; }
            set
            {
                this.SetProperty(ref this._輸入的欄位文字, value);
                if (string.IsNullOrEmpty(_輸入的欄位文字))
                {
                    顯示錯誤訊息文字 = false;
                    輸入的欄位文字驗證無誤 = false;
                }
                else
                {
                    var fooBool = false;
                    switch (資料驗證方式)
                    {
                        case 資料驗證方式.電子郵件:
                            fooBool = DataVerifyHelper.Check電子郵件(_輸入的欄位文字);
                            break;
                        case 資料驗證方式.密碼:
                            fooBool = DataVerifyHelper.Check密碼(_輸入的欄位文字);
                            break;
                        default:
                            break;
                    }

                    if (fooBool == true)
                    {
                        顯示錯誤訊息文字 = false;
                        輸入的欄位文字驗證無誤 = true;
                    }
                    else
                    {
                        顯示錯誤訊息文字 = true;
                        輸入的欄位文字驗證無誤 = false;
                    }
                }
            }
        }
        #endregion

        #region 輸入的欄位提示文字
        private string _輸入的欄位提示文字;
        /// <summary>
        /// 輸入的欄位提示文字
        /// </summary>
        public string 輸入的欄位提示文字
        {
            get { return this._輸入的欄位提示文字; }
            set
            {
                this.SetProperty(ref this._輸入的欄位提示文字, value);
            }
        }
        #endregion

        #region 資料驗證方式
        private 資料驗證方式 _資料驗證方式;
        /// <summary>
        /// 資料驗證方式
        /// </summary>
        public 資料驗證方式 資料驗證方式
        {
            get { return this._資料驗證方式; }
            set { this.SetProperty(ref this._資料驗證方式, value); }
        }
        #endregion

        #region 輸入的欄位文字驗證無誤
        // 在這裡需要設定欄位的預設值
        private bool _輸入的欄位文字驗證無誤 = false;
        /// <summary>
        /// 輸入的欄位文字驗證無誤
        /// </summary>
        public bool 輸入的欄位文字驗證無誤
        {
            get { return this._輸入的欄位文字驗證無誤; }
            set { this.SetProperty(ref this._輸入的欄位文字驗證無誤, value); }
        }
        #endregion

        #region 錯誤訊息文字
        // 在這裡需要設定欄位的預設值
        private string _錯誤訊息文字 = "";
        /// <summary>
        /// 錯誤訊息文字
        /// </summary>
        public string 錯誤訊息文字
        {
            get { return this._錯誤訊息文字; }
            set { this.SetProperty(ref this._錯誤訊息文字, value); }
        }
        #endregion

        #region 顯示錯誤訊息文字
        // 在這裡需要設定欄位的預設值
        private bool _顯示錯誤訊息文字 = false;
        /// <summary>
        /// 顯示錯誤訊息文字
        /// </summary>
        public bool 顯示錯誤訊息文字
        {
            get { return this._顯示錯誤訊息文字; }
            set { this.SetProperty(ref this._顯示錯誤訊息文字, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        #endregion

        #region Constructor 建構式
        public 具資料驗證的EntryViewModel()
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
