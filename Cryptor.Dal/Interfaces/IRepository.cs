using System;
using System.Collections.Generic;

namespace Cryptor.Dal.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T item);
        T Read(Int32 id);
        void Update(T item);
        void Delete(Int32 id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        IEnumerable<T> GetAll();
    }
}