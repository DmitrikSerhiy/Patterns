using State;

Console.Title = "State";


var bankAccount = new BankAccount(500);

bankAccount.Withdraw(200);
bankAccount.Display();

bankAccount.Withdraw(200);
bankAccount.Display();

bankAccount.Withdraw(200);
bankAccount.Display();

bankAccount.Withdraw(200);
bankAccount.Display();

bankAccount.Deposite(500);
bankAccount.Display();

bankAccount.Withdraw(200);
bankAccount.Display();



Console.ReadKey();

