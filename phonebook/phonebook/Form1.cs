using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebook
{
    public partial class Form1 : Form
    {
        PhoneBook myPhoneBook;
        
        public Form1() {
            InitializeComponent();
            myPhoneBook = new PhoneBook();
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            string[] contact = txtNewContact.Text.Split(',');
            if (contact.Length < 3) { lblError.Text = "Error! <firstname>,<lastname>,<phonenumber>"; return; }
            string tmpFirstName = contact[0], tmpLastName = contact[1], tmpNumber = contact[2];

            if (chklsSecret.Checked) {
                SecretContact tmpSecretContactToAdd = new SecretContact(tmpFirstName, tmpLastName, tmpNumber);
                myPhoneBook.AddContact(tmpSecretContactToAdd);

            } else { 
                Contact tmpContactToAdd = new Contact(tmpFirstName, tmpLastName, tmpNumber);
                myPhoneBook.AddContact(tmpContactToAdd);
            }

            txtNewContact.Text = "";
            lblError.Text = "";
            UpdateContacts();
        }

        private void btnRemoveContact_Click(object sender, EventArgs e)
        {
            Contact tmpContactToRemove = (Contact)lstContacts.SelectedItem;
            myPhoneBook.RemoveContact(tmpContactToRemove);
            UpdateContacts();
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact selectedContact = (Contact)lstContacts.SelectedValue;
            if(selectedContact == null)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhoneNumber.Text = "";
                return;
            }
                txtFirstName.Text = selectedContact.FirstName;
                txtLastName.Text = selectedContact.LastName;
                txtPhoneNumber.Text = selectedContact.PhoneNumber;
        }

        public void UpdateContacts() {
            lstContacts.DataSource = myPhoneBook.ListContacts();
        }
    }
}
