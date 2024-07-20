using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Departments.Migrations
{
    /// <inheritdoc />
    public partial class SeedRemindersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "ReminderTime", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 20, 16, 49, 54, 453, DateTimeKind.Local).AddTicks(3419), "Reminder 01" },
                    { 2, new DateTime(2024, 7, 20, 16, 49, 54, 453, DateTimeKind.Local).AddTicks(3476), "Reminder 02" },
                    { 3, new DateTime(2024, 7, 20, 16, 50, 54, 453, DateTimeKind.Local).AddTicks(3478), "Reminder 03" },
                    { 4, new DateTime(2024, 7, 20, 16, 50, 54, 453, DateTimeKind.Local).AddTicks(3480), "Reminder 04" },
                    { 5, new DateTime(2024, 7, 20, 16, 51, 54, 453, DateTimeKind.Local).AddTicks(3482), "Reminder 05" },
                    { 6, new DateTime(2024, 7, 20, 16, 51, 54, 453, DateTimeKind.Local).AddTicks(3484), "Reminder 06" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
