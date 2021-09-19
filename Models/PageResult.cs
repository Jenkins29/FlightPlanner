using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightPlanner.Core.Models
{
    public class PageResult
    {
        public List<Flight> Items { get; set; } = new List<Flight>();
        public int Page { get; set; }
        public int TotalItems { get; set; }
    }
}
