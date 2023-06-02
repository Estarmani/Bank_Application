using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Application.Account;

namespace Bank_Application.User
{
    public class Menu
    {
        internal string option;
        public void Main_Menu()
        {
            Console.WriteLine("\n                         ALLSTAR BANKING APPLICATION                       ");
            Console.WriteLine("\n 1: Creat Account\n 2: Check Balance\n 3: Deposit\n 4: Withdrawal");
            Console.WriteLine(" 5: Transfer\n 6: Account Details\n 7: Account Statement");
            option = Console.ReadLine().Trim();

            if (option == "1")
            {
                CreateAccount newAccount = new CreateAccount();
                newAccount.AccType();

            }
            else if (option == "2")
            {

            }
            else if (option == "3")
            {

            }
            else if (option == "4")
            {

            }
            else if (option == "5")
            {

            }
            else if (option == "6")
            {

            }
            else if (option == "7")
            {

            }
            else
            {
                Main_Menu();
            }
        }
    }
}
