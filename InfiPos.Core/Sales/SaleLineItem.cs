using InfiPos.Commons;

namespace InfiPos.Core
{
    public class SaleLineItem : EntityBase
    {
        private Product product;

        public int Quantity { get; set; }
        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                UnitPrice = product.UnitPrice;
            }
        }
        public decimal UnitPrice { get; set; }

        public decimal GetSubtotal()
        {
            return Quantity * UnitPrice;
        }
    }
}
