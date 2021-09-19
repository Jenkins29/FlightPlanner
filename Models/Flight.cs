using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightPlanner.Core.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public AirportRequest to { get; set; }
        public AirportRequest from { get; set; }
        public string carrier { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }

    }
}