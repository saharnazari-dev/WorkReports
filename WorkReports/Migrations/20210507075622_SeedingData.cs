using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkReports.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalWorkHour",
                table: "WorkReports",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "MonthlyWorkHour",
                table: "WorkReports",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "DailyWorkHour",
                table: "WorkReports",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Family", "Name", "Password" },
                values: new object[] { 1, "SaharNazari@gmail.com", "Nazari", "Sahar", "6871814" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Family", "Name", "Password" },
                values: new object[] { 2, "Alighasemzad@gmail.com", "Ghasemzad", "Ali", "123456" });

            migrationBuilder.InsertData(
                table: "WorkReports",
                columns: new[] { "Id", "DailyWorkHour", "Description", "IsAccepted", "LastWorkedDate", "MonthlyWorkHour", "TotalWorkHour", "UserId" },
                values: new object[] { 1, 8.0, "User panel", 1, new DateTime(2021, 5, 7, 12, 26, 21, 920, DateTimeKind.Local).AddTicks(2801), 180.0, 500.0, 1 });

            migrationBuilder.InsertData(
                table: "WorkReports",
                columns: new[] { "Id", "DailyWorkHour", "Description", "IsAccepted", "LastWorkedDate", "MonthlyWorkHour", "TotalWorkHour", "UserId" },
                values: new object[] { 2, 7.0, "طراحی سیستم انبار", 0, new DateTime(2021, 5, 7, 12, 26, 21, 924, DateTimeKind.Local).AddTicks(9709), 180.53, 1000.2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkReports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkReports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<float>(
                name: "TotalWorkHour",
                table: "WorkReports",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "MonthlyWorkHour",
                table: "WorkReports",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "DailyWorkHour",
                table: "WorkReports",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
