using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightPlanner.Core.Storage;
using FlightPlanner.Core.Models;
using FlightPlanner.Core.Storage;

namespace FlightPlanner.Core.Controllers
{
    [Route("testing-api")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        [HttpPost]
        [Route("clear")]
        public IActionResult Clear()
        {
            FlightStorage.ClearFlights();
            return Ok();
        }
    }
}