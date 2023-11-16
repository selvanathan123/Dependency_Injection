using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
   public interface IAccount
    {
        void PrintDetails();
    }

    public class CurrentAccount: IAccount
    {
        public void PrintDetails() 
        {

            Console.WriteLine("Details of Current Account");

        }

    }

    public class SavingAccount: IAccount
    {
        public void PrintDetails()
        {

            Console.WriteLine("Details of Saving Account");

        }

    }

    class Account
    {
        private IAccount account;

        public Account(IAccount account)
        {
            this.account = account;
        }

        public void PrintAccounts()
        {
            account.PrintDetails();
        }
    }
}
