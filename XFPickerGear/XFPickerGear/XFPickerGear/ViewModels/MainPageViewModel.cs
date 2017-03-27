using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace XFPickerGear.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        #region Picker1Source
        private ObservableCollection<string> _Picker1Source=new ObservableCollection<string>();
        /// <summary>
        /// Picker1Source
        /// </summary>
        public ObservableCollection<string> Picker1Source
        {
            get { return _Picker1Source; }
            set { SetProperty(ref _Picker1Source, value); }
        }
        #endregion
        #region Picker2Source
        private ObservableCollection<string> _Picker2Source=new ObservableCollection<string>();
        /// <summary>
        /// Picker2Source
        /// </summary>
        public ObservableCollection<string> Picker2Source
        {
            get { return _Picker2Source; }
            set { SetProperty(ref _Picker2Source, value); }
        }
        #endregion

        #region Picker1Selected
        private string _Picker1Selected;
        /// <summary>
        /// Picker1Selected
        /// </summary>
        public string Picker1Selected
        {
            get { return this._Picker1Selected; }
            set { this.SetProperty(ref this._Picker1Selected, value); }
        }
        #endregion

        #region Picker2Selected
        private string _Picker2Selected;
        /// <summary>
        /// Picker2Selected
        /// </summary>
        public string Picker2Selected
        {
            get { return this._Picker2Selected; }
            set { this.SetProperty(ref this._Picker2Selected, value); }
        }
        #endregion

        public DelegateCommand Picker1SelectedCommand { get; set; }

        public DelegateCommand Picker2SelectedCommand { get; set; }

        public MainPageViewModel()
        {
            Picker1SelectedCommand = new DelegateCommand(() =>
            {
                var fooSource = PickerRepository.GetPicker2Source(Picker1Selected);
                Picker2Source.Clear();
                foreach (var item in fooSource)
                {
                    Picker2Source.Add(item);
                }
            });
            Picker2SelectedCommand = new DelegateCommand(() =>
            {

            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";

            Picker1Source.Clear();
            var fooSource = PickerRepository.GetPicker1Source();
            foreach (var item in fooSource)
            {
                Picker1Source.Add(item);
            }
        }
    }
}
