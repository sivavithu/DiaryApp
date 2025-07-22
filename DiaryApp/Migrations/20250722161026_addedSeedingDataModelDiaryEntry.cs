using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class addedSeedingDataModelDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Creation", "Title" },
                values: new object[,]
                {
                    { 1, "This is the content of the first diary entry.", new DateTime(2025, 7, 22, 21, 40, 25, 569, DateTimeKind.Local).AddTicks(5820), "First Entry" },
                    { 2, "This is the content of the second diary entry.", new DateTime(2025, 7, 22, 21, 40, 25, 569, DateTimeKind.Local).AddTicks(6030), "Second Entry" },
                    { 3, "This is the content of the third diary entry.", new DateTime(2025, 7, 22, 21, 40, 25, 569, DateTimeKind.Local).AddTicks(6031), "Third Entry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
