using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Models
{
    public class ForFun
    {
        public int Id { get; set; }
        public DateTime EventTime { get; set; }
        public double Fare { get; set; }
        public bool IsApproved { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public virtual Itinerary Itinerary { get; set; }
        public virtual int ItineraryId { get; set; }

        public ForFun()
        {

        }

        public ForFun(int id, DateTime eventTime, double fare, bool isApproved, string location, string name, int like, int dislike, int itineraryId)
        {
            Id = id;
            EventTime = eventTime;
            Fare = fare;
            IsApproved = false;
            Location = location;
            Name = name;
            Like = like;
            Dislike = dislike;
            ItineraryId = itineraryId;
            
        }


    }
}
