using Rental_car.Entities;
using Rental_car.Services;
using System.Globalization;
try
{
    System.Console.WriteLine("Enter rental data ");
    System.Console.Write("Car model: ");
    string model = Console.ReadLine();
    System.Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
    DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
    System.Console.Write("Return (dd/MM/yyyy hh:mm): ");
    DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

    System.Console.Write("Enter price per hour: ");
    double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    System.Console.Write("Enter price per day: ");
    double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    CarRental car = new CarRental(start, finish, new Vehicle(model));

    RentalServices rentalServices = new RentalServices(hour, day, new BrazilTaxService());
    rentalServices.ProcessInvoice(car);

    System.Console.WriteLine("INVOICE: ");
    System.Console.WriteLine(car.Invoice);
}
catch (Exception e)
{
     System.Console.WriteLine("General error: "+e.Message);
}
