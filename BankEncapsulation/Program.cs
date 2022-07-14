using BankEncapsulation;



var bankaccount1 = new BankAccount();

Console.WriteLine($"Hello, Your balance is: ${bankaccount1.GetBalance()}");
Console.WriteLine("How Much would you like to deposit?");
double x = double.Parse(Console.ReadLine());
bankaccount1.Deposit(x);
Console.WriteLine($"Hello, Your NEW balance is: ${bankaccount1.GetBalance()}");
Console.WriteLine("How Much would you like to withdrawl?");
double y = double.Parse(Console.ReadLine());
bankaccount1.Withdrawl(y);
Console.WriteLine($"Hello, Your NEW balance is: ${bankaccount1.GetBalance()}");
