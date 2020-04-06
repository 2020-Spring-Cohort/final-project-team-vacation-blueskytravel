using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Models
{
    public class Itinerary
    {
        public string TripName { get; set; }
        public int Id { get; set; }
        public DateTime TravelDateStart { get; set; }
        public DateTime TravelDateFinish { get; set; }
        public string Destination { get; set; }
        public double Budget { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<ForFun> ForFuns { get; set; }

        public Itinerary()
        {
                
        }

        public Itinerary(string tripName, int id, DateTime travelDateStart, DateTime travelDateFinish, string destination, double budget)
        {
            TripName = tripName;
            Id = id;
            TravelDateStart = travelDateStart;
            TravelDateFinish = travelDateFinish;
            Destination = destination;
            Budget = budget;
        }
   
    }
}
