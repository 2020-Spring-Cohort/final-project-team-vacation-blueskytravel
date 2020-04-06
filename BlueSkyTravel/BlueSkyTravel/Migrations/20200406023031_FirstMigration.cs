using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSkyTravel.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "City", "FirstName", "LastName", "State" },
                values: new object[] { "6fb6be56-d2f8-4e96-b1c8-bbacad0ede53", 0, "4a8c8777-4f09-45c7-b5b4-adbc0df0eda8", "ApplicationUser", null, false, false, null, null, null, null, null, false, "922c7935-fcb8-4174-b3b1-c8fa84a03396", false, null, "Akron", "Tom", "Shaw", "Ohio" });

            migrationBuilder.InsertData(
                table: "Itinerary",
                columns: new[] { "Id", "Budget", "Destination", "TravelDateFinish", "TravelDateStart" },
                values: new object[] { 1, 1500.0, "London, UK", new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirlineName", "ArrivalDate", "DepartureDate", "Fare", "FlightNumber", "ItineraryId" },
                values: new object[] { 1, "WCCI AIR", new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 426.0, "WCCI-2020", 1 });

            migrationBuilder.InsertData(
                table: "ForFuns",
                columns: new[] { "Id", "EventTime", "Fare", "IsApproved", "ItineraryId", "Location", "Name" },
                values: new object[] { 1, new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 100.0, false, 1, "Paris, France", "Disneyland" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckIn", "CheckOut", "ItineraryId", "Name", "NightlyRate" },
                values: new object[] { 1, "221B Baker Street", new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, "Holiday Inn", 150.0 });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "ForFunId", "VoteChoice" },
                values: new object[] { 1, 1, true });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ForFuns");

            migrationBuilder.DropTable(
                name: "Itinerary");
        }
    }
}
