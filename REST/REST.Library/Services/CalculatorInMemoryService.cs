using REST.Library.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using REST.Library.Entities;

namespace REST.Library.Services
{
    public class CalculatorInMemoryService : ICalculatorInMemoryService
    {
        public void Add(CalculatorHistory item)
        {
            throw new NotImplementedException();
        }

        public CalculatorHistory Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculatorHistory> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
