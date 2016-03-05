using InfiPos.Commons;
using InfiPos.Core;
using System.Collections.Generic;
using System.Linq;

namespace InfiPos.Infras.Data.InMemory
{
    public abstract class MemoryRepoBase<T> where T : EntityBase
    {
        private List<T> data = new List<T>();

        public T GetById(int id)
        {
            return data.SingleOrDefault(p => p.Id == id);
        }

        public List<T> GetAll()
        {
            return data;
        }

        public void Save(T product)
        {
            data.Add(product);
        }

        public void Delete(int id)
        {
            data.RemoveAt(id);
        }

        public abstract List<T> Search(string key);
    }
}
