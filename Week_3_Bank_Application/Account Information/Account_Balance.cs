using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Application;

namespace Week_3_Bank_Application.Account
{
    internal class Account_Balance<T> : Account_Transaction
    {
        List<T> balances = new List<T>();
        Account_Balance(T account)
        {

        }
    }
}
