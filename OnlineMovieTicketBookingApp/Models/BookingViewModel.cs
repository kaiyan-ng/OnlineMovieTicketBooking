using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class BookingViewModel : Booking
    {
        public ICollection<Show> Shows { get; set; }
    }
}
