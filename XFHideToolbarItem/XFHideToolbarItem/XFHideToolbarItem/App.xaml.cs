using Prism.Unity;
using XFHideToolbarItem.Views;

namespace XFHideToolbarItem
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            // 要在導航路徑中加入 NaviPage 頁面，這樣，整個 App 才會具有導航工具列
            NavigationService.NavigateAsync("NaviPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<Next1Page>();
        }
    }
}
