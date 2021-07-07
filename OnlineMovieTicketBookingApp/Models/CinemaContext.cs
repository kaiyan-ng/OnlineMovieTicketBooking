using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class CinemaContext:DbContext
    {
        public CinemaContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Hall> Halls { get; set; }

        public DbSet<Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    First_Name = "Jane",
                    Last_Name = "Doe",
                    Gender = "Female",
                    Address = "123 Bishan Street 13 Singapore 570123",
                    Date_Of_Birth = new DateTime(1990,10,10),
                    Phone = "91234567",
                    Email = "janedoe@email.com",
                    Username = "janedoe",
                    Password = "password123"

                });


            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Disney's Cruella",
                    Genre = "Comedy",
                    Language = "English",
                    Age_Rating = "PG",
                    Run_Time = 134,
                    Release_Date = new DateTime(2021, 05, 27),
                    Status = "Now Showing",
                    Cast = "Emma Stone, Emma Thompson , Joel Fry, Paul Walter Hauser, Emily Beecham, Mark Strong, Kirby Howell-Baptiste",
                    Director = "Craig Gillespie",
                    Distributor = "Walt Disney Pictures",
                    Synopsis = "A live action prequel feature film that tells the story of a young Cruella de Vil, the villain from 101 Dalmations. Cruella, which is set in 1970s London amidst the punk rock revolution, follows a young grifter named Estella (Emma Stone), a clever and creative girl determined to make a name for herself with her designs. She befriends a pair of young thieves who appreciate her appetite for mischief, and together they are able to build a life for themselves on the London streets. With their help and her creativity and wit, Estella catches the eye of fashion legend Baroness von Hellman (Emma Thompson) through her fiery flair. But their relationship sets in motion a course of events and revelations that will cause Estella to embrace her wicked side and become the raucous, fashionable and revenge-bent Cruella.",
                    Poster = "/MoviePosters/CruellaPoster.jpg",
                    Trailer = "/MovieTrailers/DisneysCruella.mp4",
                    BgImage = "/MovieBackgrounds/Cruella.jpg",
                    Ticket_Price = 9f

                },
                new Movie
                {
                    Id = 2,
                    Title = "The Conjuring: The Devil Made Me Do It",
                    Genre = "Horror",
                    Language = "English",
                    Age_Rating = "NC16 - Horror",
                    Run_Time = 112,
                    Release_Date = new DateTime(2021, 06, 11),
                    Status = "Now Showing",
                    Cast = "Patrick Wilson, Vera Farmiga, Ruairi O'Connor, Sarah Catherine Hook, Julian Hilliard",
                    Director = "Michael Chaves",
                    Distributor = "Warner Bros.",
                    Synopsis = "The Conjuring: The Devil Made Me Do It reveals a chilling story of terror, murder and unknown evil that shocked even experienced real-life paranormal investigators Ed and Lorraine Warren. One of the most sensational cases from their files, it starts with a fight for the soul of a young boy, then takes them beyond anything they’d ever seen before, to mark the first time in U.S. history that a murder suspect would claim demonic possession as a defense.",
                    Poster = "/MoviePosters/ConjuringPoster.jpg",
                    Trailer = "/MovieTrailers/TheConjuring3.mp4",
                    BgImage = "/MovieBackgrounds/TheConjuring3.jpg",
                    Ticket_Price = 9f
                },
                new Movie
                {
                    Id = 3,
                    Title = "Hitman's Wife's Bodyguard",
                    Genre = "Action",
                    Language = "English",
                    Age_Rating = "M18 - Coarse Language & Violence",
                    Run_Time = 100,
                    Release_Date = new DateTime(2021, 06, 24),
                    Status = "Now Showing",
                    Cast = "Ryan Reynolds, Samuel L Jackson, Salma Hayek, Antonio Banderas, Morgan Freeman",
                    Director = "Patrick Hughesz",
                    Distributor = "Golden Village Pictures",
                    Synopsis = "The world’s most lethal odd couple – bodyguard Michael Bryce (Ryan Reynolds) and hitman Darius Kincaid (Samuel L. Jackson) – are back on another life-threatening mission. Still unlicensed and under scrutiny, Bryce is forced into action by Darius’s even more volatile wife, the infamous international con artist Sonia Kincaid (Salma Hayek). As Bryce is driven over the edge by his two most dangerous protectees, the trio get in over their heads in a global plot and soon find that they are all that stand between Europe and total chaos. Joining in the fun and deadly mayhem are Antonio Banderas as a vengeful and powerful madman and Morgan Freeman as… well, you’ll have to see.",
                    Poster = "/MoviePosters/HitmansWifesBodyguardPoster.jpg",
                    Trailer = "/MovieTrailers/HitmansWifesBodyguard.mp4",
                    BgImage = "/MovieBackgrounds/HitmanWifeBodyguard.jpg",
                    Ticket_Price = 9f
                },
                new Movie
                {
                    Id = 4,
                    Title = "Fast & Furious 9: The Fast Saga",
                    Genre = "Action",
                    Language = "English",
                    Age_Rating = "PG13 - Some Violence",
                    Run_Time = 143,
                    Release_Date = new DateTime(2021, 07, 01),
                    Status = "Now Showing",
                    Cast = "Vin Diesel, Charlize Theron, Michelle Rodriguez, John Cena, Tyrese Gibson",
                    Director = "Justin Lin",
                    Distributor = "United International Pictures",
                    Synopsis = "Vin Diesel’s Dom Toretto is leading a quiet life off the grid with Letty and his son, little Brian, but they know that danger always lurks just over their peaceful horizon. This time, that threat will force Dom to confront the sins of his past if he’s going to save those he loves most. His crew joins together to stop a world-shattering plot led by the most skilled assassin and high-performance driver they’ve ever encountered: a man who also happens to be Dom’s forsaken brother, Jakob (John Cena).",
                    Poster = "/MoviePosters/Fast&Furious9Poster.jpg",
                    Trailer = "/MovieTrailers/FastFurious9.mp4",
                    BgImage = "/MovieBackgrounds/FastFurious9.jpg",
                    Ticket_Price = 9f
                },
                new Movie
                {
                    Id = 5,
                    Title = "Marvel Studios' Black Widow",
                    Genre = "Action",
                    Language = "English",
                    Age_Rating = "PG13 - Some Violence",
                    Run_Time = 134,
                    Release_Date = new DateTime(2021, 07, 08),
                    Status = "Coming Soon",
                    Cast = "Scarlett Johansson, Florence Pugh, David Harbour, Rachel Weisz",
                    Director = "Cate Shortland",
                    Distributor = "Walt Disney Pictures",
                    Synopsis = "Scarlett Johansson reprises her role as Natasha/Black Widow in Marvel Studios' action-packed spy thriller Black Widow- the first film in Phase Four of the Marvel Cinematic Universe. Florence Pugh stars as Yelena, David Harbour as Alexei aka The Red Guardian and Rachel Weisz as Melina. Directed by Cate Shortland and produced by Kevin Feige.",
                    Poster = "/MoviePosters/BlackWidowPoster.jpg",
                    Trailer = "/MovieTrailers/BlackWidow.mp4",
                    BgImage = "/MovieBackgrounds/BlackWidow.jpg",
                    Ticket_Price = 9f
                },
                new Movie
                {
                    Id = 6,
                    Title = "Disney's Jungle Cruise",
                    Genre = "Adventure",
                    Language = "English",
                    Age_Rating = "TBA",
                    Run_Time = 127,
                    Release_Date = new DateTime(2021, 07, 29),
                    Status = "Coming Soon",
                    Cast = "Emily Blunt, Dwayne Johnson, Paul Giamatti, Jesse Plemons , Andy Nyman",
                    Director = "Jaume Collet-Serra",
                    Distributor = "Walt Disney Pictures",
                    Synopsis = "Based on Disneyland's popular theme park ride in which a small riverboat, equipped with a hilarious tour guide, takes a group of travelers through a jungle filled with dangerous animals and reptiles.",
                    Poster = "/MoviePosters/JungleCruisePoster.jpg",
                    Trailer = "/MovieTrailers/JungleCruise.mp4",
                    BgImage = "/MovieBackgrounds/JungleCruise2.jpg",
                    Ticket_Price = 9f
                },
                 new Movie
                 {
                     Id = 7,
                     Title = "The Suicide Squad",
                     Genre = "Action",
                     Language = "English",
                     Age_Rating = "TBA",
                     Run_Time = 120,
                     Release_Date = new DateTime(2021, 08, 05),
                     Status = "Coming Soon",
                     Cast = "Sylvester Stallone, Idris Elba, Margot Robbie, John Cena, Viola Davis, Joel Kinnaman, Jai Courtney, Peter Capaldi",
                     Director = "James Gunn",
                     Distributor = "Warner Bros.",
                     Synopsis = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                     Poster = "/MoviePosters/TheSuicideSquadPoster.jpg",
                     Trailer = "/MovieTrailers/TheSuicideSquad.mp4",
                     BgImage = "/MovieBackgrounds/TheSuicideSquad.jpg",
                     Ticket_Price = 9f
                 }

                ) ;

            modelBuilder.Entity<Hall>().HasData(
               new Hall
               {
                   Id = 1,
                   Total_Seats = 40

               },
               new Hall
               {
                   Id = 2,
                   Total_Seats = 40

               },
               new Hall
               {
                   Id = 3,
                   Total_Seats = 40

               },
               new Hall
               {
                   Id = 4,
                   Total_Seats = 40

               },
               new Hall
               {
                   Id = 5,
                   Total_Seats = 40

               }
               ) ;

            modelBuilder.Entity<Show>().HasData(
              new Show
              {
                  Id = 1,
                  Date_And_Time=new DateTime(2021,06,30,10,30,0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 2,
                  Date_And_Time = new DateTime(2021, 06, 30, 13, 00, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 3,
                  Date_And_Time = new DateTime(2021, 06, 30, 15, 30, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 4,
                  Date_And_Time = new DateTime(2021, 06, 30, 18, 00, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 5,
                  Date_And_Time = new DateTime(2021, 06, 30, 20, 30, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 6,
                  Date_And_Time = new DateTime(2021, 06, 30, 10, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 2
              },
               new Show
               {
                   Id = 7,
                   Date_And_Time = new DateTime(2021, 06, 30, 13, 00, 0),
                   Movie_Id = 2,
                   Hall_Id = 2
               },
              new Show
              {
                  Id = 8,
                  Date_And_Time = new DateTime(2021, 06, 30, 15, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 9,
                  Date_And_Time = new DateTime(2021, 06, 30, 18, 00, 0),
                  Movie_Id = 2,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 10,
                  Date_And_Time = new DateTime(2021, 06, 30, 20, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 11,
                  Date_And_Time = new DateTime(2021, 06, 30, 10, 30, 0),
                  Movie_Id = 3,
                  Hall_Id = 3
              },
               new Show
               {
                   Id = 20,
                   Date_And_Time = new DateTime(2021, 07, 07, 10, 30, 0),
                   Movie_Id = 1,
                   Hall_Id = 5
               },
              new Show
              {
                  Id = 21,
                  Date_And_Time = new DateTime(2021, 07, 07, 13, 00, 0),
                  Movie_Id = 1,
                  Hall_Id = 5
              },
              new Show
              {
                  Id = 22,
                  Date_And_Time = new DateTime(2021, 07, 07, 15, 30, 0),
                  Movie_Id = 1,
                  Hall_Id = 5
              },
              new Show
              {
                  Id = 23,
                  Date_And_Time = new DateTime(2021, 07, 07, 18, 00, 0),
                  Movie_Id = 1,
                  Hall_Id = 5
              },
              new Show
              {
                  Id = 24,
                  Date_And_Time = new DateTime(2021, 07, 07, 20, 30, 0),
                  Movie_Id = 1,
                  Hall_Id = 5
              },
              new Show
              {
                  Id = 25,
                  Date_And_Time = new DateTime(2021, 07, 07, 10, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
               new Show
               {
                   Id = 26,
                   Date_And_Time = new DateTime(2021, 07, 07, 13, 00, 0),
                   Movie_Id = 2,
                   Hall_Id = 3
               },
              new Show
              {
                  Id = 27,
                  Date_And_Time = new DateTime(2021, 07, 07, 15, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
              new Show
              {
                  Id = 28,
                  Date_And_Time = new DateTime(2021, 07, 07, 18, 00, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
              new Show
              {
                  Id = 29,
                  Date_And_Time = new DateTime(2021, 07, 07, 20, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
              new Show
              {
                  Id = 30,
                  Date_And_Time = new DateTime(2021, 07, 07, 10, 30, 0),
                  Movie_Id = 3,
                  Hall_Id = 1
              },
               new Show
               {
                   Id = 31,
                   Date_And_Time = new DateTime(2021, 07, 07, 13, 00, 0),
                   Movie_Id = 3,
                   Hall_Id = 1
               },
              new Show
              {
                  Id = 32,
                  Date_And_Time = new DateTime(2021, 07, 07, 15, 30, 0),
                  Movie_Id = 3,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 33,
                  Date_And_Time = new DateTime(2021, 07, 07, 18, 00, 0),
                  Movie_Id = 3,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 34,
                  Date_And_Time = new DateTime(2021, 07, 07, 20, 30, 0),
                  Movie_Id = 3,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 35,
                  Date_And_Time = new DateTime(2021, 07, 07, 10, 30, 0),
                  Movie_Id = 4,
                  Hall_Id = 2
              },
               new Show
               {
                   Id = 36,
                   Date_And_Time = new DateTime(2021, 07, 07, 13, 00, 0),
                   Movie_Id = 4,
                   Hall_Id = 2
               },
              new Show
              {
                  Id = 37,
                  Date_And_Time = new DateTime(2021, 07, 07, 15, 30, 0),
                  Movie_Id = 4,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 38,
                  Date_And_Time = new DateTime(2021, 07, 07, 18, 00, 0),
                  Movie_Id = 4,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 39,
                  Date_And_Time = new DateTime(2021, 07, 07, 20, 30, 0),
                  Movie_Id = 4,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 40,
                  Date_And_Time = new DateTime(2021, 07, 07, 10, 30, 0),
                  Movie_Id = 5,
                  Hall_Id = 4
              },
               new Show
               {
                   Id = 41,
                   Date_And_Time = new DateTime(2021, 07, 07, 13, 00, 0),
                   Movie_Id = 5,
                   Hall_Id = 4
               },
              new Show
              {
                  Id = 42,
                  Date_And_Time = new DateTime(2021, 07, 07, 15, 30, 0),
                  Movie_Id = 5,
                  Hall_Id = 4
              },
              new Show
              {
                  Id = 43,
                  Date_And_Time = new DateTime(2021, 07, 07, 18, 00, 0),
                  Movie_Id = 5,
                  Hall_Id = 4
              },
              new Show
              {
                  Id = 44,
                  Date_And_Time = new DateTime(2021, 07, 07, 20, 30, 0),
                  Movie_Id = 5,
                  Hall_Id = 4
              },
              new Show
              {
                  Id = 50,
                  Date_And_Time = new DateTime(2021, 07, 14, 10, 30, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 51,
                  Date_And_Time = new DateTime(2021, 07, 14, 13, 00, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 52,
                  Date_And_Time = new DateTime(2021, 07, 14, 15, 30, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 53,
                  Date_And_Time = new DateTime(2021, 07, 14, 18, 00, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 54,
                  Date_And_Time = new DateTime(2021, 07, 14, 20, 30, 0),
                  Movie_Id = 1,
                  Hall_Id = 1
              },
              new Show
              {
                  Id = 55,
                  Date_And_Time = new DateTime(2021, 07, 14, 10, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
               new Show
               {
                   Id = 56,
                   Date_And_Time = new DateTime(2021, 07, 14, 13, 00, 0),
                   Movie_Id = 2,
                   Hall_Id = 3
               },
              new Show
              {
                  Id = 57,
                  Date_And_Time = new DateTime(2021, 07, 14, 15, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
              new Show
              {
                  Id = 58,
                  Date_And_Time = new DateTime(2021, 07, 14, 18, 00, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
              new Show
              {
                  Id = 59,
                  Date_And_Time = new DateTime(2021, 07, 14, 20, 30, 0),
                  Movie_Id = 2,
                  Hall_Id = 3
              },
              new Show
              {
                  Id = 60,
                  Date_And_Time = new DateTime(2021, 07, 14, 10, 30, 0),
                  Movie_Id = 3,
                  Hall_Id = 2
              },
               new Show
               {
                   Id = 61,
                   Date_And_Time = new DateTime(2021, 07, 14, 13, 00, 0),
                   Movie_Id = 3,
                   Hall_Id = 2
               },
              new Show
              {
                  Id = 62,
                  Date_And_Time = new DateTime(2021, 07, 14, 15, 30, 0),
                  Movie_Id = 3,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 63,
                  Date_And_Time = new DateTime(2021, 07, 14, 18, 00, 0),
                  Movie_Id = 3,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 64,
                  Date_And_Time = new DateTime(2021, 07, 14, 20, 30, 0),
                  Movie_Id = 3,
                  Hall_Id = 2
              },
              new Show
              {
                  Id = 65,
                  Date_And_Time = new DateTime(2021, 07, 14, 10, 30, 0),
                  Movie_Id = 4,
                  Hall_Id = 4
              },
               new Show
               {
                   Id = 66,
                   Date_And_Time = new DateTime(2021, 07, 14, 13, 00, 0),
                   Movie_Id = 4,
                   Hall_Id = 4
               },
              new Show
              {
                  Id = 67,
                  Date_And_Time = new DateTime(2021, 07, 14, 15, 30, 0),
                  Movie_Id = 4,
                  Hall_Id = 4
              },
              new Show
              {
                  Id = 68,
                  Date_And_Time = new DateTime(2021, 07, 14, 18, 00, 0),
                  Movie_Id = 4,
                  Hall_Id = 4
              },
              new Show
              {
                  Id = 69,
                  Date_And_Time = new DateTime(2021, 07, 14, 20, 30, 0),
                  Movie_Id = 4,
                  Hall_Id = 4
              },
              new Show
              {
                  Id = 70,
                  Date_And_Time = new DateTime(2021, 07, 14, 10, 30, 0),
                  Movie_Id = 5,
                  Hall_Id = 5
              },
               new Show
               {
                   Id = 71,
                   Date_And_Time = new DateTime(2021, 07, 14, 13, 00, 0),
                   Movie_Id = 5,
                   Hall_Id = 5
               },
              new Show
              {
                  Id = 72,
                  Date_And_Time = new DateTime(2021, 07, 14, 15, 30, 0),
                  Movie_Id = 5,
                  Hall_Id = 5
              },
              new Show
              {
                  Id = 73,
                  Date_And_Time = new DateTime(2021, 07, 14, 18, 00, 0),
                  Movie_Id = 5,
                  Hall_Id = 5
              },
              new Show
              {
                  Id = 74,
                  Date_And_Time = new DateTime(2021, 07, 14, 20, 30, 0),
                  Movie_Id = 5,
                  Hall_Id = 5
              }


              );
        }


    }
}
