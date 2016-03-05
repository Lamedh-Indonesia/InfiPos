using InfiPos.Commons;

namespace InfiPos.Core
{
    public class Product : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
