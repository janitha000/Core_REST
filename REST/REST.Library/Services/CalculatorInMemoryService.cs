using REST.Library.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using REST.Library.Entities;
using REST.Library.RepositoryInterfaces;

namespace REST.Library.Services
{
    public class CalculatorInMemoryService : ICalculatorInMemoryService
    {
        private IInMemoryRepository<CalculatorHistory> _calcultaorRepository;

        public CalculatorInMemoryService(IInMemoryRepository<CalculatorHistory> calcultaorRepository)
        {
            _calcultaorRepository = calcultaorRepository;
        }

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
            return _calcultaorRepository.GetList();
        }

        public IEnumerable<CalculatorHistory> GetByAction(string action)
        {
            return _calcultaorRepository.GetList(action);
        }
    }
}
