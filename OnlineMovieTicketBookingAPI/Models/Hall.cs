using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingAPI.Models
{
    public class Hall
    {
        [Key]
        public int Id { get; set; }
        public int Total_Seats { get; set; }
    }
}
