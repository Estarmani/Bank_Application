﻿using Bank_Application.Account;
using Bank_Application.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3_Bank_Application.Account;

namespace Week_3_Bank_Application.Account_Information
{
    internal class PrintTable : Accounts
    {
        public void AccountDetailsTable()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t|------------------|--------------------|---------------|--------------------|");
            Console.WriteLine("\t|   FULLNAME       |   ACCOUNT NUMBER   |  ACCOUNT TYPE |  ACCOUNT BALANCE   |");
            Console.WriteLine("\t|------------------|--------------------|---------------|--------------------|");
            Console.Write($"\t{ AccountDetails()}");
            Console.WriteLine("\t|------------------|--------------------|---------------|--------------------|");

            var menu = new Menu();
            menu.MainMenu();
        }

        public void AccountStatementTable()
        {
            Console.WriteLine("\n\n\t|------------------|--------------------|---------------|--------------------|");
            Console.WriteLine("\t|       DATE       |    DESCRIPTION     |     AMOUNT    |       BALANCE      |");
            Console.WriteLine("\t|------------------|--------------------|---------------|--------------------|");
            Console.WriteLine();
            Console.WriteLine("\t|------------------|--------------------|---------------|--------------------|");
        } 
        
        public string AccountDetails()
        {
            string printdetails = "";

            foreach (Accounts acc in CreateAccount.accounts)
            {
                printdetails = $"|  {acc.fullName, -14}  |  {acc.AccountNo, -16}  |  {acc.accountType, -11}  |  {acc.AccountBal, -17} |\n";
            }
            return printdetails;
        }
    }
}
