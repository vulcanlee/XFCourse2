using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFDynamicUserControl.ViewModels
{
    public class Tap2ViewViewModel : BindableBase
    {

        #region Tab2Title
        private string _Tab2Title="我在 Tab2";
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string Tab2Title
        {
            get { return this._Tab2Title; }
            set { this.SetProperty(ref this._Tab2Title, value); }
        }
        #endregion

        public Tap2ViewViewModel()
        {
            
        }
    }
}
