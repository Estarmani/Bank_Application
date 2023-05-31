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
        long savingsAccount_No { get; set; }
        long currentAccount_No { get; set; }
        string option { get; set; }
        string Account_Type { get; set; }

        public long SavingsAccount()
        {
            Random newAccount = new Random();
            savingsAccount_No = newAccount.Next(300000000, 888888888);
            return savingsAccount_No;
        }
        public long CurrentAccount()
        {
            Random newAccount = new Random();
            currentAccount_No = newAccount.Next(100000000, 999999999);
            return currentAccount_No;   
        }
        
    }
}
