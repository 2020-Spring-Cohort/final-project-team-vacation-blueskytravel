using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class passwordresettest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6755aa39-692c-4fa0-b3cb-3b44703c7144");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "824c2bb8-3dda-42b8-96b3-3e380357935e", 0, "Akron", "0a439e53-161c-4ec3-bc5f-8f1d8fd03bfe", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "7dce0ad6-3eab-44a5-88e9-722223a1f6b2", "Ohio", false, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "824c2bb8-3dda-42b8-96b3-3e380357935e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6755aa39-692c-4fa0-b3cb-3b44703c7144", 0, "Akron", "db1e9a34-6023-4748-a0b6-7633631c27a9", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "39b1cd66-741f-47fe-97a0-0b44486f5a08", "Ohio", false, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
