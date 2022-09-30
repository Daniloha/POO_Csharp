using System.Globalization;
using Generics_2.Services;
using Generics_2.Entities;

List<Elements> list = new List<Elements>();

Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine());

for(int i = 0; i < N; i++){
    string[] vect = Console.ReadLine().Split(",");
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    list.Add(new Elements (name, price));
}

CalculationService calculationService = new CalculationService();

Elements max = calculationService.Max(list);

System.Console.WriteLine("Max: ");
System.Console.WriteLine(max);