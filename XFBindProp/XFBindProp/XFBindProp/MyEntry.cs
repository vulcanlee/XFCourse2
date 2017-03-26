using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFBindProp
{
    public class MyEntry : Entry
    {
        #region HintType 可綁定屬性 BindableProperty
        public static readonly BindableProperty HintTypeProperty =
            BindableProperty.Create("HintType", // 屬性名稱 
                typeof(string), // 回傳類型 
                typeof(MyEntry), // 宣告類型 
                "None", // 預設值 
                propertyChanged: OnEntryTypeChanged  // 屬性值異動時，要執行的事件委派方法
            );

        private static void OnEntryTypeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var fooEntry = bindable as Entry;
            if(fooEntry == null)
            {
                return;
            }

            var fooNewValue = (newValue as string)?.ToLower();

            if(fooNewValue == "email")
            {
                fooEntry.Placeholder = "請輸入電子郵件信箱";
            } else if(fooNewValue == "account")
            {
                fooEntry.Placeholder = "請輸入帳號";
            }
        }

        public string HintType
        {
            set
            {
                SetValue(HintTypeProperty, value);
            }
            get
            {
                return (string)GetValue(HintTypeProperty);
            }
        }
        #endregion

    }
}
