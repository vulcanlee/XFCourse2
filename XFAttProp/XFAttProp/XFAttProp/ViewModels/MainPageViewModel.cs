using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFAttProp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region HintType
        private string _HintType="Email";
        /// <summary>
        /// HintType
        /// </summary>
        public string HintType
        {
            get { return this._HintType; }
            set { this.SetProperty(ref this._HintType, value); }
        }
        #endregion

        public DelegateCommand HintTypeCommand { get; set; }

        public MainPageViewModel()
        {
            HintTypeCommand = new DelegateCommand(() =>
            {
                HintType = "Account";
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
