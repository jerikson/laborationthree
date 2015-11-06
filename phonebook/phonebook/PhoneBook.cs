using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace phonebook
{
    class PhoneBook
    {
        private BindingList<Contact> contacts = new BindingList<Contact>();

        public BindingList<Contact> ListContacts()
        {
            return contacts;
        }

        public void AddContact(Contact contactToAdd)
        {
            contacts.Add(contactToAdd);
        }

        public void RemoveContact(Contact contactToRemove)
        {
            contacts.Remove(contactToRemove);
        }



    }
}
