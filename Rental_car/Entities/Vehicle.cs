namespace Rental_car.Entities
{
    public class Vehicle
    {
        public string Model { get; set; }
        public Vehicle()
        {            
        }
        public Vehicle(string model)
        {
            Model = model;
        }
    }
}