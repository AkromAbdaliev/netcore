// encapsulation
using netcore;

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine($"Your bank acoount : ${bankAccount.GetBalance()}");

bankAccount.Deposit(-50);
Console.WriteLine($"After your deposit : ${bankAccount.GetBalance()}");

bankAccount.Withdraw(25);
Console.WriteLine($"After your withdraw : ${bankAccount.GetBalance()}");

