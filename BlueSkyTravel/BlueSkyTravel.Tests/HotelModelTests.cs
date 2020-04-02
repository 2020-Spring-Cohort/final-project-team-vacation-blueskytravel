using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Tests
{
    public class HotelModelTests
    {
        Hotel myHotel = new Hotel();

        public HotelModelTests()
        {
            myHotel = new Hotel(1, "Holiday Inn", "42069 High Street", DateTime.Today, DateTime.Today, 200.00, 1);
        }

        [Fact]
        public void HotelConstructor_Sets_Id_On_Model()
        {
            var result = myHotel.Id;

            Assert.Equal(1, result);
        }
        [Fact]
        public void HotelConstructor_Sets_Address_On_Model()
        {
            var result = myHotel.Address;

            Assert.Equal("42069 High Street", result);
        }

        [Fact]
        public void HotelConstructor_Sets_NightlyRate_On_Model()
        {
            var result = myHotel.NightlyRate;

            Assert.Equal(200.00, result);
        }
    }
}
