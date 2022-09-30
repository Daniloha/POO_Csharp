using Inn.Entities;
using Inn.Entities.Exceptions;
try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine());


    Reservation room = new Reservation(number, checkin, checkout);
    System.Console.WriteLine(room);

    System.Console.WriteLine("\nEnter data to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine());

    room.UpdateDates(checkin, checkout);

    System.Console.WriteLine(room);

}


catch (DomainException e)
{
   System.Console.WriteLine( e.Message);
}

catch(FormatException e){
    System.Console.WriteLine("Format error: " + e.Message);
}
catch(Exception e){
    System.Console.WriteLine("General error: " + e.m);
}

