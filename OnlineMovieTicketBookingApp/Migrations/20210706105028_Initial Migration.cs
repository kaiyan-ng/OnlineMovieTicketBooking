using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieTicketBookingApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total_Seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age_Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Run_Time = table.Column<int>(type: "int", nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distributor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ticket_Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_And_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Movie_Id = table.Column<int>(type: "int", nullable: false),
                    Hall_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shows_Halls_Hall_Id",
                        column: x => x.Hall_Id,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shows_Movies_Movie_Id",
                        column: x => x.Movie_Id,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Id = table.Column<int>(type: "int", nullable: false),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    Show_Id = table.Column<int>(type: "int", nullable: false),
                    Total_Tickets = table.Column<int>(type: "int", nullable: false),
                    Total_Price = table.Column<float>(type: "real", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Movies_Movie_Id",
                        column: x => x.Movie_Id,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Shows_Show_Id",
                        column: x => x.Show_Id,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    ticket_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    ticket_price = table.Column<double>(type: "float", nullable: false),
                    hall_number = table.Column<int>(type: "int", nullable: false),
                    seat_number = table.Column<int>(type: "int", nullable: false),
                    show_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    show_id = table.Column<int>(type: "int", nullable: false),
                    seat_id = table.Column<int>(type: "int", nullable: false),
                    hall_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.ticket_id);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Shows_show_id",
                        column: x => x.show_id,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "Date_Of_Birth", "Email", "First_Name", "Gender", "Last_Name", "Password", "Phone", "Username" },
                values: new object[] { 1, "123 Bishan Street 13 Singapore 570123", new DateTime(1990, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "janedoe@email.com", "Jane", "Female", "Doe", "password123", "91234567", "janedoe" });

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
                table: "Movies",
                columns: new[] { "Id", "Age_Rating", "BgImage", "Cast", "Director", "Distributor", "Genre", "Language", "Poster", "Release_Date", "Run_Time", "Status", "Synopsis", "Ticket_Price", "Title", "Trailer" },
                values: new object[,]
                {
                    { 1, "PG", "/MovieBackgrounds/Cruella.jpg", "Emma Stone, Emma Thompson , Joel Fry, Paul Walter Hauser, Emily Beecham, Mark Strong, Kirby Howell-Baptiste", "Craig Gillespie", "Walt Disney Pictures", "Comedy", "English", "/MoviePosters/CruellaPoster.jpg", new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, "Now Showing", "A live action prequel feature film that tells the story of a young Cruella de Vil, the villain from 101 Dalmations. Cruella, which is set in 1970s London amidst the punk rock revolution, follows a young grifter named Estella (Emma Stone), a clever and creative girl determined to make a name for herself with her designs. She befriends a pair of young thieves who appreciate her appetite for mischief, and together they are able to build a life for themselves on the London streets. With their help and her creativity and wit, Estella catches the eye of fashion legend Baroness von Hellman (Emma Thompson) through her fiery flair. But their relationship sets in motion a course of events and revelations that will cause Estella to embrace her wicked side and become the raucous, fashionable and revenge-bent Cruella.", 9f, "Disney's Cruella", "/MovieTrailers/DisneysCruella.mp4" },
                    { 2, "NC16 - Horror", "/MovieBackgrounds/TheConjuring3.jpg", "Patrick Wilson, Vera Farmiga, Ruairi O'Connor, Sarah Catherine Hook, Julian Hilliard", "Michael Chaves", "Warner Bros.", "Horror", "English", "/MoviePosters/ConjuringPoster.jpg", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 112, "Now Showing", "The Conjuring: The Devil Made Me Do It reveals a chilling story of terror, murder and unknown evil that shocked even experienced real-life paranormal investigators Ed and Lorraine Warren. One of the most sensational cases from their files, it starts with a fight for the soul of a young boy, then takes them beyond anything they’d ever seen before, to mark the first time in U.S. history that a murder suspect would claim demonic possession as a defense.", 9f, "The Conjuring: The Devil Made Me Do It", "/MovieTrailers/TheConjuring3.mp4" },
                    { 3, "M18 - Coarse Language & Violence", "/MovieBackgrounds/HitmanWifeBodyguard.jpg", "Ryan Reynolds, Samuel L Jackson, Salma Hayek, Antonio Banderas, Morgan Freeman", "Patrick Hughesz", "Golden Village Pictures", "Action", "English", "/MoviePosters/HitmansWifesBodyguardPoster.jpg", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Now Showing", "The world’s most lethal odd couple – bodyguard Michael Bryce (Ryan Reynolds) and hitman Darius Kincaid (Samuel L. Jackson) – are back on another life-threatening mission. Still unlicensed and under scrutiny, Bryce is forced into action by Darius’s even more volatile wife, the infamous international con artist Sonia Kincaid (Salma Hayek). As Bryce is driven over the edge by his two most dangerous protectees, the trio get in over their heads in a global plot and soon find that they are all that stand between Europe and total chaos. Joining in the fun and deadly mayhem are Antonio Banderas as a vengeful and powerful madman and Morgan Freeman as… well, you’ll have to see.", 9f, "Hitman's Wife's Bodyguard", "/MovieTrailers/HitmansWifesBodyguard.mp4" },
                    { 4, "PG13 - Some Violence", "/MovieBackgrounds/FastFurious9.jpg", "Vin Diesel, Charlize Theron, Michelle Rodriguez, John Cena, Tyrese Gibson", "Justin Lin", "United International Pictures", "Action", "English", "/MoviePosters/Fast&Furious9Poster.jpg", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, "Now Showing", "Vin Diesel’s Dom Toretto is leading a quiet life off the grid with Letty and his son, little Brian, but they know that danger always lurks just over their peaceful horizon. This time, that threat will force Dom to confront the sins of his past if he’s going to save those he loves most. His crew joins together to stop a world-shattering plot led by the most skilled assassin and high-performance driver they’ve ever encountered: a man who also happens to be Dom’s forsaken brother, Jakob (John Cena).", 9f, "Fast & Furious 9: The Fast Saga", "/MovieTrailers/FastFurious9.mp4" },
                    { 5, "PG13 - Some Violence", "/MovieBackgrounds/BlackWidow.jpg", "Scarlett Johansson, Florence Pugh, David Harbour, Rachel Weisz", "Cate Shortland", "Walt Disney Pictures", "Action", "English", "/MoviePosters/BlackWidowPoster.jpg", new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, "Coming Soon", "Scarlett Johansson reprises her role as Natasha/Black Widow in Marvel Studios' action-packed spy thriller Black Widow- the first film in Phase Four of the Marvel Cinematic Universe. Florence Pugh stars as Yelena, David Harbour as Alexei aka The Red Guardian and Rachel Weisz as Melina. Directed by Cate Shortland and produced by Kevin Feige.", 9f, "Marvel Studios' Black Widow", "/MovieTrailers/BlackWidow.mp4" },
                    { 6, "TBA", "/MovieBackgrounds/JungleCruise2.jpg", "Emily Blunt, Dwayne Johnson, Paul Giamatti, Jesse Plemons , Andy Nyman", "Jaume Collet-Serra", "Walt Disney Pictures", "Adventure", "English", "/MoviePosters/JungleCruisePoster.jpg", new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, "Coming Soon", "Based on Disneyland's popular theme park ride in which a small riverboat, equipped with a hilarious tour guide, takes a group of travelers through a jungle filled with dangerous animals and reptiles.", 9f, "Disney's Jungle Cruise", "/MovieTrailers/JungleCruise.mp4" },
                    { 7, "TBA", "/MovieBackgrounds/TheSuicideSquad.jpg", "Sylvester Stallone, Idris Elba, Margot Robbie, John Cena, Viola Davis, Joel Kinnaman, Jai Courtney, Peter Capaldi", "James Gunn", "Warner Bros.", "Action", "English", "/MoviePosters/TheSuicideSquadPoster.jpg", new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, "Coming Soon", "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", 9f, "The Suicide Squad", "/MovieTrailers/TheSuicideSquad.mp4" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Customer_Id",
                table: "Bookings",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Movie_Id",
                table: "Bookings",
                column: "Movie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Show_Id",
                table: "Bookings",
                column: "Show_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_Hall_Id",
                table: "Shows",
                column: "Hall_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_Movie_Id",
                table: "Shows",
                column: "Movie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_customer_id",
                table: "Tickets",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_show_id",
                table: "Tickets",
                column: "show_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
