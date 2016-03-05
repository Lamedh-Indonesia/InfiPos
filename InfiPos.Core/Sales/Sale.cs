using InfiPos.Commons;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfiPos.Core
{
    public class Sale : EntityBase
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }

        public virtual Employee Sales { get; set; }

        public virtual List<SaleLineItem> LineItems { get; set; }

        public Sale()
        {
            LineItems = new List<SaleLineItem>();
            Time = DateTime.Now;
        }

        public decimal GetTotal()
        {
            //decimal total = 0m;
            //foreach (var sli in LineItems)
            //{
            //    total += sli.UnitPrice * sli.Quantity;
            //}
            //return total;

            return LineItems.Sum(p => p.GetSubtotal());
        }

        public void AddLineItem(Product product, int quantity = 1)
        {
            var sli = GetLineItem(product);
            if (sli == null)
            {
                sli = new SaleLineItem { Product = product, };
                LineItems.Add(sli);
            }
            sli.Quantity += quantity;
        }

        public SaleLineItem GetLineItem(Product product)
        {
            foreach (var sli in LineItems)
            {
                if (sli.Product.Equals(product))
                    return sli;
            }
            return null;
        }
    }

}
