using Dependency_Injection;

class program
{
    static void Main( string [] args)
    {
        IAccount ca = new CurrentAccount();
        Account a = new Account(ca);
        a.PrintAccounts();

       

    }
}