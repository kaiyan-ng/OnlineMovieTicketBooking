using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using OnlineMovieTicketBookingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly CinemaContext _context;
        private readonly ILogger<AdminController> _logger;

        public AdminController(CinemaContext context, ILogger<AdminController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            User user = new User();
            return View(user);

        }

        [HttpPost]
        public IActionResult Login(User user)
        {

            try
            {
                var myAdmin = _context.Admins.SingleOrDefault(e => e.Username == user.Username);
                if (myAdmin != null)
                { 
                    var checkPass = user.Password;
                    for (int i = 0; i < checkPass.Length; i++)
                    {
                        if (checkPass[i] != myAdmin.Password[i])
                        {
                            ViewBag.Message = "Invalid username or password";
                            return View();
                        }

                    }
                    ViewBag.Message = "Welcome " + myAdmin.First_Name;
                    return RedirectToAction("Index", "Admin");

                }
                else
                    ViewBag.Message = "Invalid username or password";
                return View();
            }
            catch (Exception)
            {
                _logger.LogDebug("Login failed " + user);
            }
            return View();
        }




    }
}
