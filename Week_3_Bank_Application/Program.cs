using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3_Bank_Application.Account_Information;

namespace Bank_Application.User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User_Account newUser = new User_Account();
            newUser.UserSignUp();

           // PrintTable printTable = new PrintTable();
            //printTable.AccountDetailsTable();
        }
    }
}
