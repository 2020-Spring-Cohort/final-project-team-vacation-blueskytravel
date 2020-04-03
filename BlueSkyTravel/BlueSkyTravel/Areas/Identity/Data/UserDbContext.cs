using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Areas.Identity.Data
{
    public class UserDbContext : IdentityDbContext<IdentityUser>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }
        public DbSet<Itinerary> Itinerary { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<ForFun> ForFuns { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Vote> Votes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Itinerary>().HasData(
                new Itinerary
                {
                    Id = 1,
                    TravelDateStart = DateTime.Today,
                    TravelDateFinish = DateTime.Today,
                    Destination = "London, UK",
                    Budget = 1500.00
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Holiday Inn",
                    Address = "221B Baker Street",
                    CheckIn = DateTime.Today,
                    CheckOut = DateTime.Today,
                    NightlyRate = 150.00,
                    ItineraryId = 1
                });

            modelBuilder.Entity<Flight>().HasData(
                new Flight
                {
                    Id = 1,
                    AirlineName = "WCCI AIR",
                    FlightNumber = "WCCI-2020",
                    ArrivalDate = DateTime.Today,
                    DepartureDate = DateTime.Today,
                    Fare = 426.00,
                    ItineraryId = 1
                });

            modelBuilder.Entity<ForFun>().HasData(
                new ForFun
                {
                    Id = 1,
                    EventTime = DateTime.Today,
                    Fare = 100.00,
                    IsApproved = false,
                    Location = "Paris, France",
                    Name = "Disneyland",
                    ItineraryId = 1
                });

            modelBuilder.Entity<Vote>().HasData(
              new Vote
              {
                  Id = 1,
                  VoteChoice = true,
                  ForFunId = 1
              });

            base.OnModelCreating(modelBuilder);
        }
    }
}
