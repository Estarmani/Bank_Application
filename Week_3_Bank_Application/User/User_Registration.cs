using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_Application
{
     public class User_Account
    {
        static string Option = "";
        public static string User_FirstName = "";
        public static string User_LastName = "";
        public static string User_Email = ""; 
        public static string User_Password = "";
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
                    Console.WriteLine();
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
                User_FirstName = name;

            } while (!Regex.IsMatch(User_FirstName, namePattern));

        }
        public void LastName()
        {
            do
            {
                Console.Write("\n Enter Last Name: ");
                var name = Console.ReadLine();
                User_LastName = name;

            } while (!Regex.IsMatch(User_LastName, namePattern));
        }
        public void Email()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n                         ALLSTAR BANKING APPLICATION\n                        ");
                Console.Write(" Enter Email address: ");
                var email = Console.ReadLine();
                User_Email += email;

            } while (!Regex.IsMatch(User_Email, emailPattern));
        }
        public void Password()
        {
            do
            {
                Console.WriteLine(" Password must be at least 6 characters");
                Console.WriteLine(" Password must contain Upper case, Lower case and special characters\n");
                Console.Write(" Create Password ");
                var password = Console.ReadLine();
                User_Password += password;
                Console.Clear();
            } while (!Regex.IsMatch(User_Password, passwordPattern));
        }
    }
}
