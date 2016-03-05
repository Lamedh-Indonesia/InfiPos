using InfiPos.Commons;
using System.Collections.Generic;
using System.Data.Entity;
using System;

namespace InfiPos.Infras.Data.EFRepos
{
    abstract public class EFRepoBase<T> : IRepository<T> where T : EntityBase
    {
        protected PosContext context = new PosContext();

        public int GetCount()
        {
            return GetDbSet().CountAsync().Result;
        }

        public T GetById(int id)
        {
            return GetDbSet().SingleAsync(p => p.Id == id).Result;
        }

        public List<T> GetAll()
        {
            return GetDbSet().ToListAsync().Result;
        }

        public void Save(T entity)
        {
            GetDbSet().Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            GetDbSet().Remove(entity);
        }

        abstract protected DbSet<T> GetDbSet();
    }
}
