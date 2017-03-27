using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFPickerGear
{
    class PickerRepository
    {
        public static List<string> GetPicker1Source()
        {
            var fooSource = new List<string>
            {
                "A","B","C"
            };
            return fooSource;
        }

        public static List<string> GetPicker2Source(string category)
        {
            var fooSource = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                fooSource.Add($"{category} {i}");
            }
            return fooSource;
        }
    }
}
