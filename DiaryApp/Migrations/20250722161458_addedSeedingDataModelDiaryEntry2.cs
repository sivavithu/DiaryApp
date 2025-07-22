using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class addedSeedingDataModelDiaryEntry2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Creation",
                value: new DateTime(2025, 7, 22, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Creation",
                value: new DateTime(2025, 7, 22, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Creation",
                value: new DateTime(2025, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Creation",
                value: new DateTime(2025, 7, 22, 21, 40, 25, 569, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Creation",
                value: new DateTime(2025, 7, 22, 21, 40, 25, 569, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Creation",
                value: new DateTime(2025, 7, 22, 21, 40, 25, 569, DateTimeKind.Local).AddTicks(6031));
        }
    }
}
