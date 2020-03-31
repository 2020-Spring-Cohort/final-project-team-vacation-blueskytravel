using System;
using Xunit;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Tests
{
    public class ItineraryModelTests
    {

        Itinerary myItin = new Itinerary();

        public ItineraryModelTests()
        {
            myItin = new Itinerary(1, DateTime.Today, DateTime.Today, "Hawaii", 1000.00);
        }

        [Fact]
        public void ItineraryConstructor_Sets_Id_On_Model()
        {
            var result = myItin.Id;

            Assert.Equal(1, result);
        }


        [Fact]
        public void ItineraryConstructor_Sets_Destination_On_Model()
        {
            var result = myItin.Destination;

            Assert.Equal("Hawaii", result);
        }

        [Fact]
        public void ItineraryConstructor_Sets_Budget_On_Model()
        {
            var result = myItin.Budget;

            Assert.Equal(1000.00, result);
        }
    }
}
