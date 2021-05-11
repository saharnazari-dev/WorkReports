using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkReports.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartHour = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndHour = table.Column<TimeSpan>(type: "time", nullable: false),
                    DoneDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonWorks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PersonWorks",
                columns: new[] { "Id", "Description", "DoneDate", "EndHour", "Opration", "StartHour" },
                values: new object[] { 1, "اضاهه کردن بخش X, Y", new DateTime(2021, 5, 7, 18, 16, 39, 224, DateTimeKind.Local).AddTicks(2561), new TimeSpan(0, 3, 10, 0, 0), "تکمیل سیستم انبار", new TimeSpan(0, 2, 14, 18, 0) });

            migrationBuilder.UpdateData(
                table: "WorkReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastWorkedDate",
                value: new DateTime(2021, 5, 7, 18, 16, 39, 220, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "WorkReports",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastWorkedDate",
                value: new DateTime(2021, 5, 7, 18, 16, 39, 223, DateTimeKind.Local).AddTicks(9493));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonWorks");

            migrationBuilder.UpdateData(
                table: "WorkReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastWorkedDate",
                value: new DateTime(2021, 5, 7, 12, 26, 21, 920, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "WorkReports",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastWorkedDate",
                value: new DateTime(2021, 5, 7, 12, 26, 21, 924, DateTimeKind.Local).AddTicks(9709));
        }
    }
}
