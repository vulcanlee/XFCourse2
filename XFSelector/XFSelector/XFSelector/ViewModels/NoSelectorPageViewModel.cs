using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XFSelector.ViewModels
{
    public class NoSelectorPageViewModel : BindableBase, INavigationAware
    {
        #region Repositories (遠端或本地資料存取)
        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)
        #region People
        private ObservableCollection<Person> _People;
        /// <summary>
        /// People
        /// </summary>
        public ObservableCollection<Person> People
        {
            get { return _People; }
            set { SetProperty(ref _People, value); }
        }
        #endregion

        #endregion

        #region Field 欄位
        #endregion

        #region Constructor 建構式
        public NoSelectorPageViewModel()
        {

        }
        #endregion

        #region Navigation Events (頁面導航事件)
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            People = new ObservableCollection<Person> {
                new Person ("Kath", new DateTime (1985, 11, 20), "France"),
                new Person ("Steve", new DateTime (1975, 1, 15), "USA"),
                new Person ("Lucas", new DateTime (1988, 2, 5), "Germany"),
                new Person ("John", new DateTime (1976, 2, 20), "USA"),
                new Person ("Tariq", new DateTime (1987, 1, 10), "UK"),
                new Person ("Jane", new DateTime (1982, 8, 30), "USA"),
                new Person ("Tom", new DateTime (1977, 3, 10), "UK")
            };

            foreach (var item in People)
            {
                if(item.DateOfBirth.Year >= 1980)
                {
                    item.ShowColor = Color.Green;
                }
                else
                {
                    item.ShowColor = Color.Red;
                }
            }
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
