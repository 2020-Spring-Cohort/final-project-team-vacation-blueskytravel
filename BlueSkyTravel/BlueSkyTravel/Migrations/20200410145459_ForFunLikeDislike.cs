using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class ForFunLikeDislike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cee4809d-21b0-4e67-a536-57f5b7777763");

            migrationBuilder.DropColumn(
                name: "Vote",
                table: "ForFuns");

            migrationBuilder.AddColumn<int>(
                name: "Dislike",
                table: "ForFuns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "ForFuns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "59c780c7-fc53-4e51-989d-9186802436e6", 0, "Akron", "62089812-258c-4ba3-b659-7b5436fafe18", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "99ba5d79-0728-4178-8081-eab7ff716041", "Ohio", false, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c780c7-fc53-4e51-989d-9186802436e6");

            migrationBuilder.DropColumn(
                name: "Dislike",
                table: "ForFuns");

            migrationBuilder.DropColumn(
                name: "Like",
                table: "ForFuns");

            migrationBuilder.AddColumn<int>(
                name: "Vote",
                table: "ForFuns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cee4809d-21b0-4e67-a536-57f5b7777763", 0, "Akron", "1f7f4c46-aa0b-4f8a-b4bd-f6e8e5b10116", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "f9cc62f0-ed9a-420f-b1b8-7bb1754a47fc", "Ohio", false, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "DepartureDate" },
                values: new object[] { new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ForFuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventTime",
                value: new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TravelDateFinish", "TravelDateStart" },
                values: new object[] { new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
