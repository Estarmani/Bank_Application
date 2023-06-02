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




        public string AccType()
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
                accNo = newAccount.Next(0000000000, 1999999999);
                string result = "0" + accNo.ToString();
                Console.WriteLine("\nSavings Account created successfully");
                Console.WriteLine(result);
                return result;
            }
            else if (option == "2")
            {
                Console.Clear();
                accountType = "current";
                Random newAccount = new Random();
                accNo = newAccount.Next(1000000000, 1999999999);
                string result = "0" + accNo.ToString();
                Console.WriteLine("\nCurrent Account created successfully"); 
                Console.WriteLine(result);
                return result;
            }
            else
            {
                AccType();
            }
            return string.Empty;
        }
       
 
         
    }
}
