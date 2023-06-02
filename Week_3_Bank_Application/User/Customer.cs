using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Bank_Application.User
{
    public class Customer
    {
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public int customerID;
         

        public Customer(string firstName, string lastName, string email, string password, int customerID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.customerID = customerID;
        }

    }
}
