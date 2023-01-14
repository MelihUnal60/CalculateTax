using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTax
{
    public class CalculateTaxPayment
    {
        
        public static Tax1 Tax(decimal total,CalculateTaxOptions options)
        {

            Tax1 tax1 = new Tax1();
            tax1.KDV = total * options.KDVRate;
            var totalWithoutKDV = total - tax1.KDV;
            
            if(options.IsCo)
            {
                tax1.tax2 = totalWithoutKDV * options.corporationTax;
            }
            else
            {
                tax1.tax2 = totalWithoutKDV * options.incomeTax;
            }
            return tax1;
        }

    }
    public class CalculateTaxOptions
    {
        public decimal KDVRate = .18m;
        public decimal incomeTax = .17m;
        public decimal corporationTax = .23m;
        public bool IsCo = false;
    }

    public class Tax1
    {
        public decimal KDV;
        public decimal tax2;
    }
}
