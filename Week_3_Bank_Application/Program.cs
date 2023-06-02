using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User_Account newUser = new User_Account();
            newUser.User_SignUp();
        }
    }
}
