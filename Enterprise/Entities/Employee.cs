using System.Globalization;
namespace Enterprise.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hour { get; set; }
        public double ValuePerHour { get; set; }
        
        public Employee()
        {}
        public Employee(string name, int hour, double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }
        
        public virtual double payment()
        {
            return Hour * ValuePerHour;
        }
        public override string ToString()
        {
            return Name + " - $ " + payment().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}