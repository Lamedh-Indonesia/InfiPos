using InfiPos.Commons;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace InfiPos.Infras.Data.EFRepos
{
    abstract public class EFRepoBase<T> : IRepository<T> where T : EntityBase
    {
        protected PosContext context = new PosContext();
        private DbSet<T> dbSet;

        public EFRepoBase()
        {
            dbSet = context.Set<T>();
        }

        public int GetCount()
        {
            return dbSet.CountAsync().Result;
        }

        public T GetById(int id)
        {
            return dbSet.SingleAsync(p => p.Id == id).Result;
        }

        public List<T> GetAll(int page, int size)
        {
            return dbSet.OrderBy(e => e.Id).Skip(page * (size - 1)).Take(size).ToListAsync().Result;
        }

        public void Save(T entity)
        {
            if (entity.Id == 0)
                dbSet.Add(entity);
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
