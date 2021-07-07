using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieTicketBookingApp.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Date_And_Time", "Hall_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 50, new DateTime(2021, 7, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 72, new DateTime(2021, 7, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 71, new DateTime(2021, 7, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 70, new DateTime(2021, 7, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 69, new DateTime(2021, 7, 14, 20, 30, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 68, new DateTime(2021, 7, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 67, new DateTime(2021, 7, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 66, new DateTime(2021, 7, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 65, new DateTime(2021, 7, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 64, new DateTime(2021, 7, 14, 20, 30, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 63, new DateTime(2021, 7, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 73, new DateTime(2021, 7, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 62, new DateTime(2021, 7, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 60, new DateTime(2021, 7, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 59, new DateTime(2021, 7, 14, 20, 30, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 58, new DateTime(2021, 7, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 57, new DateTime(2021, 7, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 56, new DateTime(2021, 7, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 55, new DateTime(2021, 7, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 54, new DateTime(2021, 7, 14, 20, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 53, new DateTime(2021, 7, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 52, new DateTime(2021, 7, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 51, new DateTime(2021, 7, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 61, new DateTime(2021, 7, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 74, new DateTime(2021, 7, 14, 20, 30, 0, 0, DateTimeKind.Unspecified), 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 74);
        }
    }
}
