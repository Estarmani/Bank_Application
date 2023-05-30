using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week_3_Bank_Application
{
    public class User_Login : User_Account 
    { 
        bool IsValue;
        public void ApprovedLogin()
        {
            Console.WriteLine("\n Enter your Email: ");
            var e = Console.ReadLine();
            Console.WriteLine("\n Enter your Password: ");
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
                

            }
        }
    }
}
