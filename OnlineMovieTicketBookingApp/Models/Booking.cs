using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public int Movie_Id { get; set; }

        public int Customer_Id { get; set; }

        public int Show_Id { get; set; }

        [Required(ErrorMessage = "Please enter total tickets")]
        public int Total_Tickets { get; set; }
        public float Total_Price { get; set; }
        public DateTime Created_Date { get; set; }

        [ForeignKey("Show_Id")]
        public Show Show { get; set; }

        [ForeignKey("Movie_Id")]
        public Movie Movie { get; set; }

        [ForeignKey("Customer_Id")]
        public Customer Customer { get; set; }
    }
}
