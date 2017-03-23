using System.Runtime.CompilerServices;
using Xamarin.Forms;
using XFDynamicUserControl.UserControls;
using XFDynamicUserControl.ViewModels;

namespace XFDynamicUserControl.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel fooMainPageViewModel;
        public MainPage()
        {
            InitializeComponent();

            fooMainPageViewModel = this.BindingContext as MainPageViewModel;
            MyTapContentView.Content = new Tap1View();
            MyTapContentView.BindingContext = new Tap1ViewViewModel();
        }

        private void Button1_Clicked(object sender, System.EventArgs e)
        {
            MyTapContentView.Content = new Tap1View();
            MyTapContentView.BindingContext = new Tap1ViewViewModel();
            fooMainPageViewModel.Title = "我在主頁面中的 Tab1 Content View 內";
        }

        private void Button2_Clicked(object sender, System.EventArgs e)
        {
            MyTapContentView.Content = new Tap2View();
            MyTapContentView.BindingContext = new Tap2ViewViewModel();
            fooMainPageViewModel.Title = "我在主頁面中的 Tab2 Content View 內";
        }
    }
}
