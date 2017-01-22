using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFSelector
{
    /// <summary>
    /// 依據出生日期年分，決定要顯示哪種資料樣板
    /// </summary>
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        // 這個物件值，將會在 XAML 中來定義
        public DataTemplate ValidTemplate { get; set; }

        // 這個物件值，將會在 XAML 中來定義
        public DataTemplate InvalidTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            // 根據當時物件的值，決定要使用哪個資料樣板
            return ((Person)item).DateOfBirth.Year >= 1980 ? ValidTemplate : InvalidTemplate;
        }
    }
}
