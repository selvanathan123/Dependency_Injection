using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface IAccount1
    {
        void PrintDetails1();
    }

    public class CurrentAccount1 : IAccount1
    {
        public void PrintDetails1()
        {

            Console.WriteLine("Details of Current Account Method");

        }

    }

    public class SavingAccount1 : IAccount1
    {
        public void PrintDetails1()
        {

            Console.WriteLine("Details of Saving Account Method ");

        }

    }

    class Account1
    {
        public void PrintAccounts1(IAccount1 account)
        {
            account.PrintDetails1();

        }
    }
}
