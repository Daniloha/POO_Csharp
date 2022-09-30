using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        
        public ImportedProduct()
        {            
        }
        public ImportedProduct(string name, double price, double customsFee)
        : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return base.priceTag() + " (Customs fee: $ " 
            + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}