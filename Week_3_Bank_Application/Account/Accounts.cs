using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Bank_Application.Account
{
    internal class Accounts
    {
        public string Account_type{ get; set; }
        public string AccountNo { get; set; }
        public string AccountBal { get; set;}
        public int CustomerID { get; set; }

        public Accounts(string account_tpe, string accountNo, string accountBal, int customerID)
        {
            this.Account_type = account_tpe;
            this.AccountNo = accountNo;
            this.AccountBal = accountBal;
            this.CustomerID = customerID;
        }
    }
       
}
