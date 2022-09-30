using System.Globalization;
using InterfaceEx.Entities;
using InterfaceEx.Services;
try
{
    System.Console.WriteLine("Enter contract data");
    System.Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.Write("Date (dd/MM/yyyy): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    System.Console.Write("Contract value: ");
    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Contract contract = new Contract(number, date, value);

    System.Console.Write("Enter number of installments: ");
   int months = int.Parse(Console.ReadLine());
    
    ContractService contractService = new ContractService(new PaypalService());
    contractService.ProcessContract(contract, months);

    Console.WriteLine("Installments:");
    foreach (Installment installment in contract.Installments) {
        Console.WriteLine(installment);
}
}
catch (Exception e)
{
     System.Console.WriteLine("General Error: " +  e.Message);
}