using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class User_Login : User_Account
        
    { 
        bool IsValue;
        public void ApprovedLogin()
        {
            Console.Write("\n Enter your Email: ");
            var e = Console.ReadLine();
            Console.Write("\n Enter your Password: ");
            var p = Console.ReadLine();

            if (e == User_Email && p == User_Password)
            {
                Console.WriteLine("Login Successful");
                Console.Clear();
                Menu newMenu = new Menu();
                newMenu.Main_Menu();
            }
            else
            {
                Console.WriteLine(" Email or Password incorrect.");
                ApprovedLogin();
            }
        }
    }
}
