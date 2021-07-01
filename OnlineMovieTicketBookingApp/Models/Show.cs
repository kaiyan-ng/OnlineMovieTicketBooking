using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class Show
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public DateTime Date_And_Time { get; set; }

        [Required (ErrorMessage = "This field is required.")]
        [Display(Name = "Movie")]
        public int Movie_Id { get; set; }

        
        [ForeignKey("Movie_Id")]
        public Movie Movie { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Hall_Id { get; set; }

        [ForeignKey("Hall_Id")]
        public Hall Hall { get; set; }
    }
}
