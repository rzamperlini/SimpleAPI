using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAPI.Controllers
{
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/Sum")]
        public ObjectResult Sum(float a, float b)
        {
            return Ok(a + b);
        }

        [HttpGet]
        [Route("/Product")]
        public ObjectResult Product(float a, float b)
        {
            return Ok(a * b);
        }

        [HttpGet]
        [Route("/Subtract")]
        public ObjectResult Subtract(float a, float b)
        {
            return Ok(a - b);
        }

        [HttpGet]
        [Route("/Division")]
        public ObjectResult Division(float a, float b)
        {
            float result = 0;

            if (b != 0)
                result = a / b;
            else
                return BadRequest("The divisor must be non-zero.");

            return Ok(result);
        }
    }
}
