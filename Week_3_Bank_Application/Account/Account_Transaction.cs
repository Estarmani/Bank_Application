using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bank_Application
{
    public class Account_Transaction
    {
        decimal depositAmount;
        string depositAccount;
        string withdrawalAccount;
        decimal withdawalAmount;
        string accountToTranferTo;
        string accoutToTranferFrom;
        decimal transferAmount;

        public void Deposit(string account, decimal amount)
        {
            Console.Clear();
            Console.Write("\nEnter account to deposit: \n");
            depositAccount = Console.ReadLine();

            Console.Write("Enter amount to deposit: ");
            depositAmount = decimal.Parse(Console.ReadLine());

        }

        public void Withdrawal()
        {
            Console.Clear();
            Console.Write("Enter account to withdraw from: \n");
            withdrawalAccount = Console.ReadLine();

            Console.Write("Enter amount to withdraw: ");
            withdawalAmount = decimal.Parse(Console.ReadLine());

        }

        public void Transfer()
        {
            Console.Clear();
            Console.Write("Enter account to transfer from: \n\n");
            accoutToTranferFrom = Console.ReadLine();

            Console.Write("Enter account to transfer to: \n\n");
            accountToTranferTo = Console.ReadLine();

            Console.Write("Enter amount to transfer: ");
            transferAmount = decimal.Parse(Console.ReadLine());

        }
    }
}
