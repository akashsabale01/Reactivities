using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("139726e5-8604-40b6-af16-4ae89b6d96ca"), "culture", "Paris", new DateTime(2024, 5, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(8893), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("1cffdd9b-a41e-4258-876b-1d89ade3d9b6"), "drinks", "London", new DateTime(2024, 4, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(8877), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("8ac06dbf-a11e-4b26-b456-9dd46f6e7dce"), "drinks", "London", new DateTime(2024, 9, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(8924), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("a431303e-cd01-45ae-858d-28933282a33b"), "travel", "London", new DateTime(2025, 1, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(9023), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("b5a00b3a-0127-4c04-b01d-42b2d28b2676"), "culture", "London", new DateTime(2024, 7, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(8898), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("b808bb9c-32c1-4b82-bf6f-3b653f4708f7"), "music", "London", new DateTime(2024, 8, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(8919), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("c6b053f1-d87a-4f50-a9d8-d3a7a94f5391"), "music", "London", new DateTime(2024, 12, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(9017), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("dca24dab-e37e-425a-9b25-4de54cf8999d"), "drinks", "London", new DateTime(2024, 11, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(8931), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("e99d2f53-7f03-417f-a2fb-ab11f4ee181b"), "film", "London", new DateTime(2025, 2, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(9028), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("f63db6ac-2ddf-456a-8114-582af4ddea1f"), "drinks", "London", new DateTime(2024, 10, 7, 17, 59, 36, 820, DateTimeKind.Utc).AddTicks(8927), "Activity 4 months in future", "Future Activity 4", "Yet another pub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("139726e5-8604-40b6-af16-4ae89b6d96ca"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1cffdd9b-a41e-4258-876b-1d89ade3d9b6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8ac06dbf-a11e-4b26-b456-9dd46f6e7dce"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a431303e-cd01-45ae-858d-28933282a33b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b5a00b3a-0127-4c04-b01d-42b2d28b2676"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b808bb9c-32c1-4b82-bf6f-3b653f4708f7"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c6b053f1-d87a-4f50-a9d8-d3a7a94f5391"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("dca24dab-e37e-425a-9b25-4de54cf8999d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e99d2f53-7f03-417f-a2fb-ab11f4ee181b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f63db6ac-2ddf-456a-8114-582af4ddea1f"));
        }
    }
}
