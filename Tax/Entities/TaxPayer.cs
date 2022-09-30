using System.Globalization;
namespace Tax.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        
        public TaxPayer()
        {            
        }
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        
        public abstract double tax();
         public override string ToString()
        {
            return Name 
            + ": $" + tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}