using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double NightlyRate { get; set; }


        public Hotel()
        {

        }

        public Hotel(int id, string address, DateTime checkIn, DateTime checkOut, double nightlyRate)
        {
            Id = id;
            Address = address;
            CheckIn = checkIn;
            CheckOut = checkOut;
            NightlyRate = nightlyRate;
        }
    }
}
