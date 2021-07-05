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
        private readonly IRepo<int, User> _repo;
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger, IRepo<int, User> repo)
        {
            _logger = logger;
            _repo = repo;
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
                int adminId = _repo.Get(user);
                if(adminId == -1)
                {
                    ViewBag.Message = "Invalid username or password";
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Admin");
                }

            }
            catch (Exception)
            {
                _logger.LogDebug("Login failed " + user);
            }
            return View();
        }




    }
}
