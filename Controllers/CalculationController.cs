using MathOperationsAPI.Models;
using MathOperationsAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MathOperationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calculationService;
        public CalculationController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromQuery] int a, [FromQuery] int b)
        {
            return Ok(_calculationService.add(a, b));
        }

        [HttpPost("multiply")]
        public IActionResult Multiply([FromBody] OperationClass operation)
        {
            return Ok(_calculationService.multiply(operation.A, operation.B));
        }

        [HttpPost("divide/{a}/{b}")]
        public IActionResult Divide(int a, int b)
        {
            if (b == 0) return BadRequest("Cannt divide by zero");
            return Ok(_calculationService.divide(a, b));
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromHeader(Name ="A")]int a, [FromHeader(Name = "B")] int b)
        {
            return Ok(_calculationService.subtract(a, b));
        }

    }
}
