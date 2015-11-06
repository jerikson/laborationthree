using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class Contact
    {
        private string firstName;
        private string lastName;
        private string phoneNumger;


        public Contact (string FirstName, string LastName, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        } 

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumger; }
            set { phoneNumger = value; }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + PhoneNumber;
        }

    }
}
