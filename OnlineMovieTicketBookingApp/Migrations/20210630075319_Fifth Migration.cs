using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieTicketBookingApp.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seat_Id",
                table: "Halls");

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Total_Seats" },
                values: new object[,]
                {
                    { 1, 40 },
                    { 2, 40 },
                    { 3, 40 },
                    { 4, 40 },
                    { 5, 40 }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Date_And_Time", "Hall_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2021, 6, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, new DateTime(2021, 6, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 4, new DateTime(2021, 6, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 5, new DateTime(2021, 6, 30, 20, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 6, new DateTime(2021, 6, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 7, new DateTime(2021, 6, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 8, new DateTime(2021, 6, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 9, new DateTime(2021, 6, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 10, new DateTime(2021, 6, 30, 20, 30, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 11, new DateTime(2021, 6, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "Seat_Id",
                table: "Halls",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
