using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using REST.Library.Entities;
using REST.Library.RepositoryInterfaces;
using REST.Library.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Test.ServiceTests
{
    [TestClass]
    public class CalculatorInMemoryServiceTests
    {
        private readonly CalculatorInMemoryService _calculatorInMemoryService;
        private Mock<IInMemoryRepository<CalculatorHistory>> _mockCalculatorRepository;

        public CalculatorInMemoryServiceTests()
        {
            _mockCalculatorRepository = new Mock<IInMemoryRepository<CalculatorHistory>>();
            _calculatorInMemoryService = new CalculatorInMemoryService(_mockCalculatorRepository.Object);
        }

        [TestMethod]
        public void Should_Return_All_Actions()
        {
            var expectedResults = new List<CalculatorHistory>
            {
                new CalculatorHistory() { Action="Add", Value1=20, Value2=10, Result=30},
                new CalculatorHistory() { Action="Sub", Value1=20, Value2=10, Result=10},
                new CalculatorHistory() { Action="Div", Value1=20, Value2=10, Result=2}
            };

            _mockCalculatorRepository.Setup(x => x.GetList()).Returns(expectedResults);

            var result = _calculatorInMemoryService.GetAll();
            Assert.AreSame(expectedResults, result, "Should return all history");
        }

        [TestMethod]
        public void Should_Return_Add_Actions()
        {
            var expectedResults = new List<CalculatorHistory>
            {
                new CalculatorHistory() { Action="Add", Value1=20, Value2=10, Result=30},
                new CalculatorHistory() { Action="Add", Value1=20, Value2=20, Result=40}
            };

            _mockCalculatorRepository.Setup(x => x.GetList("Add")).Returns(expectedResults);

            var result = _calculatorInMemoryService.GetByAction("Add");
            Assert.AreSame(expectedResults, result, "Should return only Add history");
        }

        [TestMethod]
        public void Should_Return_Sub_Actions()
        {
            var expectedResults = new List<CalculatorHistory>
            {
                new CalculatorHistory() { Action="Sub", Value1=20, Value2=10, Result=10},
                new CalculatorHistory() { Action="Sub", Value1=20, Value2=20, Result=0}
            };

            _mockCalculatorRepository.Setup(x => x.GetList("Sub")).Returns(expectedResults);

            var result = _calculatorInMemoryService.GetByAction("Sub");
            Assert.AreSame(expectedResults, result, "Should return only Sub history");
        }

        [TestMethod]
        public void Should_Return_Mul_Actions()
        {
            var expectedResults = new List<CalculatorHistory>
            {
                new CalculatorHistory() { Action="Mul", Value1=20, Value2=10, Result=200},
                new CalculatorHistory() { Action="Mul", Value1=20, Value2=20, Result=400}
            };

            _mockCalculatorRepository.Setup(x => x.GetList("Mul")).Returns(expectedResults);

            var result = _calculatorInMemoryService.GetByAction("Mul");
            Assert.AreSame(expectedResults, result, "Should return only Mul history");
        }

        [TestMethod]
        public void Should_Return_Div_Actions()
        {
            var expectedResults = new List<CalculatorHistory>
            {
                new CalculatorHistory() { Action="Div", Value1=20, Value2=10, Result=2},
                new CalculatorHistory() { Action="Div", Value1=20, Value2=20, Result=1}
            };

            _mockCalculatorRepository.Setup(x => x.GetList("Div")).Returns(expectedResults);

            var result = _calculatorInMemoryService.GetByAction("Div");
            Assert.AreSame(expectedResults, result, "Should return only Div history");
        }

        [TestMethod]
        public void Should_ADD_Database()
        {

            CalculatorHistory calculatorHistory =  new CalculatorHistory() { Action = "Div", Value1 = 20, Value2 = 10, Result = 2 };
        }

    }
}
