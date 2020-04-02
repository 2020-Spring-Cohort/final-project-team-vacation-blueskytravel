using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class AddedNameforHotelName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "Name" },
                values: new object[] { new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Holiday Inn" });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hotels");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
