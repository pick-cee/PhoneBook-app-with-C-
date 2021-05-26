using System;
using System.IO;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompting user to enter operation 
            Console.WriteLine("Welcome to the Phone Book Console Application");
            Console.WriteLine("What Operation You Would Like to Perform: ");
            Console.WriteLine("1. Add Contacts");
            Console.WriteLine("2. Display a Contact by Number");
            Console.WriteLine("3. View all Contacts");
            Console.WriteLine("4. Serach for a Contact");
            Console.WriteLine("5. Exit the Phone Book Application");

            int userInput = Convert.ToInt32(Console.ReadLine());

            phonebook phoneBook = new phonebook();

            // using a while loop to keep looping till user press "5"
            // using a switch case to switch between operations
            
            while (true)
            {
                switch (userInput)
                {
                    case 1:

                        Console.WriteLine("---------------------------------------");
                        Console.Write("Input Contact Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Input Contact Number: ");
                        string number = Console.ReadLine();

                        var newContact = new Contacts(name, number);
                        phoneBook.addContacts(newContact);
                        break;
                    
                    case 2:

                        Console.WriteLine("---------------------------------------");
                        Console.Write("Enter number to Serach: ");
                        var numberSearch = Console.ReadLine();
                        phoneBook.displayNum(numberSearch);
                        break;

                    case 3:

                        Console.WriteLine("---------------------------------------");
                        phoneBook.displayAllContacts();
                        break;
                    
                    case 4:

                        Console.WriteLine("---------------------------------------");
                        Console.Write("Enter name to search: ");
                        var searchWord = Console.ReadLine();

                        phoneBook.displayContactsByName(searchWord);
                        break;
                    
                    case 5:

                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Thanks for Using the App, Goodbye!!");
                        return;
                    
                    default:

                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Invalid Selection, Try Again!");
                        break;
                }
                Console.WriteLine("*****************************************************");
                Console.WriteLine("What Operation You Would Like to Perform: ");
                Console.WriteLine("1. Add Contacts");
                Console.WriteLine("2. Display a Contact by Number");
                Console.WriteLine("3. View all Contacts");
                Console.WriteLine("4. Serach for a Contact");
                Console.WriteLine("5. Exit the Phone Book Application");

                userInput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
