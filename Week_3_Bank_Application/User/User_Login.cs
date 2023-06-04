using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Week_3_Bank_Application.User;

namespace Bank_Application.User
{
    public class User_Login : Customer
        
    { 
        
        public void ApprovedLogin()
        {
           
            Console.Write("\n Enter your Email: ");
            var e = Console.ReadLine();
            Console.Write("\n Enter your Password: ");
            var p = Console.ReadLine();

            if (e == Customer.Email && p == Customer.Password)
            {
                Console.WriteLine("Login Successful");
                Console.Clear();
                Menu newMenu = new Menu();
                newMenu.MainMenu();
            }
            else
            {
                Console.WriteLine(" Email or Password incorrect.");
                ApprovedLogin();
            }
        }
    }
}
