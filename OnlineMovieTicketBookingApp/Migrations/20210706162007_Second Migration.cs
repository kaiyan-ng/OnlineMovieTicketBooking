using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieTicketBookingApp.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Date_And_Time", "Hall_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 42, new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 41, new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 40, new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 39, new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 38, new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 37, new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 36, new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 35, new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 34, new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 33, new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 43, new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 32, new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 30, new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 29, new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 28, new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 27, new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 26, new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 25, new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 24, new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 23, new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 22, new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 21, new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 31, new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 44, new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), 4, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 44);
        }
    }
}
