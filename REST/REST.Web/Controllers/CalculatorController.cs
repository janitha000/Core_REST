using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.Library.IServices;
using REST.Library.Entities;

namespace REST.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Calculator")]
    public class CalculatorController : Controller
    {
        private ICalculatorService _calculatorService;
        private ICalculatorInMemoryService _calculatorMemoryService;

        public CalculatorController(ICalculatorService calculatorService, ICalculatorInMemoryService calculatorMemoryService)
        {
            _calculatorService = calculatorService ?? throw new ArgumentNullException();
            _calculatorMemoryService = calculatorMemoryService ?? throw new ArgumentNullException();
        }

        [HttpGet("calculate/{order}")]
        [ProducesResponseType(200)]
        public IActionResult Calculate(string order, double val1, double val2)
        {
            double result = _calculatorService.Calculate(order, val1, val2);
            return Ok(result);
        }

        [HttpGet("history")]
        [ProducesResponseType(200)]
        public IActionResult GetHistory()
        {
            IEnumerable<CalculatorHistory> histories = _calculatorMemoryService.GetAll();
            return Ok(histories);
        }

        [HttpPost("history")]
        [ProducesResponseType(201)]
        public IActionResult AddHistory(CalculatorHistory calculatorHistory)
        {
            _calculatorMemoryService.Add(calculatorHistory);
            return Created("history", calculatorHistory);           
        }

        [HttpGet("history/{order}")]
        [ProducesResponseType(200)]
        public IActionResult GetHistoryByAction(string order)
        {
            IEnumerable<CalculatorHistory> histories = _calculatorMemoryService.GetByAction(order);
            return Ok(histories);
        }












    }
}