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
        private InMemoryContext _context;

        public CalculatorInMemoryRepository(InMemoryContext context)
        {
            _context = context;
        }

        public void Add(CalculatorHistory item)
        {
            _context.CalculatorInMemoryHistory.Add(item);
            _context.SaveChanges();

            
        }

        public CalculatorHistory Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculatorHistory> GetList()
        {
            IEnumerable<CalculatorHistory> history;

            history = _context.CalculatorInMemoryHistory.AsEnumerable();


            return history;
        }

        public IEnumerable<CalculatorHistory> GetList(string action)
        {
            IEnumerable<CalculatorHistory> history;

                history = _context.CalculatorInMemoryHistory.Where(x => x.Action == action);
            

            return history;
        }
    }
}
