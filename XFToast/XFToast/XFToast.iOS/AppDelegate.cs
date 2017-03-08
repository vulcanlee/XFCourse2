using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Plugin.Toasts;
using Prism.Events;
using XFToast.Services;
using Prism.Services;
using UserNotifications;

namespace XFToast.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            #region 進行套件初始化，避免被 Linker 意外移除，不過，這裡不會有這個問題
            ToastNotification.Init();
            #endregion

            #region 請求 Toast 顯示權限
            // Request Permissions
            if (UIDevice.CurrentDevice.CheckSystemVersion(10, 0))
            {
                // Request Permissions
                UNUserNotificationCenter.Current.RequestAuthorization(UNAuthorizationOptions.Alert | UNAuthorizationOptions.Badge | UNAuthorizationOptions.Sound, (granted, error) =>
                {
                    // Do something if needed
                });
            }
            else if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                var notificationSettings = UIUserNotificationSettings.GetSettingsForTypes(
                UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound, null);

                app.RegisterUserNotificationSettings(notificationSettings);
            }
            #endregion

            LoadApplication(new App(new iOSInitializer()));

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

            return base.FinishedLaunching(app, options);
        }
    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }

}
