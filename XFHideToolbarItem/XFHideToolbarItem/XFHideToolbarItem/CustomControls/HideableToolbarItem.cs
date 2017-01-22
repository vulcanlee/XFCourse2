using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFHideToolbarItem.CustomControls
{
    public class HideableToolbarItem : ToolbarItem
    {
        public HideableToolbarItem() : base()
        {
            this.InitVisibility();
        }

        /// <summary>
        /// 進行顯示狀態的初始化
        /// </summary>
        private async void InitVisibility()
        {
            await Task.Delay(100);
            OnIsVisibleChanged(this, false, IsVisible);
        }

        // 這個屬性值，會在 XAML 中指定，實際上，指向到這個頁面
        // Parent="{x:Reference ThisPage}"
        public ContentPage Parent { set; get; }

        #region IsVisible 可綁定屬性，用於設定是否要顯示這個工具列按鈕
        public static readonly BindableProperty IsVisibleProperty =
            BindableProperty.Create("IsVisible", // 屬性名稱 
                typeof(bool), // 回傳類型 
                typeof(HideableToolbarItem), // 宣告類型 
                false, // 預設值 
                propertyChanged: OnIsVisibleChanged);

        public bool IsVisible
        {
            set
            {
                SetValue(IsVisibleProperty, value);
            }
            get
            {
                return (bool)GetValue(IsVisibleProperty);
            }
        }
        #endregion


        private static void OnIsVisibleChanged(BindableObject bindable, object oldVal, object newVal)
        {
            var item = bindable as HideableToolbarItem;
            bool oldvalue = (bool)oldVal;
            bool newvalue = (bool)newVal;

            if (item.Parent == null)
                return;

            var items = item.Parent.ToolbarItems;

            if (newvalue && !items.Contains(item))
            {
                items.Add(item);
            }
            else if (!newvalue && items.Contains(item))
            {
                items.Remove(item);
            }
        }

    }
}
