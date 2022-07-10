﻿using Microsoft.AspNetCore.Http;
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
        public Int32 Sum(Int32 a, Int32 b)
        {
            return a + b;
        }

        [HttpGet]
        [Route("/Product")]
        public Int32 Product(Int32 a, Int32 b)
        {
            return a * b;
        }
    }
}
