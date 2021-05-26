using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class phonebook // a class for the phonebook
    {
        private List<Contacts> _contacts { get; set; } = new List<Contacts>(); // list of contacts in the phonebook

        private void displayMatchingContacts(List<Contacts> contacts) // method to display all and matching contacts
        {
            foreach (var contactNum in contacts)
            {
                Console.WriteLine("Contact: " + contactNum.name + " " + contactNum.number);
            }
        }
        public void addContacts(Contacts contacts)   // method to add contacts to the phonebook
        {
            _contacts.Add(contacts);
        }

        public void displayNum(string number)  // method to display a contact by number
        {
            var contacts = _contacts.FirstOrDefault(c => c.number == number);

            if(contacts==null)
            {
                Console.WriteLine("Contact Not Found!!");
            }
            else
            {
                Console.WriteLine("Contact: " + contacts.name + " " + contacts.number);
            }
        }

        public void displayAllContacts()  // method to display all the contacts in the phonebook
        {
            displayMatchingContacts(_contacts);
        }

        public void displayContactsByName(string searchWord) // method to search for a contact with just a part of the name
        {
            var contacts = _contacts.Where(c => c.name.Contains(searchWord)).ToList();
            displayMatchingContacts(contacts);
        }
    }
} 
