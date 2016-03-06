using System;
using System.Collections.Generic;

namespace InfiPos.Commons
{
    public interface IRepository<T> : IDisposable where T : EntityBase
    {
        int GetCount();
        T GetById(int id);
        List<T> GetAll(int page, int size);
        void Save(T employee);
        void Delete(int id);
    }
}
