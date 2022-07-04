using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemDay23
{
    internal class AddressBook
    {
        Contact tempContact = new Contact();
        public Dictionary<string, Contact> contacts;

        public AddressBook()
        {
            contacts = new Dictionary<string, Contact>();
        }

        public void CreateContact()
        {
            Contact tempContact = new Contact();
            tempContact.UserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
            }
            else
            {
                Console.WriteLine("erorr");
            }
        }
        public void Display()
        {
            foreach (string name in contacts.Keys)
                contacts[name].Display();
        }
        public void AddContacts()
        {
            tempContact.UserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
                Console.WriteLine("Successfully Added A New Contact!!!");
            }
            else
            {
                Console.WriteLine("erorr");
            }

        }
        public void EditContact()
        {
            Console.WriteLine("Enter name of contact to edit: ");
            string name = Console.ReadLine();
            if (contacts.ContainsKey(name) is true)
            {
                Contact tempContact = new Contact();
                tempContact.UserInfo();
                string editName = tempContact.GetName();
                if (contacts.ContainsKey(editName) is false || editName == name)
                {
                    contacts.Remove(name);
                    contacts.Add(editName, tempContact);
                    Console.WriteLine("Successfully Edited And Saved!!!");
                    Display();
                }
                else
                    Console.WriteLine("Edited name is invalid");
            }
            else
                Console.WriteLine("Name does not exist");
        }

    }
}
