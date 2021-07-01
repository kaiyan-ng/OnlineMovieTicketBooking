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
    public class ShowController : Controller
    {
        private readonly IRepo<Show, int> _repo;
        private readonly ILogger<ShowController> _logger;

        public ShowController(IRepo<Show, int> repo, ILogger<ShowController> logger)
        {
            _repo = repo;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var shows = _repo.GetAll();
            if (shows == null)
            {
                ViewBag.Message = "No movies available";
                return View();
            }
            
            return View(shows);
        }

        public IActionResult Create()
        {
            Show show = new Show();
            return View(show);
        }

        [HttpPost]
        public IActionResult Create(Show show)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    show.Id = _repo.Add(show);

                    if (show.Id < 0)
                    {
                        ViewBag.Message = "Add Showtime Failed";
                        return View();
                    }
                    return RedirectToAction("Index","Show");
                }
                ViewBag.Message = "Add Showtime Failed";
                return View();
            }
            catch
            {
                _logger.LogDebug("Add showtime failed " + show);
            }
            ViewBag.Message = "Add Showtime Failed";
            return View();
        }

        public IActionResult Edit(int id)
        {
            Show show;
            try
            {
                show = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                show = null;
            }
            catch (InvalidOperationException)
            {
                show = null;
            }

            return View(show);
        }

        [HttpPost]
        public IActionResult Edit(int id, Show show)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    Show myShow = _repo.Edit(id, show);

                    if (myShow != null){
                        return RedirectToAction("Index", "Show");
                    }

                }
            }
            catch (Exception)
            {
                _logger.LogDebug("Edit showtime failed " + show);
            }

            ViewBag.Message = "Edit Showtime Failed.";
            return View();
        }

        public IActionResult Delete(int id)
        {
            Show show;
            try
            {
                show = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                show = null;
            }
            catch (InvalidOperationException)
            {
                show = null;
            }

            return View(show);
        }

        [HttpPost]
        public IActionResult Delete(int id, Show show)
        {
            try
            {
                if (_repo.Delete(id))
                {
                    return RedirectToAction("Index","Show");
                }
                else
                {
                    ViewBag.Message("Delete Showtime Failed");
                    return View();
                }

            }
            catch (Exception)
            {
                _logger.LogDebug("Delete showtime failed " + show);
            }
            return View();
        }

    }
}
