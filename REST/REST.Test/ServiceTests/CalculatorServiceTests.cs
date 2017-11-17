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

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException) , "Should throw exception when dividing by zero")]
        public void Should_Not_Divide_by_zero()
        {
            int value1 = 20;
            int value2 = 0;

            double result = _calculatorService.Div(value1, value2);
        }

        [TestMethod]
        public void Calculate_Should_Success()
        {
            int value1 = 20;
            int value2 = 10;

            double result1 = _calculatorService.Calculate("Add", value1, value2);
            Assert.AreEqual(30, result1, "Should calculate Add values successfully");

            double result2 = _calculatorService.Calculate("Sub", value1, value2);
            Assert.AreEqual(10, result2, "Should calculate Sub values successfully");

            double result3 = _calculatorService.Calculate("Mul", value1, value2);
            Assert.AreEqual(200, result3, "Should calculate Mul values successfully");

            double result4 = _calculatorService.Calculate("Div", value1, value2);
            Assert.AreEqual(2, result4, "Should calculate Div values successfully");
        }
    }
}
