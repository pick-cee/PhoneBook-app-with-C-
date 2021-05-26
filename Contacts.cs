using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contacts // contacts class
    {
        public  Contacts(string Name, string Number)
        {
            name = Name;
            number = Number;
        }
        public string name { get; set; }
        public string number { get; set; }

    }
}
