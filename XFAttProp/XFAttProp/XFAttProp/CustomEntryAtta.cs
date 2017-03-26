using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFAttProp
{
    public class CustomEntryAtta
    {
        #region HintType 附加屬性 Attached Property
        public static readonly BindableProperty HintTypeProperty =
               BindableProperty.CreateAttached(
                   propertyName: "HintType",   // 屬性名稱 
                   returnType: typeof(string), // 回傳類型 
                   declaringType: typeof(Entry), // 宣告類型 
                   defaultValue: "None", // 預設值 
                   propertyChanged: OnEntryTypeChanged  // 屬性值異動時，要執行的事件委派方法
               );

        private static void OnEntryTypeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var fooEntry = bindable as Entry;
            if (fooEntry == null)
            {
                return;
            }

            var fooNewValue = (newValue as string)?.ToLower();
            if (fooNewValue == "email")
            {
                fooEntry.Placeholder = "請輸入電子郵件信箱";
            }
            else if (fooNewValue == "account")
            {
                fooEntry.Placeholder = "請輸入帳號";
            }
        }

        public static void SetHintType(BindableObject bindable, string entryType)
        {
            bindable.SetValue(HintTypeProperty, entryType);
        }
        public static string GetHintType(BindableObject bindable)
        {
            return (string)bindable.GetValue(HintTypeProperty);
        }
        #endregion

    }
}
