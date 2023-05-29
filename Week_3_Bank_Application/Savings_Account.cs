using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Bank_Application
{
    internal class Savings_Account
    {
        public static int savingsAccount;
        public void Savings()
        {
            Random newRandom = new Random();
            savingsAccount = newRandom.Next(300000000, 888888888);
        }
        
    }
}
