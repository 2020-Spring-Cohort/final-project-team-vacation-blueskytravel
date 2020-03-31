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

        public ForFun()
        {

        }

        public ForFun(int id, DateTime eventTime, double fare, bool isApproved, string location, string name)
        {
            Id = id;
            EventTime = eventTime;
            Fare = fare;
            IsApproved = false;
            Location = location;
            Name = name;
        }


    }
}
