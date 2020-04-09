using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class removedvote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14f7f6c9-d19e-41ae-9d30-df931d60e9a3");

            migrationBuilder.AddColumn<int>(
                name: "Vote",
                table: "ForFuns",
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
                columns: new[] { "TravelDateFinish", "TravelDateStart", "TripName" },
                values: new object[] { new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "My Europe Trip" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cee4809d-21b0-4e67-a536-57f5b7777763");

            migrationBuilder.DropColumn(
                name: "Vote",
                table: "ForFuns");

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForFunId = table.Column<int>(type: "int", nullable: false),
                    VoteChoice = table.Column<bool>(type: "bit", nullable: false)
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "14f7f6c9-d19e-41ae-9d30-df931d60e9a3", 0, "Akron", "87460bb9-2c48-431c-b873-3e338d5a4aab", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "8406828e-ec5f-4cce-bee3-429632b82a70", "Ohio", false, null });

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
                columns: new[] { "TravelDateFinish", "TravelDateStart", "TripName" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "ForFunId", "VoteChoice" },
                values: new object[] { 1, 1, true });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ForFunId",
                table: "Votes",
                column: "ForFunId");
        }
    }
}
