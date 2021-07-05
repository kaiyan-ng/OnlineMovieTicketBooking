using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class MovieTimeViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Show> Shows { get; set; }

    }
}
