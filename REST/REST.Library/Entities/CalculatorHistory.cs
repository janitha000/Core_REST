using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Library.Entities
{
    public class CalculatorHistory
    {
        public long Id { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public string Action { get; set; }
        public double Result { get; set; }
    }
}
