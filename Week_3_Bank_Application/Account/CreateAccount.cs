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
        static int Account_No;
        static string AccountType;





















        public int AccountChoice()
        {

            Console.Clear();
            Console.WriteLine("\n                          ALLSTAR BANKING APPLICATION          ");
            Console.WriteLine("\n 1: Savings Account\n 2: Current");
            Console.WriteLine("\n Select any number to create an account \n");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                Random newAccount = new Random();
                Account_No = newAccount.Next(300000000, 888888888);
                Console.WriteLine("\nSavings Account created successfully");

            }
            else if (option == "2")
            {
                Console.Clear();
                Random newAccount = new Random();
                Account_No = newAccount.Next(1000000000, 2099999999);

                Console.WriteLine("\nCurrent Account created successfully");
                Console.WriteLine(" Would you like to create another account? Y/N");
            }
            else
            {
                AccountChoice();
            }
            return Account_No;
        }

       public string TypeOfAccount()
        {
            if (option == "1")
            {
                return "Savings Account";
            }
            else if (option == "2")
            {
                return "Current Account";
            }
            else
            {
                
                return "Invalid Choice, Enter either 1 or 2";
            }
        }

       
        
    }
}
