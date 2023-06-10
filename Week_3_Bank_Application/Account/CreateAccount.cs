using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Week_3_Bank_Application.Account;
using Bank_Application.User;
using Week_3_Bank_Application.User;

namespace Bank_Application.Account
{
    public class CreateAccount  
    {
        string option { get; set; }
        int accNo { get; set; }
        public static List<Accounts> accounts = new List<Accounts>();




        public string AccType()
        {

            
            Console.Clear();
            Console.WriteLine("\n                          ALLSTAR BANKING APPLICATION          \n");
            Console.WriteLine("\n 1: Savings Account\n 2: Current");
            Console.WriteLine("\n Select any number to create an account \n");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                Random newAccount = new Random();
                accNo = newAccount.Next(0000000000, 1999999999);
                string result = "0" + accNo.ToString();
                var account = new Accounts
                {
                    AccountBal = 1000,
                    AccountNo = result,
                    accountType = AccountType.savings,
                    fullName = Customer.FirstName + " " + Customer.LastName,
                };
                accounts.Add(account);
                Console.WriteLine("\nSavings Account created successfully");
                Console.WriteLine(result);
                Menu menu = new Menu();
                menu.MainMenu();
                return result;
               
            }
            else if (option == "2")
            {
                Console.Clear();
               
                Random newAccount = new Random();
                accNo = newAccount.Next(1000000000, 1999999999);
                string result = "1" + accNo.ToString();
                var account = new Accounts
                {
                    AccountBal = 0,
                    AccountNo = result,
                    accountType = AccountType.current,
                    fullName = Customer.FirstName + " " + Customer.LastName,
                };
                accounts.Add(account);
                Console.WriteLine("\nCurrent Account created successfully"); 
                Console.WriteLine(result);
                Menu menu = new Menu();
                menu.MainMenu();
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
