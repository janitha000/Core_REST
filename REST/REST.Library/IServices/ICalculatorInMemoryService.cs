using REST.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Library.IServices
{
    public interface ICalculatorInMemoryService
    {
        void Add(CalculatorHistory item);
        CalculatorHistory Get();
        IEnumerable<CalculatorHistory> GetAll();
        IEnumerable<CalculatorHistory> GetByAction(string action);


    }
}
