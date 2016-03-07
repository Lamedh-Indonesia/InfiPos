using InfiPos.Commons;

namespace InfiPos.Core.Products
{
    public class ProductService : DomainServiceBase<Product>
    {
        public ProductService(IProductRepo productRepo) : base(productRepo)
        {
        }

        public override Product CreateNew()
        {
            return new Product { Code = GenerateCode(), };
        }

        public string GenerateCode()
        {
            return "P" + (entityRepo.GetCount() + 1);
        }
    }
}
