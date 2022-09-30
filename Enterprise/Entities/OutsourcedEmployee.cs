using System.Globalization;
namespace Enterprise.Entities 
{
    public class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }
        
        public OutsourcedEmployee()
        { }
        public OutsourcedEmployee(string name, int hour, double valuePerHour, double aditionalCharge)
        : base (name, hour, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double payment()
        {
            return (Hour * ValuePerHour) + (AditionalCharge * 1.1);
        }
         public override string ToString()
        {
            return Name + " - $ " + payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}