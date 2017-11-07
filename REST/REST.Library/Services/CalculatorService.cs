using REST.Library.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Library.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Div(double value1, double value2)
        {
            throw new NotImplementedException();
        }

        public double Mul(double value1, double value2)
        {
            throw new NotImplementedException();
        }

        public double Sub(double value1, double value2)
        {
            throw new NotImplementedException();
        }
    }
}
