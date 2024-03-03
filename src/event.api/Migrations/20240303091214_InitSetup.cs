using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    District = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    BuildingNo = table.Column<string>(type: "text", nullable: false),
                    GoogleMapUrl = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NumberOfParticipant = table.Column<int>(type: "integer", nullable: false),
                    StartedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    VenueId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartedAt = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    EndedAt = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("25babb0e-0c88-4af7-99ad-5df9339cbf25"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3482), new Guid("06c456f2-2c3f-458f-9627-63e0eb287a8e"), null, "NGO", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3482), new Guid("44abf5c1-a90f-4538-ac7e-c0a0b209b01e") },
                    { new Guid("30ac51bd-6470-4801-9a9d-960b80af2ae6"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3479), new Guid("50f98048-0b9f-49ce-bac6-1420a9359f5c"), null, "Health Care", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3479), new Guid("1ddb2298-bcf3-493e-a034-8392bb055b6e") },
                    { new Guid("322f5cca-291e-4bdc-9ae4-cd11317f2712"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3476), new Guid("9b294d7f-46ea-4ef3-a843-1f2d81cb93fb"), null, "Technology", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3476), new Guid("39074a3c-be6a-449a-bb8f-7abb7e439f16") },
                    { new Guid("3a65b394-607d-4cf6-bdf7-01d1e28f4b6f"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3462), new Guid("1ee39d4b-a8c7-4c62-8ea3-0250fefeeaf2"), null, "Education", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3459), new Guid("848e4b15-e2e6-40e8-942e-be028e280e4f") },
                    { new Guid("4ea0e2fc-6264-4116-81de-01b29b8c14cb"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3471), new Guid("b6951680-e946-4903-8dec-2883d858b4b9"), null, "Entrepreneurship", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3471), new Guid("bb2d03af-9659-49eb-a373-96696e4269e8") },
                    { new Guid("f6edd33c-70f0-4dc3-82ac-9f4ce0d0eba4"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3468), new Guid("5be35a05-5786-48d1-b55d-913316d27944"), null, "Community", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3468), new Guid("ae2e2e5a-015f-40ae-b165-e3b3a71e8a8b") }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "BuildingNo", "City", "CreatedAt", "CreatedBy", "Description", "District", "GoogleMapUrl", "Name", "Street", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("d370967c-3da8-45f5-8890-bff9669c8a1d"), "OCIC HALL F", "phnom penh", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3671), new Guid("ab10274d-745f-4dcf-89ca-040717e7adb3"), null, "chroy chongva", "https://maps.app.goo.gl/Z7g5m2JLUGncbZtJ8", "OCIC wedding hall", "ocic 591 street", new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3670), new Guid("3cfce0eb-f916-4342-a9c2-7e5e087561a1") });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EndedDate", "Name", "NumberOfParticipant", "StartedDate", "UpdatedAt", "UpdatedBy", "VenueId" },
                values: new object[] { new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"), new Guid("322f5cca-291e-4bdc-9ae4-cd11317f2712"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3699), new Guid("35b5faac-e668-47e4-920c-8a3fb75ce17c"), "a public event to gather aws users in cambodia to connect and share experience working in the industry. many session are hosted by professional which available for free. any one can join.", new DateOnly(2024, 3, 21), "AWS 2024 Cambodia Conference", 50, new DateOnly(2024, 3, 21), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3699), new Guid("faa26d24-6e96-47b9-afd3-cceff8635393"), new Guid("d370967c-3da8-45f5-8890-bff9669c8a1d") });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Date", "Description", "EndedAt", "EventId", "Name", "StartedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("974f045d-8312-40d0-b9cf-f3427b904909"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3724), new Guid("795f7865-ab13-44c9-b6da-608abea01bc6"), new DateOnly(2024, 3, 21), null, new TimeOnly(11, 0, 0), new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"), "Warm up session", new TimeOnly(9, 0, 0), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3723), new Guid("d740a4cf-49ed-4216-a57e-dd3d29325b54") },
                    { new Guid("d190a07b-7670-4ccc-80d3-daaf25bfb685"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3727), new Guid("bf60d01f-47bf-47d2-9ecf-5dc65ed67431"), new DateOnly(2024, 3, 21), null, new TimeOnly(16, 0, 0), new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"), "Cambodia development | AWS annual report", new TimeOnly(14, 0, 0), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3726), new Guid("ee77f054-8f4b-4162-b89a-0a56dfd4ecd9") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_VenueId",
                table: "Events",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_EventId",
                table: "Sessions",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Venues");
        }
    }
}
