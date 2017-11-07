using Microsoft.VisualStudio.TestTools.UnitTesting;
using REST.Library.IServices;
using REST.Library.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Test.ServiceTests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private ICalculatorService _calculatorService;

        public CalculatorServiceTests() => _calculatorService = new CalculatorService();

        [TestMethod]
        public void Add_Should_Success()
        {
            int value1 = 10;
            int value2 = 20;

            double result = _calculatorService.Add(value1, value2);
            Assert.AreEqual(result, 30, "Should add values successfully");
        }

        public void Should_Return_NullException()
        {

        }
    }
}
