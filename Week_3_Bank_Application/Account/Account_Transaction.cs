using Bank_Application.Account;
using Bank_Application.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Week_3_Bank_Application.Account;
using Week_3_Bank_Application.User;

namespace Bank_Application
{
    public class Account_Transaction : CreateAccount
    {
        decimal depositAmount;
        string depositAccount;
        string withdrawalAccount;
        decimal withdawalAmount;
        string accountToTranferTo;
        string accoutToTranferFrom;
        decimal transferAmount;

        public void Deposit()
        {
            Console.Clear();
            Console.Write("\nEnter account to deposit: \n");
            depositAccount = Console.ReadLine();
            var account = accounts.FirstOrDefault(x => x.AccountNo == depositAccount);
          
            Console.Write("Enter amount to deposit: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            if (account == null)
            {
                Console.WriteLine("Account does not exist.");
            }
            else
            {
                account.AccountBal += depositAmount;
                var index = accounts.FindIndex(x => x.AccountNo == depositAccount);
                accounts[index] = account;
                Console.WriteLine("Deposit successful");
                var menu = new Menu();
                menu.MainMenu();
            }
            
        }

        public void Withdrawal()
        {
            Console.Clear();
            Console.Write("Enter account to withdraw from: \n");
            withdrawalAccount = Console.ReadLine();
            var account = accounts.Where(x => x.AccountNo == withdrawalAccount ).FirstOrDefault();
            Console.Write("Enter amount to withdraw: ");
            withdawalAmount = decimal.Parse(Console.ReadLine());

            if (account == null)
            {
                Console.WriteLine("Account does not exsit.");
            }
            else if (withdawalAmount == 0)
            {
                Console.WriteLine("Insuficient fund");
            }
            else
            {
                account.AccountBal -= withdawalAmount;
                var index = accounts.FindIndex(x => x.AccountNo == withdrawalAccount);
                accounts[index] = account;
                Console.WriteLine("Withdrawal successful.");
                var menu = new Menu();
                menu.MainMenu();
            }
        }

        public void Transfer()
        {
            Console.Clear();
            Console.Write("Enter account to transfer from: \n\n");
            accoutToTranferFrom = Console.ReadLine();
            var accountFrom = CreateAccount.accounts.FirstOrDefault(x => x.AccountNo == accoutToTranferFrom);
            
            Console.Write("Enter account to transfer to: \n\n");
            accountToTranferTo = Console.ReadLine();
            Accounts accountTo = accounts.Where(x => x.AccountNo == accountToTranferTo).FirstOrDefault();

            Console.Write("Enter amount to transfer: ");
            transferAmount = decimal.Parse(Console.ReadLine());

            if (accountFrom != null && accountTo != null && transferAmount > 0)
            { 
                accountFrom.AccountBal -= transferAmount;
                accountTo.AccountBal += transferAmount;
                Console.WriteLine("Transfer success.");
            }
            else
            {
                Console.WriteLine("An error occured.");
            }

        }

        public void GetAccountBalance()
        {
            Console.Clear();
            Console.WriteLine("\n Enter account number to view balance");
            var accountNumber = Console.ReadLine();
            var account = accounts.FirstOrDefault(x => x.AccountNo == accountNumber);

            if (account == null)
            {
                Console.WriteLine("Account does not exist.");
                var menu = new Menu();
                menu.MainMenu();
            }

            Console.WriteLine($"Account balance for {accountNumber} is {account.AccountBal}");
            var getmenu = new Menu();
            getmenu.MainMenu();
            
        }
    }
}
