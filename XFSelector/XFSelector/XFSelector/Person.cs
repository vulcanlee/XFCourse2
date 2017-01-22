using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFSelector
{
    public class Person
    {
        public string Name { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public string Location { get; private set; }
        public Color ShowColor { get; set; }
        public Person(string name, DateTime dob, string location)
        {
            Name = name;
            DateOfBirth = dob;
            Location = location;
        }
    }
}
