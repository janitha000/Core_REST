using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Library.RepositoryInterfaces
{
    public interface IInMemoryRepository<T> 
    {
        T Get();
        IEnumerable<T> GetList();
        void Add(T item);
        IEnumerable<T> GetList(string action);
    }
}
