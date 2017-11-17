using REST.Library.Entities;
using REST.Library.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace REST.Data.InMemoryRepository
{
    public class CalculatorInMemoryRepository : IInMemoryRepository<CalculatorHistory>
    {
        public void Add(CalculatorHistory item)
        {
            using(InMemoryContext context = new InMemoryContext())
            {
                context.CalculatorInMemoryHistory.Add(item);
                context.SaveChanges();
            }
        }

        public CalculatorHistory Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculatorHistory> GetList()
        {
            IEnumerable<CalculatorHistory> history;
            using(InMemoryContext context = new InMemoryContext())
            {
                history = context.CalculatorInMemoryHistory.AsEnumerable();
            }

            return history;
        }

        public IEnumerable<CalculatorHistory> GetList(string action)
        {
            IEnumerable<CalculatorHistory> history;
            using (InMemoryContext context = new InMemoryContext())
            {
                history = context.CalculatorInMemoryHistory.Where(x => x.Action == action);
            }

            return history;
        }
    }
}
