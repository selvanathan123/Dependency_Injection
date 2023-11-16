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


        Account1 cam = new Account1();
        cam.PrintAccounts1(new CurrentAccount1());

        Account1 sam = new Account1();
        cam.PrintAccounts1(new SavingAccount1());

    }
}