using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFDynamicUserControl.ViewModels
{
    public class Tap1ViewViewModel : BindableBase
    {

        #region Tab1Title
        private string _Tab1Title = "我在 Tab1";
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string Tab1Title
        {
            get { return this._Tab1Title; }
            set { this.SetProperty(ref this._Tab1Title, value); }
        }
        #endregion


        public DelegateCommand HelloCommand { get; set; }

        public readonly IPageDialogService _dialogService;
        public Tap1ViewViewModel()
        {
            IUnityContainer myContainer = (App.Current as PrismApplication).Container;
            _dialogService= myContainer.Resolve<IPageDialogService>();

            HelloCommand = new DelegateCommand(() =>
            {
                _dialogService.DisplayAlertAsync("Info", "Hello Tab1", "OK");
            });
        }
    }
}
