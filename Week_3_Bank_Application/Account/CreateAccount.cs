using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Week_3_Bank_Application.Account;
using Bank_Application.User;

namespace Bank_Application.Account
{
    internal class CreateAccount
    {
        string option { get; set; }
        string accountType = "";
        int accNo = 0;




        public int AccType()
        {

            
            Console.Clear();
            Console.WriteLine("\n                          ALLSTAR BANKING APPLICATION          ");
            Console.WriteLine("\n 1: Savings Account\n 2: Current");
            Console.WriteLine("\n Select any number to create an account \n");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                accountType = "savings";
                Random newAccount = new Random();
                accNo = newAccount.Next(0000000000, 0999999999);
                Console.WriteLine("\nSavings Account created successfully");
                return accNo;
            }
            else if (option == "2")
            {
                Console.Clear();
                accountType = "current";
                Random newAccount = new Random();
                accNo = newAccount.Next(1000000000, 1999999999);
                Console.WriteLine("\nCurrent Account created successfully"); 
                return accNo;
            }
            else
            {
                AccType();
            }
            return accNo;
        }
       
 
         
    }
}
