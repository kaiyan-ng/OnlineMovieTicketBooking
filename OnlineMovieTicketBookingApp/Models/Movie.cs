using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Language { get; set; }

        [Display(Name ="Age Rating")]
        [Required(ErrorMessage = "This field is required.")]
        public string Age_Rating { get; set; }

        [Display(Name = "Running Time")]
        [Required(ErrorMessage = "This field is required.")]
        public int Run_Time { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "This field is required.")]
        public DateTime Release_Date { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Status { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Cast {get; set;}
        [Required(ErrorMessage = "This field is required.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Distributor { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Synopsis { get; set; }

        [Display(Name = "Poster File Name")]
        [Required(ErrorMessage ="This field is required.")]
        public string Poster { get; set; }

        [Display(Name = "Trailer File Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string Trailer { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Background Image File Name")]
        public string BgImage { get; set; }

        [Display(Name = "Ticket Price")]
        [Required(ErrorMessage = "This field is required.")]
        public float Ticket_Price { get; set; }

        //[NotMapped]
        //[Display(Name = "Upload Poster")]
        //[Required]
        //public IFormFile Poster_File { get; set; }

        //[NotMapped]
        //[Display(Name = "Upload Trailer")]
        //[Required]
        //public IFormFile Trailer_File { get; set; }

        //[NotMapped]
        //[Display(Name = "Upload Background")]
        //[Required]
        //public IFormFile Bg_File { get; set; }

    }
}
