using Dependency_Injection;

class program
{
    static void Main( string [] args)
    {
        IAccount ca = new CurrentAccount();
        Account a = new Account(ca);
        a.PrintAccounts();

        IAccount sa = new SavingAccount();
        Account a1 = new Account(sa);
        a1.PrintAccounts();

    }
}