using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class CustomerViewModel : Customer
    {
        [Required(ErrorMessage ="Password is required")]
        [Display(Name = "Password")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "Please re-type password")]
        [Compare("UserPassword",ErrorMessage="Password does not match")]
        public string Confirm_Password { get; set; }

        //public List<SelectListItem> GenderList { get; set; }
    }
}
