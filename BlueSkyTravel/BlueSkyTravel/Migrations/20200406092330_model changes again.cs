using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class modelchangesagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c85d72f-0052-49ae-8eb8-1b45d2efad86");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ec17b84b-2e3b-4be5-bd49-6e9e42438c62", 0, "Akron", "3a8441f3-ffbd-4758-81a4-8fe12ae2b97b", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "6927033e-d880-473e-9012-dd8090d40883", "Ohio", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec17b84b-2e3b-4be5-bd49-6e9e42438c62");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0c85d72f-0052-49ae-8eb8-1b45d2efad86", 0, "Akron", "fd6946d9-611d-4ce0-8428-b2b6cd359294", null, false, "Tom", "Shaw", false, null, null, null, null, null, false, "26f2471d-f287-4d7c-98f8-c541fc291e87", "Ohio", false, null });
        }
    }
}
