using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics_2.Entities
{
    public class Elements : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Elements()
        {            
        }
        public Elements(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
            + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Elements)){
                throw new ArgumentException("Error: Argument is not a product");
            }
            Elements other = obj as Elements;
            return Price.CompareTo(other.Price);
        }
    }
}