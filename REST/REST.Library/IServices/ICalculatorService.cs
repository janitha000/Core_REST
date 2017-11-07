using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Library.IServices
{
    public interface ICalculatorService
    {
        double Add(double value1, double value2);
        double Sub(double value1, double value2);
        double Mul(double value1, double value2);
        double Div(double value1, double value2);
    }
}
