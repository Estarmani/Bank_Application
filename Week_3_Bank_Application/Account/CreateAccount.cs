using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;


namespace Bank_Application
{
    internal class CreateAccount
    {
        long SavingsAccount_No { get; set; }
        long CurrentAccount_No { get; set; }
        string Option { get; set; }


        public void AccountChoice()
        {
            Console.Clear();
            Console.WriteLine("\n                          ALLSTAR BANKING APPLICATION          ");
            Console.WriteLine("\n 1: Savings Account\n 2: Current");
            Console.WriteLine("\n Select any number to create an account \n");
            var option = Console.ReadLine().Trim();

            if (option == "1")
            {
                Console.Clear();
                SavingsAccount();
                Console.WriteLine("\n Savings Account created successfully");
                Console.WriteLine("Would you like to create another account? Y/N");
                var Option = Console.ReadLine().ToUpper().Trim();
            }
            else if (option == "2")
            {
                Console.Clear();
                CurrentAccount();
                Console.WriteLine("\n Current Account created successfully");
                Console.WriteLine(" Would you like to create another account? Y/N");
            }
            else
            {
                AccountChoice();
            }
        }

        public long SavingsAccount()
        {
            Random newAccount = new Random();
            SavingsAccount_No = newAccount.Next(300000000, 888888888);
            return SavingsAccount_No;
        }
        public long CurrentAccount()
        {
            Random newAccount = new Random();
            CurrentAccount_No = newAccount.Next(100000000, 999999999);
            return CurrentAccount_No;   
        }
        
    }
}
