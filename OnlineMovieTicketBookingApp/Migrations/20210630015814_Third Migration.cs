using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieTicketBookingApp.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "Date_Of_Birth", "Email", "First_Name", "Gender", "Last_Name", "Password", "Phone", "Username" },
                values: new object[] { 1, "123 Bishan Street 13 Singapore 570123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1970), "janedoe@email.com", "Jane", "Female", "Doe", "password123", "91234567", "janedoe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
