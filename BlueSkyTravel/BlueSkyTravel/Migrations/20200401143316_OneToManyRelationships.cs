using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class OneToManyRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForFunId",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItineraryId",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItineraryId",
                table: "ForFuns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItineraryId",
                table: "Flights",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate", "ItineraryId" },
                values: new object[] { new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EventTime", "ItineraryId" },
                values: new object[] { new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "ItineraryId" },
                values: new object[] { new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ForFunId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ForFunId",
                table: "Votes",
                column: "ForFunId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_ItineraryId",
                table: "Hotels",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForFuns_ItineraryId",
                table: "ForFuns",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ItineraryId",
                table: "Flights",
                column: "ItineraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Itinerary_ItineraryId",
                table: "Flights",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForFuns_Itinerary_ItineraryId",
                table: "ForFuns",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Itinerary_ItineraryId",
                table: "Hotels",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_ForFuns_ForFunId",
                table: "Votes",
                column: "ForFunId",
                principalTable: "ForFuns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Itinerary_ItineraryId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_ForFuns_Itinerary_ItineraryId",
                table: "ForFuns");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Itinerary_ItineraryId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_ForFuns_ForFunId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_ForFunId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_ItineraryId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_ForFuns_ItineraryId",
                table: "ForFuns");

            migrationBuilder.DropIndex(
                name: "IX_Flights_ItineraryId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ForFunId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "ItineraryId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ItineraryId",
                table: "ForFuns");

            migrationBuilder.DropColumn(
                name: "ItineraryId",
                table: "Flights");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
