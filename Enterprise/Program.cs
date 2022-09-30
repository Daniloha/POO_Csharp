using System.Globalization;
using Enterprise.Entities;

Console.Write("Enter the number of employees: ");
int N = int.Parse(Console.ReadLine());
List<Employee> employees = new List<Employee>();

for (int i = 0; i < N; i++){
System.Console.WriteLine($"Employee #{i+1} data:");
Console.Write("Outsourced (y/n)? ");
char status = char.Parse(Console.ReadLine());
Console.Write("Name: ");
String name = Console.ReadLine();
Console.Write("Hours: ");
int hour = int.Parse(Console.ReadLine());
Console.Write("Value per hour: ");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
if (status == 'y')
{
    Console.Write("Additional charge: ");
    double add =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    OutsourcedEmployee employee = new OutsourcedEmployee(name, hour, value, add);
    employees.Add(employee);
}else{
Employee employee = new Employee(name, hour, value);
employees.Add(employee);
}
}
System.Console.WriteLine(" ");
System.Console.WriteLine("PAYMENTS:");
foreach (var employee in employees)
{
    System.Console.WriteLine(employee.ToString());
}