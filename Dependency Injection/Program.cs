using Dependency_Injection;

class program
{
    static void Main( string [] args)
    {
        //Constructor Dependency Injection 
        IAccount ca = new CurrentAccount();
        Account a = new Account(ca);
        a.PrintAccounts();

        IAccount sa = new SavingAccount();
        Account a1 = new Account(sa);
        a1.PrintAccounts();

        //Method Dependency Injection
        Account1 cam = new Account1();
        cam.PrintAccounts1(new CurrentAccount1());

        Account1 sam = new Account1();
        cam.PrintAccounts1(new SavingAccount1());

        //Property Dependency Injection
        Account2 cap = new Account2();
        cap.account = new CurrentAccount2();
        cap.PrintAcounts2();

        Account2 sap = new Account2();
        sap.account = new SavingAccount2();
        sap.PrintAcounts2();

    }
}