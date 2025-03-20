


using ConsoleApp7;

BankAccount anitasAccount = new BankAccount();
anitasAccount.Deposit(100);
anitasAccount.Withdraw(50);
Console.WriteLine(anitasAccount.Balance);

BankAccount felixAcccount = new BankAccount();
felixAcccount.Deposit(200);
felixAcccount.Withdraw(100);
Console.WriteLine(felixAcccount.Balance);


BankAccount victorsAccount = new BankAccount(50000);
victorsAccount.Deposit(1000);
victorsAccount.Withdraw(5000);
Console.WriteLine(victorsAccount.Balance);

BankAccount calebsAccount = new BankAccount(100000);
calebsAccount.Deposit(10000);



Console.ReadKey();