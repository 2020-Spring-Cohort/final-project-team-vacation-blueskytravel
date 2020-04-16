using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BlueSkyTravel.Areas.IdentityModel;

namespace BlueSkyTravel
{
    public class BlueSkyContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Itinerary> Itinerary { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<ForFun> ForFuns { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public BlueSkyContext(DbContextOptions<BlueSkyContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=BlueSkyTravel;Trusted_Connection=True;";

            var connectionString = "Server=tcp:blueskytravel20200415162537dbserver.database.windows.net,1433;Initial Catalog=BlueSkyTravel20200415162537_db;Persist Security Info=False;User ID=blueskyadmin;Password=BlueSky11!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Itinerary>().HasData(
                new Itinerary
                {
                    TripName = "My Europe Trip",
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
                    Like = 0,
                    Dislike = 0,
                    ItineraryId = 1
                });


            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    FirstName = "Tom",
                    LastName = "Shaw",
                    City = "Akron",
                    State = "Ohio"
                });
                
                

            base.OnModelCreating(modelBuilder);
        }

    }
}
