using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class Ticket
    {
        [Key]
        public int ticket_id { get; set; }

        [Required(ErrorMessage = "Customer ID is required.")]

        public int customer_id { get; set; }

        [Required(ErrorMessage = "Ticket Price is required.")]
        public double ticket_price { get; set; }

        [Required(ErrorMessage = "Hall no is required.")]
        public int hall_number { get; set; }

        [Required(ErrorMessage = "Seat No required.")]
        public int seat_number { get; set; }

        [Required(ErrorMessage = "Show Datetime is required.")]
        public DateTime show_datetime { get; set; }

        [Required(ErrorMessage = "Show_id is required.")]

        public int show_id { get; set; }

        [Required(ErrorMessage = "Seat No is required.")]
        public int seat_id { get; set; }

        [Required(ErrorMessage = "Hall Id No is required.")]
        public int hall_id { get; set; }

        [ForeignKey("show_id")]
        public Show show { get; set; }


        [ForeignKey("customer_id")]
        public Customer customer { get; set; }
    }
}
