using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Bank_Application.Account
{
    public class Accounts
    {
        
        public  AccountType accountType{ get; set; }
        public string AccountNo { get; set; }
        public decimal AccountBal { get; set;}
        public string fullName { get; set;}
 
     
    }
    public enum AccountType
    {
        savings = 1, current = 2
    }
}
