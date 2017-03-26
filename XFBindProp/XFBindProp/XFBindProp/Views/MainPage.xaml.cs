using Xamarin.Forms;

namespace XFBindProp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, System.EventArgs e)
        {
            myentry.HintType = "Account";
        }

        private void btn2_Clicked(object sender, System.EventArgs e)
        {
            myentry.SetValue(MyEntry.HintTypeProperty, "Email");
        }
    }
}
