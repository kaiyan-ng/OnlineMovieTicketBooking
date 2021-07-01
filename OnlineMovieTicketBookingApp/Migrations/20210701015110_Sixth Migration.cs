using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieTicketBookingApp.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Shows_ShowId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ShowId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "Bookings");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Show_Id",
                table: "Bookings",
                column: "Show_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Shows_Show_Id",
                table: "Bookings",
                column: "Show_Id",
                principalTable: "Shows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Shows_Show_Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Show_Id",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "ShowId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ShowId",
                table: "Bookings",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Shows_ShowId",
                table: "Bookings",
                column: "ShowId",
                principalTable: "Shows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
