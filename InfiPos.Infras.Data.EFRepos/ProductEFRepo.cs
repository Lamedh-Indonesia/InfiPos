using InfiPos.Core;
using System.Data.Entity;

namespace InfiPos.Infras.Data.EFRepos
{
    public class ProductEFRepo : EFRepoBase<Product>, IProductRepo
    {
        protected override DbSet<Product> GetDbSet()
        {
            return context.Products;
        }

        //public abstract List<T> Search(string key);
    }
}
