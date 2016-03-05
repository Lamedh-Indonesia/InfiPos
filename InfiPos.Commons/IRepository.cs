using System.Collections.Generic;

namespace InfiPos.Commons
{
    public interface IRepository<T> where T : EntityBase
    {
        int GetCount();
        T GetById(int id);
        List<T> GetAll();
        void Save(T employee);
        void Delete(int id);
    }
}
