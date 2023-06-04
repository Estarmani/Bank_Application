using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Application.Account;
using Week_3_Bank_Application.User;

namespace Bank_Application.User
{
    public class Menu
    {
        internal string option;
        public void MainMenu()
        {
            
            Console.WriteLine("\n 1: Creat Account\n 2: Check Balance\n 3: Deposit\n 4: Withdrawal");
            Console.WriteLine(" 5: Transfer\n 6: Account Details\n 7: Account Statement\n 8: Logout\n");
            Console.Write("Select any number to continue: ");
            option = Console.ReadLine().Trim();

            if (option == "1")
            {
                CreateAccount newAccount = new CreateAccount();
                newAccount.AccType();

            }
            else if (option == "2")
            {
                var balance = new Account_Transaction();
                balance.GetAccountBalance();
            }
            else if (option == "3")
            {
                Account_Transaction transaction = new Account_Transaction();
                transaction.Deposit();
            }
            else if (option == "4")
            {
                Account_Transaction transaction4 = new Account_Transaction();
                transaction4.Withdrawal();
            }
            else if (option == "5")
            {
                Account_Transaction transaction5 = new Account_Transaction();
                transaction5.Transfer();
            }
            else if (option == "6")
            {

            }
            else if (option == "7")
            {

            }
            else if (option == "8")
            {
                var logout = new Userlogout();
                logout.LogOutUser();
            }
            else
            {
                MainMenu();
            }
        }
    }
}
