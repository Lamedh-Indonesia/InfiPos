using InfiPos.Core;
using InfiPos.Core.Sales;
using System.Data.Entity;

namespace InfiPos.Infras.Data.EFRepos
{
    public class SaleEFRepo : EFRepoBase<Sale>, ISaleRepo
    {
        protected override DbSet<Sale> GetDbSet()
        {
            return context.Sales;
        }

        //public abstract List<T> Search(string key);
    }
}
