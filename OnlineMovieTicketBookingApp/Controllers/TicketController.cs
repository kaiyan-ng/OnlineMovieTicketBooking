using Microsoft.AspNetCore.Hosting;
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
    public class TicketController : Controller
    {
        private readonly CinemaContext _context;
        private readonly IRepo<Ticket, int> _repo;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<TicketController> _logger;
    


        public TicketController(CinemaContext context, IRepo<Ticket, int> repo, IWebHostEnvironment webHostEnvironment, ILogger<TicketController> logger)
        {
            _repo = repo;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }
        // GET: TicketController
        public IActionResult Index()
        {
            var tickets = _repo.GetAll();
            if (tickets == null)
            {
                ViewBag.Message = "No tickets available";
                return View();
            }
            return View(tickets);
        }



        // GET: TicketController/Create
        public IActionResult Create()
        {
            Ticket ticket = new Ticket();
            return View(ticket);
        }

        // POST: TicketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Ticket myTicket = ticket;
                    ticket.ticket_id = _repo.Add(myTicket);
                    return RedirectToAction("List");

                }
                else
                {
                    return View();
                }


            }
            catch (Exception)
            {
                _logger.LogDebug("Add ticket failed " + ticket);
            }
            ViewBag.Message = "Add Ticket Failed";
            return View();

        }

        public IActionResult List()
        {
            var tickets = _repo.GetAll();
            if (tickets == null)
            {
                ViewBag.Message = "No tickets booked";
                return View();
            }
            return View(tickets);
        }

        public IActionResult Details(int id)
        {
            Ticket ticket;
            try
            {
                ticket = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                ticket = null;
            }
            catch (InvalidOperationException)
            {
                ticket = null;
            }

            return View(ticket);
        }


        public IActionResult Delete(int id)
        {
            Ticket ticket;
            try
            {
                ticket = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                ticket = null;
            }
            catch (InvalidOperationException)
            {
                ticket = null;
            }

            return View(ticket);

        }

        [HttpPost]
        public IActionResult Delete(int id, Ticket ticket)
        {
            try
            {
                if (_repo.Delete(id))
                {
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Message("Delete ticket unsuccessful.");
                    return View();
                }

            }
            catch (Exception)
            {
                _logger.LogDebug("Delete ticket failed " + ticket);
            }
            return View();

        }

        // GET: TicketController/Edit/5
        public IActionResult Edit(int id)
        {
            Ticket ticket;
            try
            {
                ticket = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                ticket = null;
            }
            catch (InvalidOperationException)
            {
                ticket = null;
            }

            return View(ticket);
        }

        // POST: TicketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Ticket ticket)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Ticket myTicket = _repo.Edit(id, ticket);
                    return RedirectToAction("List");

                }
            }
            catch (Exception)
            {
                _logger.LogDebug("Edit Ticket failed " + ticket);
            }
            return View();
        }
    
    }
}
