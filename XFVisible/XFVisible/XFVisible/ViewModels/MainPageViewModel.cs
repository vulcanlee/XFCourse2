using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFVisible.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel()
        {
            顯示切換Command = new DelegateCommand(() =>
            {
                // 設定頁面文字是否要顯示出來
                顯示切換 = !顯示切換;
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }


        #region 顯示切換 (會綁訂到 XAML 中的 Label 控制項上)
        private bool _顯示切換=true;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public bool 顯示切換
        {
            get { return this._顯示切換; }
            set { this.SetProperty(ref this._顯示切換, value); }
        }
        #endregion

        public DelegateCommand 顯示切換Command { get; set; }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
