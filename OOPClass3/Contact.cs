using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass3
{
    class Contact
    {
        private string email;
        private string phone;
        private string address;

        public Contact(string email, string phone, string address)
        {
            Email = email;
            Phone = phone;
            Address = address;
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}