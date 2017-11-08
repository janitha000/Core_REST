using REST.Library.Entities;
using REST.Library.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Data.InMemoryRepository
{
    public class CalculatorInMemoryRepository : IInMemoryRepository<CalculatorHistory>
    {
        public void Add(CalculatorHistory item)
        {
            throw new NotImplementedException();
        }

        public CalculatorHistory Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculatorHistory> GetList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculatorHistory> GetList(string action)
        {
            throw new NotImplementedException();
        }
    }
}
