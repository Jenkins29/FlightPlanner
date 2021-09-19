using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightPlanner.Core.Models
{
    public class AirportRequest
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Airport { get; set; }
    }
}