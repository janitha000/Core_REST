using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.Library.IServices;

namespace REST.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Calculator")]
    public class CalculatorController : Controller
    {
        private ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService ?? throw new ArgumentNullException();
        }

        [HttpGet("{Add}")]
        [ProducesResponseType(200)]
        public IActionResult Add(double val1, double val2)
        {
            double result = _calculatorService.Add(val1, val2);
            return Ok(result);
        }








    }
}