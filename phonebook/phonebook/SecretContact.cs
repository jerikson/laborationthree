using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class SecretContact : Contact
    {
        public SecretContact(string FirstName, string LastName, string PhoneNumber) : base (FirstName,LastName,PhoneNumber) {
            
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + "*SECRETE*";
        }


    }
}
