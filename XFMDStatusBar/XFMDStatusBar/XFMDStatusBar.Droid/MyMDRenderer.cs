using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XFMDStatusBar;
using XFMDStatusBar.Droid;
using Xamarin.Forms.Platform.Android.AppCompat;
using System.Reflection;

[assembly: ExportRenderer(typeof(MyMD), typeof(MyMDRenderer))]
namespace XFMDStatusBar.Droid
{
    public class MyMDRenderer : MasterDetailPageRenderer
    {
        public override void AddView(Android.Views.View child)
        {
            child.GetType().GetRuntimeProperty("TopPadding").SetValue(child, 0);
            var padding = child.GetType().GetRuntimeProperty("TopPadding").GetValue(child);

            base.AddView(child);
        }
    }
}