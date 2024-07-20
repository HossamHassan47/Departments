using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.SqlServer.Types;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Departments.Migrations
{
    /// <inheritdoc />
    public partial class SeedDepartmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Logo", "Name", "Path" },
                values: new object[,]
                {
                    { 1, null, "Root Department", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/") },
                    { 2, null, "Department 01", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/") },
                    { 3, null, "Department 02", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/2/") },
                    { 4, null, "Department 03", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/") },
                    { 5, null, "Department 04", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/4/") },
                    { 6, null, "Department 05", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/5/") },
                    { 7, null, "Department 06", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/1/") },
                    { 8, null, "Department 07", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/2/") },
                    { 9, null, "Department 08", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/3/") },
                    { 10, null, "Department 09", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/4/") },
                    { 11, null, "Department 10", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/5/") },
                    { 12, null, "Department 11", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/1/") },
                    { 13, null, "Department 12", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/2/") },
                    { 14, null, "Department 13", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/4/1/") },
                    { 15, null, "Department 14", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/1/1/") },
                    { 16, null, "Department 15", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/3/1/") },
                    { 17, null, "Department 16", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/5/1/") },
                    { 18, null, "Department 17", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/2/1/") },
                    { 19, null, "Department 18", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/2/2/") },
                    { 20, null, "Department 19", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/4/1/1/") },
                    { 21, null, "Department 20", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/4/1/2/") },
                    { 22, null, "Department 21", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/4/1/3/") },
                    { 23, null, "Department 22", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/3/1/1/") },
                    { 24, null, "Department 23", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/5/1/1/") },
                    { 25, null, "Department 24", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/2/1/1/") },
                    { 26, null, "Department 25", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/2/1/2/") },
                    { 27, null, "Department 26", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/2/1/3/") },
                    { 28, null, "Department 27", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/4/1/2/1/") },
                    { 29, null, "Department 28", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/4/1/3/1/") },
                    { 30, null, "Department 29", Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/3/2/1/1/1/") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
