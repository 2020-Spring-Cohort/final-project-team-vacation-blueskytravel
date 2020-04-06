using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class updateditinmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f643e0b-9242-448e-b7e5-0356be37a679");

            migrationBuilder.AddColumn<string>(
                name: "TripName",
                table: "Itinerary",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0c85d72f-0052-49ae-8eb8-1b45d2efad86", 0, "Akron", "fd6946d9-611d-4ce0-8428-b2b6cd359294", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "26f2471d-f287-4d7c-98f8-c541fc291e87", "Ohio", false, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c85d72f-0052-49ae-8eb8-1b45d2efad86");

            migrationBuilder.DropColumn(
                name: "TripName",
                table: "Itinerary");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2f643e0b-9242-448e-b7e5-0356be37a679", 0, "Akron", "4b8b92a4-c688-4834-a25e-c8a8b1a77b97", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "c9683808-b93c-454f-bf9f-3feececd5736", "Ohio", false, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
