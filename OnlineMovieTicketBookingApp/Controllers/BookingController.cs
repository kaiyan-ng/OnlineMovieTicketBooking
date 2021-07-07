using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using OnlineMovieTicketBookingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMovieTicketBookingApp.Helper;

namespace OnlineMovieTicketBookingApp.Controllers
{
    public class BookingController : Controller
    {
        private readonly CinemaContext _context;
        private readonly IRepo<Movie, int> _movierepo;
        private readonly ITicketRepo<Show, int> _showrepo;
        private readonly IBookingRepo<Booking, int> _repo;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<MovieController> _logger;

        public BookingController(CinemaContext context, IRepo<Movie, int> movierepo, ITicketRepo<Show, int> showrepo, IBookingRepo<Booking, int> repo, IWebHostEnvironment webHostEnvironment, ILogger<MovieController> logger)
        {
            _movierepo = movierepo;
            _showrepo = showrepo;
            _repo = repo;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }
        public IActionResult Index(int movieId)
        {
            BookingViewModel bookingView = new BookingViewModel();
            try
            {
                bookingView.Movie = _movierepo.Get(movieId);
                bookingView.Shows = _showrepo.GetByMovieId(movieId);
            }
            catch (ArgumentNullException)
            {
                bookingView = null;
            }
            catch (InvalidOperationException)
            {
                bookingView = null;
            }

            return View(bookingView);
        }

        [HttpPost]
        public IActionResult Index(int movieId, BookingViewModel bookingView)
        {
            try
            {
                bookingView.Movie = _movierepo.Get(movieId);
                if (ModelState.IsValid)
                {
                    bookingView.Show = _showrepo.Get(bookingView.Show_Id);
                    TempData["SelectedMovie"] = movieId;
                    TempData.Put("SelectedBooking", bookingView);
                    TempData.Keep("SelectedMovie");
                    TempData.Keep("SelectedBooking");
                    return RedirectToAction("Confirmation");
                }
                bookingView.Shows = _showrepo.GetByMovieId(movieId);
            }
            catch (ArgumentNullException)
            {
                bookingView = null;
            }
            catch (InvalidOperationException)
            {
                bookingView = null;
            }

            return View(bookingView);
        }

        public IActionResult Confirmation()
        {

            if (TempData.Peek("SelectedBooking") != null)
            {
                BookingViewModel bookingView = TempData.Get<BookingViewModel>("SelectedBooking");
                TempData.Remove("SelectedBooking");
                TempData.Put("SelectedBooking", bookingView);
                TempData.Keep("SelectedBooking");
                return View(bookingView);
            }
            else if (TempData.Peek("SelectedMovie") != null)
                return RedirectToAction("Index", new { Id = TempData.Peek("SelectedMovie") });
            else
                return RedirectToAction("Index", "Movie");

        }

        [HttpPost]
        public IActionResult Confirmation(BookingViewModel bookingView)
        {
            Booking booking = new Booking();
            try
            {
                if (TempData.Peek("SelectedBooking") != null)
                {
                    bookingView = TempData.Get<BookingViewModel>("SelectedBooking");
                }
                booking.Movie_Id = bookingView.Movie_Id;
                booking.Customer_Id = bookingView.Customer_Id;
                booking.Show_Id = bookingView.Show_Id;
                booking.Total_Tickets = bookingView.Total_Tickets;
                booking.Total_Price = bookingView.Total_Price;
                _repo.Add(booking);

                return RedirectToAction("BookingConfirmed");

            }
            catch (ArgumentNullException)
            {
                booking = null;
            }
            catch (InvalidOperationException)
            {
                booking = null;
            }

            return View(booking);
        }

        public IActionResult BookingConfirmed()
        {
            TempData.Remove("SelectedMovie");
            TempData.Remove("SelectedBooking");
            return View();
        }

        public IActionResult ViewBooking(int customerId)
        {
            var booking = _repo.GetByCustomerId(customerId);
            return View(booking);
        }
    }
}
