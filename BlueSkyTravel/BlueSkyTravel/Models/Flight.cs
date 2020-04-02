using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string AirlineName { get; set; }
        public string FlightNumber { get; set; }
        public DateTime ArrivalDate{ get; set; }
        public DateTime DepartureDate { get; set; }
        public double Fare { get; set; }
        public virtual Itinerary Itinerary { get; set; }
        public virtual int ItineraryId { get; set; }


        public Flight()
        {

        }

        public Flight(int id, string airlineName, string flightNumber, DateTime arrivalDate, DateTime departureDate, double fare, int itineraryId)
        {
            Id = id;
            AirlineName = airlineName;
            FlightNumber = flightNumber;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            Fare = fare;
            ItineraryId = itineraryId;
        }


     }
}
