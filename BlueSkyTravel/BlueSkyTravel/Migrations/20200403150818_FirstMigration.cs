using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations.UserDb
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(nullable: true),
                    FlightNumber = table.Column<string>(nullable: true),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    Fare = table.Column<double>(nullable: false),
                    ItineraryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Name = table.Column<string>(nullable: true),
                    ItineraryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForFuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForFuns_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false),
                    NightlyRate = table.Column<double>(nullable: false),
                    ItineraryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoteChoice = table.Column<bool>(nullable: false),
                    ForFunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_ForFuns_ForFunId",
                        column: x => x.ForFunId,
                        principalTable: "ForFuns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Itinerary",
                columns: new[] { "Id", "Budget", "Destination", "TravelDateFinish", "TravelDateStart" },
                values: new object[] { 1, 1500.0, "London, UK", new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirlineName", "ArrivalDate", "DepartureDate", "Fare", "FlightNumber", "ItineraryId" },
                values: new object[] { 1, "WCCI AIR", new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 426.0, "WCCI-2020", 1 });

            migrationBuilder.InsertData(
                table: "ForFuns",
                columns: new[] { "Id", "EventTime", "Fare", "IsApproved", "ItineraryId", "Location", "Name" },
                values: new object[] { 1, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 100.0, false, 1, "Paris, France", "Disneyland" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckIn", "CheckOut", "ItineraryId", "Name", "NightlyRate" },
                values: new object[] { 1, "221B Baker Street", new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, "Holiday Inn", 150.0 });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "ForFunId", "VoteChoice" },
                values: new object[] { 1, 1, true });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ItineraryId",
                table: "Flights",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForFuns_ItineraryId",
                table: "ForFuns",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_ItineraryId",
                table: "Hotels",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ForFunId",
                table: "Votes",
                column: "ForFunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "ForFuns");

            migrationBuilder.DropTable(
                name: "Itinerary");
        }
    }
}
