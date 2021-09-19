using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightPlanner.Core.Models
{
    public class SearchFlightsRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public string DepartureDate { get; set; }
        public static bool SearchRequestValidation(SearchFlightsRequest req)
        {
            if (String.IsNullOrEmpty(req.From) || String.IsNullOrEmpty(req.To) ||
                String.IsNullOrEmpty(req.DepartureDate)) return false;

            if (req.From == req.To) return false;

            return true;
        }
    }
}
