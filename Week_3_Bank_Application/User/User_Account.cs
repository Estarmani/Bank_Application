using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Bank_Application.Account;
using Week_3_Bank_Application.User;

namespace Bank_Application
{
    
    public class User_Account : Customer
    {
        //public static Week_3_Bank_Application.User.Customer customer = new Week_3_Bank_Application.User.Customer();

        static string Option = "";
     
        public readonly string passwordPattern = @"^(?=.*[a-zA-Z0-9])(?=.*[@#$%^&+=])(?=.{6,})";
        public readonly string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public readonly string namePattern = @"^[A-Z][a-zA-Z]*$";
        
        

        public void UserSignUp()
        {

            bool isValid;
            do
            {
                Console.WriteLine("\n                          ALLSTAR BANKING APPLICATION\n                          ");
                Console.WriteLine("\n 1: Sign Up\n 2: Login\n 3: Logout\n");
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

                }
                else if (Option == "2")
                {
                    isValid = true;
                    User.User_Login user_Login = new User.User_Login();
                    user_Login.ApprovedLogin();
                }
                else if (Option == "3")
                {
                    isValid = true;
                    Userlogout log_out = new Userlogout();
                    log_out.LogOutUser();
                }
                else
                {
                    isValid = false;
                    UserSignUp();
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
                Customer.FirstName = name;

            } while (!Regex.IsMatch(Customer.FirstName, namePattern));

        }
        public void LastName()
        {
            do
            {
                Console.Write("\n Enter Last Name: ");
                var name = Console.ReadLine();
                Customer.LastName = name;

            } while (!Regex.IsMatch(Customer.LastName, namePattern));
        }
        public void Email()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n                         ALLSTAR BANKING APPLICATION\n                        ");
                Console.Write(" Enter Email address: ");
                var email = Console.ReadLine();
                Customer.Email += email;

            } while (!Regex.IsMatch(Customer.Email, emailPattern));
        }
        public void Password()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" Password must be at least 6 characters");
                Console.WriteLine(" Password must contain Upper case, Lower case and special characters\n\n\n");
                Console.Write(" Create Password: ");
                var password = Console.ReadLine();
                Customer.Password += password;
                Console.Clear ();
        
            } while (!Regex.IsMatch(Customer.Password, passwordPattern));
        }



        public string CustomerId()
        {
            Random newID = new Random();
            int i = newID.Next(5000, 5999);
            Customer.CustomerID = i.ToString();
            return Customer.CustomerID;
        }
    }
   
}
