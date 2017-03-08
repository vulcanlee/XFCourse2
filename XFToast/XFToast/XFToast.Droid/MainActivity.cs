using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Plugin.Toasts;
using Prism.Events;
using XFToast.Services;

namespace XFToast.Droid
{
    [Activity(Label = "XFToast", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        ToastNotification notificator;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            #region 進行套件初始化，避免被 Linker 意外移除，不過，這裡不會有這個問題
            ToastNotification.Init(this);
            #endregion

            LoadApplication(new App(new AndroidInitializer()));

            #region 訂閱要發出 Toast 的事件
            //取得 Xamarin.Forms 的相依性服務管理容器，並且取得 Prims 用的事件聚合器的實作物件
            IEventAggregator _eventAggregator = ((XFToast.App.Current as PrismApplication).Container as IUnityContainer).Resolve<IEventAggregator>();
            // 訂閱要顯示 Toast 的通知事件
            _eventAggregator.GetEvent<ToastEvent>().Subscribe(async x =>
            {
                var notificator = new ToastNotification();

                var toastNotificationOptions = new NotificationOptions()
                {
                    Title = x.Title,
                    Description = x.Description
                };

                var result = await notificator.Notify(toastNotificationOptions);
            });

            #endregion
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}

