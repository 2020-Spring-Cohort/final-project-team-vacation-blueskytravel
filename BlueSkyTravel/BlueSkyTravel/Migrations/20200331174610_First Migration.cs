using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(nullable: true),
                    FlightNumber = table.Column<string>(nullable: true),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    Fare = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForFuns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTime = table.Column<DateTime>(nullable: false),
                    Fare = table.Column<double>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForFuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false),
                    NightlyRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itinerary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelDateStart = table.Column<DateTime>(nullable: false),
                    TravelDateFinish = table.Column<DateTime>(nullable: false),
                    Destination = table.Column<string>(nullable: true),
                    Budget = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoteChoice = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirlineName", "ArrivalDate", "DepartureDate", "Fare", "FlightNumber" },
                values: new object[] { 1, "WCCI AIR", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 426.0, "WCCI-2020" });

            migrationBuilder.InsertData(
                table: "ForFuns",
                columns: new[] { "Id", "EventTime", "Fare", "IsApproved", "Location", "Name" },
                values: new object[] { 1, new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 100.0, false, "Paris, France", "Disneyland" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckIn", "CheckOut", "NightlyRate" },
                values: new object[] { 1, "221B Baker Street", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 150.0 });

            migrationBuilder.InsertData(
                table: "Itinerary",
                columns: new[] { "Id", "Budget", "Destination", "TravelDateFinish", "TravelDateStart" },
                values: new object[] { 1, 1500.0, "London, UK", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "VoteChoice" },
                values: new object[] { 1, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "ForFuns");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Itinerary");

            migrationBuilder.DropTable(
                name: "Votes");
        }
    }
}
