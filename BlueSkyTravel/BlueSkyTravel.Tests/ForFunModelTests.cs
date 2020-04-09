using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Tests
{
    public class ForFunModelTests
    {
        ForFun myForFun = new ForFun();

        public ForFunModelTests()
        {
            myForFun = new ForFun(1, DateTime.Today, 45.00, false, "Orlando", "Didny Worl", 0, 1);
        }

        [Fact]
        public void ForFunConstructor_Sets_Id_On_Model()
        {
            var result = myForFun.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void ForFunConstructor_Sets_Fare_On_Model()
        {
            var result = myForFun.Fare;

            Assert.Equal(45.00, result);
        }


        [Fact]
        public void ForFunConstructor_Sets_Location_On_Model()
        {
            var result = myForFun.Location;

            Assert.Equal("Orlando", result);
        }

        [Fact]
        public void ForFunConstructor_Sets_Name_On_Model()
        {
            var result = myForFun.Name;

            Assert.Equal("Didny Worl", result);
        }

        [Fact]
        public void ForFunConstructor_Sets_IsApproved__To_false()
        {
            var result = myForFun.IsApproved;

            Assert.False(result);
        }
    }


}
