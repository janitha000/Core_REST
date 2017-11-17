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

        public double Calculate(string action, double value1, double value2)
        {
            switch (action)
            {
                case "Add": 
                        return Add(value1, value2);
                case "Sub":
                    return Sub(value1, value2);
                case "Mul":
                    return Mul(value1, value2);
                case "Div":
                    return Div(value1, value2);
                default:
                    return 0;
            }
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
