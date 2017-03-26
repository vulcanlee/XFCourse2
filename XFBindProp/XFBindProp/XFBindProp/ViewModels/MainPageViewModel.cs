using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFBindProp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region MyHint
        private string _MyHint = "Email";
        /// <summary>
        /// MyHint
        /// </summary>
        public string MyHint
        {
            get { return this._MyHint; }
            set { this.SetProperty(ref this._MyHint, value); }
        }
        #endregion

        public DelegateCommand changePropertyCommand { get; set; }

        public MainPageViewModel()
        {
            changePropertyCommand = new DelegateCommand(() =>
            {
                MyHint = "Account";
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
