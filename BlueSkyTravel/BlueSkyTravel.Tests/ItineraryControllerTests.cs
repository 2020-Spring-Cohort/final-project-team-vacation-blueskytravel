using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlueSkyTravel.Controllers;
using BlueSkyTravel.Repositories;
using BlueSkyTravel.Models;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;

namespace BlueSkyTravel.Tests
{
   public class ItineraryControllerTests
    {
        ItineraryController testController;
        IRepository<Itinerary> iMockRepo;

        public ItineraryControllerTests()
        {
            iMockRepo = Substitute.For<IRepository<Itinerary>>();
            testController = new ItineraryController(iMockRepo);
        }

        [Fact]
        public void Index_Returns_ViewResult()
        {
            var result = testController.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_ItineraryModels_To_View()
        {
            var expectedItinerary = new List<Itinerary>();
            iMockRepo.GetAll().Returns(expectedItinerary);

            var result = testController.Index();

            Assert.Equal(expectedItinerary, result.Model);
        }


        [Fact]
        public void Details_Returns_ViewResult()
        {
            var result = testController.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Model_To_View()
        {
            var expectedItinerary = new Itinerary();
            iMockRepo.GetById(1).Returns(expectedItinerary);

            var result = testController.Details(1);

            Assert.Equal(expectedItinerary, result.Model);
        }
    }
}
