using System.Globalization;
using System.Threading.Tasks;
using Tax.Entities;

Console.Write("Enter the number of tax payers: ");
int N =  int.Parse(Console.ReadLine());

List<TaxPayer> payers = new List<TaxPayer>();

for (int i = 0; i < N ; i++){
    System.Console.WriteLine($"Tax payer #{i+1} data: Individual or company");
    System.Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (type == 'i'){
        System.Console.Write("Health expenditures: ");
        double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        payers.Add(new Individual(name, income, expenditures));
    }else if(type == 'c'){
        System.Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        payers.Add(new Company(name, income, employees));
    }
}

System.Console.WriteLine("\nTAXES PAID:");
double sum = 0;
foreach (TaxPayer item in payers){
    sum =+ item.tax();
    System.Console.WriteLine(item);
}
System.Console.WriteLine("\nTOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
