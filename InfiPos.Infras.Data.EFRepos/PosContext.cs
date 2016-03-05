using InfiPos.Core;
using System.Data.Entity;

namespace InfiPos.Infras.Data.EFRepos
{
    public class PosContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public PosContext() : base("Server=.\\SQLEXPRESS;Initial catalog=Pos;Integrated Security=SSPI")
        {
        }
    }
}
