using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string Last_Name { get; set; }

        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime Date_Of_Birth { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        public string Password { get; set; }

    }
}
