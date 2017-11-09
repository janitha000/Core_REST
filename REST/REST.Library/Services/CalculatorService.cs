using Microsoft.VisualStudio.Web.CodeGeneration;
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
            if (value2 == 0)
                throw new DivideByZeroException();
            try
            {
                return value1 / value2;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public double Mul(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Sub(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}
