using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoiningDate",
                value: new DateTime(2022, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoiningDate",
                value: new DateTime(2023, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "FullName", "JoiningDate" },
                values: new object[,]
                {
                    { 3, "Finance", "ala kammoun", new DateTime(2024, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6122) },
                    { 4, "Marketing", "yasmine abed", new DateTime(2021, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6124) }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "CreatedAt", "EmployeeId", "EndDate", "LeaveType", "Reason", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6312), 1, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vacation", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6315), 1, new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Flu", new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6316), 2, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Conference", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6318), 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Family trip", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6320), 3, new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Flu symptoms", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6321), 4, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Workshop", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6323), 3, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Holiday", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6325), 4, new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Flu", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoiningDate",
                value: new DateTime(2022, 4, 16, 0, 22, 42, 587, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoiningDate",
                value: new DateTime(2023, 4, 16, 0, 22, 42, 587, DateTimeKind.Local).AddTicks(6953));
        }
    }
}
