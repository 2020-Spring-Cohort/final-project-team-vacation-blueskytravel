using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Tests
{
    public class FlightModelTests
    {
        Flight myFlight = new Flight();

        public FlightModelTests()
        {
            myFlight = new Flight(1, "WCCI Air", "A122", DateTime.Today, DateTime.Today, 500.00, 1);
        }

        [Fact]
        public void FlightConstructor_Sets_Id_On_Model()
        {
            var result = myFlight.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void FlightConstructor_Sets_FlightNumber_On_Model()
        {
            var result = myFlight.FlightNumber;

            Assert.Equal("A122", result);
        }

        [Fact]
        public void FlightConstructor_Sets_Airline_Name()
        {
            var result = myFlight.AirlineName;

            Assert.Equal("WCCI Air", result);
        }

        [Fact]
        public void FlightConstructor_Sets_Fare_On_Model()
        {
            var result = myFlight.Fare;

            Assert.Equal(500.00, result);
        }
    }
}
