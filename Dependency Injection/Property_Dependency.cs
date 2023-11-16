using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface IAccount2
    {
        void PrintDetails2();
    }

    public class CurrentAccount2 : IAccount2
    {
        public void PrintDetails2()
        {

            Console.WriteLine("Details of Current Account property");

        }

    }

    public class SavingAccount2 : IAccount2
    {
        public void PrintDetails2()
        {

            Console.WriteLine("Details of Saving Account property ");

        }

    }

    class Account2
    {
        public IAccount2 account { get; set; }

        public void PrintAcounts2()
        {
            account.PrintDetails2();
        }
    }
}
