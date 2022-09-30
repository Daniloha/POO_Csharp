using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_car.Services
{
    public class BrazilTaxService : ITaxServices
    {
        public double Tax(double amount){
            if(amount <= 100){
                return amount * 0.2;
            }else{
                return amount * 0.15;
            }
        }
    }
}