using System.Globalization;
using Bank.Entities;
using Bank.Entities.Exceptions;
try
{
    Console.WriteLine("\nEnter account data ");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string name = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account common = new Account(number, name, balance, limit);

    System.Console.Write("\nEnter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

   common.Withdraw(amount);

   System.Console.WriteLine("New balance: " + common.Balance.ToString("F2", CultureInfo.InvariantCulture) + "\n");

}
catch (MainException e)
{
    System.Console.WriteLine(e.Message);
}
catch (Exception e)
{
    System.Console.WriteLine("General error: " + e.Message);
}

