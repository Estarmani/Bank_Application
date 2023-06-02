using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Bank_Application.Account;
using Week_3_Bank_Application.User;

namespace Bank_Application.User
{
    
     public class User_Account
    {
        public static Customer customer = new Customer();

        static string Option = "";
    
        public readonly string passwordPattern = @"^(?=.*[a-zA-Z0-9])(?=.*[@#$%^&+=])(?=.{6,})";
        public readonly string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public readonly string namePattern = @"^[A-Z][a-zA-Z]*$";
        
        

        public void User_SignUp()
        {

            bool isValid;
            do
            {
                Console.WriteLine("\n                          ALLSTAR BANKING APPLICATION\n                          ");
                Console.WriteLine("\n 1: Sign Up\n 2: Login\n 3: Exit\n");
                Console.WriteLine("Select any number to begin ");
                Option = Console.ReadLine();
                Console.Clear();

                if (Option == "1")
                {
                    isValid = true;
                    FirstName();
                    LastName();
                    Email();
                    Password();
                    CustomerId();
                    Console.WriteLine("Registration successful");
                    print();

                }
                else if (Option == "2")
                {
                    isValid = true;
                    User_Login user_Login = new User_Login();
                    user_Login.ApprovedLogin();
                }
                else if (Option == "3")
                {
                    isValid = true;
                    User_logout log_out = new User_logout();
                    log_out.LogOutUser();
                }
                else
                {
                    isValid = false;
                    User_SignUp();
                }
            } while (isValid);



        }
        public void FirstName()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n                         ALLSTAR BANKING APPLICATION\n                       ");
                Console.Write("\n Enter First Name: ");
                var name = Console.ReadLine();
                customer.FirstName = name;

            } while (!Regex.IsMatch(customer.FirstName, namePattern));

        }
        public void LastName()
        {
            do
            {
                Console.Write("\n Enter Last Name: ");
                var name = Console.ReadLine();
                customer.LastName = name;

            } while (!Regex.IsMatch(customer.LastName, namePattern));
        }
        public void Email()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n                         ALLSTAR BANKING APPLICATION\n                        ");
                Console.Write(" Enter Email address: ");
                var email = Console.ReadLine();
                customer.Email += email;

            } while (!Regex.IsMatch(customer.Email, emailPattern));
        }
        public void Password()
        {
            do
            {
                Console.WriteLine(" Password must be at least 6 characters");
                Console.WriteLine(" Password must contain Upper case, Lower case and special characters\n\n\n");
                Console.Write(" Create Password: ");
                var password = Console.ReadLine();
                customer.Password += password;
                Console.Clear();
            } while (!Regex.IsMatch(customer.Password, passwordPattern));
        }



        public string CustomerId()
        {
            Random newID = new Random();
            int i = newID.Next(5000, 5999);
            customer.CustomerID = i.ToString();
            return customer.CustomerID;
        }
        

        public void print()
        {

           
        }

        
    }
   
}
