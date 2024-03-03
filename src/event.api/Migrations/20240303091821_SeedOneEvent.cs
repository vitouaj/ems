using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedOneEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("974f045d-8312-40d0-b9cf-f3427b904909"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("d190a07b-7670-4ccc-80d3-daaf25bfb685"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25babb0e-0c88-4af7-99ad-5df9339cbf25"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2253), new Guid("12f1beb9-3509-4b66-bad4-b435750bac0a"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2253), new Guid("13c1f565-1307-462b-828b-f9ad2e7c6d01") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30ac51bd-6470-4801-9a9d-960b80af2ae6"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2247), new Guid("03fbf2b6-2db4-4e51-8a82-3f6374cd873f"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2246), new Guid("60d01932-b370-4932-a6cc-7d5953ffde90") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("322f5cca-291e-4bdc-9ae4-cd11317f2712"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2243), new Guid("3ca81d69-a15f-45cb-aa26-c6b33f29eb37"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2243), new Guid("53ebbbdc-2919-4977-a66e-47842345c5b6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a65b394-607d-4cf6-bdf7-01d1e28f4b6f"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2217), new Guid("d71c5034-4bee-453f-be8a-7eec7f2e6673"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2212), new Guid("b435dca4-8acb-4446-9183-524ccb1ca7fe") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ea0e2fc-6264-4116-81de-01b29b8c14cb"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2239), new Guid("0b1f3a11-5560-4e21-bdaa-85cca69a08cf"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2238), new Guid("56346e46-d216-4615-bde1-20536b98f6bf") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6edd33c-70f0-4dc3-82ac-9f4ce0d0eba4"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2224), new Guid("f72a7649-45aa-4dc2-a81a-e186762f68d4"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2223), new Guid("90831a7f-989d-4245-9677-97cf9480517c") });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2499), new Guid("87cc5850-aa70-4855-9a93-c4fd96fc375d"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2499), new Guid("b41e5d03-cc91-4f4a-af47-dec33f411be5") });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EndedDate", "Name", "NumberOfParticipant", "StartedDate", "UpdatedAt", "UpdatedBy", "VenueId" },
                values: new object[] { new Guid("60d59b4c-7672-403e-860c-e6acf8c80931"), new Guid("322f5cca-291e-4bdc-9ae4-cd11317f2712"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2508), new Guid("7ef92b7d-f631-4fab-b2d5-4f91b9263964"), "An annual tech summit aimed at bringing together tech enthusiasts, startups, and industry experts to discuss the latest trends and innovations in the Cambodian tech ecosystem.", new DateOnly(2024, 4, 21), "Cambodia Tech Summit 2024", 130, new DateOnly(2024, 4, 21), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2508), new Guid("e328166a-675a-4371-899e-2ffbf1a8efa6"), new Guid("d370967c-3da8-45f5-8890-bff9669c8a1d") });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Date", "Description", "EndedAt", "EventId", "Name", "StartedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("04068974-c881-4acf-9ee5-3589ae7d4ddb"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2582), new Guid("b7dbd5da-24c1-4e7b-8e85-2a41378b5bd4"), new DateOnly(2024, 3, 21), null, new TimeOnly(16, 0, 0), new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"), "Cambodia development | AWS annual report", new TimeOnly(14, 0, 0), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2582), new Guid("e0ab0859-0fba-4235-bd0b-0311fb2c5209") },
                    { new Guid("e568f18b-8c28-4b1d-8c82-a43aed688f04"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2575), new Guid("e463a179-2ab4-4cb9-b502-847959eb2371"), new DateOnly(2024, 3, 21), null, new TimeOnly(11, 0, 0), new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"), "Warm up session", new TimeOnly(9, 0, 0), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2575), new Guid("92de6777-7529-45a2-9fb9-6c93ff400f0e") }
                });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("d370967c-3da8-45f5-8890-bff9669c8a1d"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2462), new Guid("386cd6f2-6966-4fdd-bcda-43df976dd2ef"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2461), new Guid("83df4941-88a5-486b-8615-ebb6a3d492ba") });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Date", "Description", "EndedAt", "EventId", "Name", "StartedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a5f9e28-62a0-482a-8fa8-3bc302f0acd2"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2586), new Guid("eb827fd0-aa1d-4c7a-80c3-fabda8383f53"), new DateOnly(2024, 4, 21), "Panel discussion featuring successful Cambodian startup founders sharing their journey, challenges, and insights.", new TimeOnly(11, 0, 0), new Guid("60d59b4c-7672-403e-860c-e6acf8c80931"), "Tech Startup Panel", new TimeOnly(9, 0, 0), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2586), new Guid("f76617b6-b7e5-4ac8-913a-110d36fe1d56") },
                    { new Guid("6dbb2229-2cef-453c-b5c7-a3950a5c9e1f"), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2590), new Guid("3598aadd-e7b3-43db-a9a2-ba58e3eb1055"), new DateOnly(2024, 4, 21), "Hands-on workshop exploring AI and machine learning concepts and applications, tailored for beginners and enthusiasts.", new TimeOnly(16, 0, 0), new Guid("60d59b4c-7672-403e-860c-e6acf8c80931"), "AI and Machine Learning Workshop", new TimeOnly(14, 0, 0), new DateTime(2024, 3, 3, 9, 18, 20, 929, DateTimeKind.Utc).AddTicks(2590), new Guid("0b424dcf-794f-469f-97c5-71529f3b9dc9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("04068974-c881-4acf-9ee5-3589ae7d4ddb"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("2a5f9e28-62a0-482a-8fa8-3bc302f0acd2"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("6dbb2229-2cef-453c-b5c7-a3950a5c9e1f"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("e568f18b-8c28-4b1d-8c82-a43aed688f04"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("60d59b4c-7672-403e-860c-e6acf8c80931"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25babb0e-0c88-4af7-99ad-5df9339cbf25"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3482), new Guid("06c456f2-2c3f-458f-9627-63e0eb287a8e"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3482), new Guid("44abf5c1-a90f-4538-ac7e-c0a0b209b01e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30ac51bd-6470-4801-9a9d-960b80af2ae6"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3479), new Guid("50f98048-0b9f-49ce-bac6-1420a9359f5c"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3479), new Guid("1ddb2298-bcf3-493e-a034-8392bb055b6e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("322f5cca-291e-4bdc-9ae4-cd11317f2712"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3476), new Guid("9b294d7f-46ea-4ef3-a843-1f2d81cb93fb"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3476), new Guid("39074a3c-be6a-449a-bb8f-7abb7e439f16") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a65b394-607d-4cf6-bdf7-01d1e28f4b6f"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3462), new Guid("1ee39d4b-a8c7-4c62-8ea3-0250fefeeaf2"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3459), new Guid("848e4b15-e2e6-40e8-942e-be028e280e4f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ea0e2fc-6264-4116-81de-01b29b8c14cb"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3471), new Guid("b6951680-e946-4903-8dec-2883d858b4b9"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3471), new Guid("bb2d03af-9659-49eb-a373-96696e4269e8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6edd33c-70f0-4dc3-82ac-9f4ce0d0eba4"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3468), new Guid("5be35a05-5786-48d1-b55d-913316d27944"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3468), new Guid("ae2e2e5a-015f-40ae-b165-e3b3a71e8a8b") });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3699), new Guid("35b5faac-e668-47e4-920c-8a3fb75ce17c"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3699), new Guid("faa26d24-6e96-47b9-afd3-cceff8635393") });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Date", "Description", "EndedAt", "EventId", "Name", "StartedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("974f045d-8312-40d0-b9cf-f3427b904909"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3724), new Guid("795f7865-ab13-44c9-b6da-608abea01bc6"), new DateOnly(2024, 3, 21), null, new TimeOnly(11, 0, 0), new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"), "Warm up session", new TimeOnly(9, 0, 0), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3723), new Guid("d740a4cf-49ed-4216-a57e-dd3d29325b54") },
                    { new Guid("d190a07b-7670-4ccc-80d3-daaf25bfb685"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3727), new Guid("bf60d01f-47bf-47d2-9ecf-5dc65ed67431"), new DateOnly(2024, 3, 21), null, new TimeOnly(16, 0, 0), new Guid("bc66aaec-36f2-4207-9962-45a2dadd93a3"), "Cambodia development | AWS annual report", new TimeOnly(14, 0, 0), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3726), new Guid("ee77f054-8f4b-4162-b89a-0a56dfd4ecd9") }
                });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("d370967c-3da8-45f5-8890-bff9669c8a1d"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3671), new Guid("ab10274d-745f-4dcf-89ca-040717e7adb3"), new DateTime(2024, 3, 3, 9, 12, 13, 722, DateTimeKind.Utc).AddTicks(3670), new Guid("3cfce0eb-f916-4342-a9c2-7e5e087561a1") });
        }
    }
}
