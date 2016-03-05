using InfiPos.Core;
using System.Data.Entity;

namespace InfiPos.Infras.Data.EFRepos
{
    public class EmployeeEFRepo : EFRepoBase<Employee>, IEmployeeRepo
    {
        protected override DbSet<Employee> GetDbSet()
        {
            return context.Employees;
        }

        //public abstract List<T> Search(string key);
    }
}
