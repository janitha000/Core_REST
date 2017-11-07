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
            Assert.AreEqual( 30, result, "Should add values successfully");
        }

        [TestMethod]
        public void Sub_Should_Success()
        {
            int value1 = 20;
            int value2 = 10;

            double result = _calculatorService.Sub(value1, value2);
            Assert.AreEqual(10, result, "Should subtract values successfully");
        }

        [TestMethod]
        public void Mul_Should_Success()
        {
            int value1 = 10;
            int value2 = 20;

            double result = _calculatorService.Mul(value1, value2);
            Assert.AreEqual( 200, result, "Should multiple values successfully");
        }

        [TestMethod]
        public void Div_Should_Success()
        {
            int value1 = 20;
            int value2 = 10;

            double result = _calculatorService.Div(value1, value2);
            Assert.AreEqual( 2, result, "Should division values successfully");
        }

        public void Should_Return_NullException()
        {

        }
    }
}
