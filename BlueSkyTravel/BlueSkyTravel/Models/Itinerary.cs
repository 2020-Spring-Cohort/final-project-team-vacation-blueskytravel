using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Models
{
    public class Itinerary
    {
        public int Id { get; set; }
        public DateTime TravelDateStart { get; set; }
        public DateTime TravelDateFinish { get; set; }
        public string Destination { get; set; }
        public double Budget { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<ForFun> ForFuns { get; set; }

        public Itinerary()
        {
                
        }

        public Itinerary(int id, DateTime travelDateStart, DateTime travelDateFinish, string destination, double budget)
        {
            Id = id;
            TravelDateStart = travelDateStart;
            TravelDateFinish = travelDateFinish;
            Destination = destination;
            Budget = budget;
        }
   
    }
}
