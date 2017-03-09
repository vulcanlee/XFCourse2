using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using XFXamlSpy.Models;

namespace XFXamlSpy.ViewModels
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
        #region DataItemList
        private ObservableCollection<DataItem> _DataItemList = new ObservableCollection<DataItem>();
        /// <summary>
        /// DataItemList
        /// </summary>
        public ObservableCollection<DataItem> DataItemList
        {
            get { return _DataItemList; }
            set { SetProperty(ref _DataItemList, value); }
        }
        #endregion

        #region IsBusy
        private bool _IsBusy;
        /// <summary>
        /// IsBusy
        /// </summary>
        public bool IsBusy
        {
            get { return this._IsBusy; }
            set { this.SetProperty(ref this._IsBusy, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        public DelegateCommand ListView更新資料Command { get; set; }

        #endregion

        #region Constructor 建構式
        public MainPageViewModel()
        {
            ListView更新資料Command = new DelegateCommand(() =>
            {
                // 讓 ListView 出現忙碌中的視覺畫面
                IsBusy = true;
                Refresh();
                // 讓 ListView 隱藏忙碌中的視覺畫面
                IsBusy = false;
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

            Refresh();
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
        /// 更新 ListView 上的資料
        /// </summary>
        public void Refresh()
        {
            // 清除原有資料
            DataItemList.Clear();
            Random fooRM = new Random();
            // 隨機新增多筆新的資料
            for (int i = 0; i < fooRM.Next(20, 100); i++)
            {
                DataItemList.Add(new DataItem
                {
                    DataVale = $"多奇數位創意有限公司 {fooRM.Next(9999)}",
                });
            }
        }
        #endregion

    }
}
