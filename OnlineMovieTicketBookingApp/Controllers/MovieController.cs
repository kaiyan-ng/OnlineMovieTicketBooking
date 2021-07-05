using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using OnlineMovieTicketBookingApp.Services;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace OnlineMovieTicketBookingApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly CinemaContext _context;
        private readonly IRepo<Movie, int> _repo;
        private readonly IWebRepo<Show, int> _showRepo;
        private readonly ILogger<MovieController> _logger;

        public MovieController(IWebRepo<Show, int> showRepo, CinemaContext context, IRepo<Movie, int> repo, ILogger<MovieController> logger)
        {
            _repo = repo;
            _context = context;
            _showRepo = showRepo;
            _logger = logger;
        }

        
        public IActionResult Index()
        {
            var movies = _repo.GetAll();
            if (movies == null)
            {
                ViewBag.Message = "No movies available";
                return View();
            }
            return View(movies);
        }

        public IActionResult Create()
        {
            Movie movie = new Movie();
            return View(movie);

        }

        [HttpPost]
        //public async Task<IActionResult> Create(Movie movie)
        public IActionResult Create(Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Movie myMovie = movie;
                    movie.Id = _repo.Add(myMovie);
                return RedirectToAction("List");

                }
                else
                {
                    return View();
                }


            }
            catch (Exception)
            {
                _logger.LogDebug("Add movie failed " + movie);
            }
            ViewBag.Message = "Add Movie Failed";
            return View();

        }

        public IActionResult List()
        {
            var movies = _repo.GetAll();
            if (movies == null)
            {
                ViewBag.Message = "No movies available";
                return View();
            }
            return View(movies);
        }

        //public IActionResult Details(int id)
        //{
        //    Movie movie;
        //    List<Show> showTimes = new List<Show>();
        //    try
        //    {
        //        movie = _repo.Get(id);
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        movie = null;
        //    } catch (InvalidOperationException)
        //    {
        //        movie = null;
        //    }

        //    showTimes = _context.Shows.Where(s => s.Movie_Id == id).ToList();
            

        //    return View(movie);
        //}

        public IActionResult Details(int id)
        {
            MovieTimeViewModel myModel = new MovieTimeViewModel();
           

            try
            {
                myModel.Movie = _repo.Get(id);
                myModel.Shows = _context.Shows.Where(s => s.Movie_Id == id).ToList();
            }
            catch (ArgumentNullException)
            {
                myModel.Movie = null;
            }
            catch (InvalidOperationException)
            {
                myModel.Movie = null;
            }

            if (myModel.Shows.Count() == 0)
            {
                ViewBag.Message = "There are no showtimes available.";
            }

            return View(myModel);

        }




        public IActionResult Delete(int id)
        {
            Movie movie;
            try
            {
                movie = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                movie = null;
            }
            catch (InvalidOperationException)
            {
                movie = null;
            }

            return View(movie);

        }

        [HttpPost]
        public IActionResult Delete(int id, Movie movie)
        {
            try
            {
                if (_repo.Delete(id))
                    {
                        return RedirectToAction("List");
                    }
                    else
                    {
                        ViewBag.Message("Delete movie unsuccessful.");
                        return View();
                    }

            }
            catch (Exception)
            {
                _logger.LogDebug("Delete movie failed " + movie);
            }
            return View();

        }

        public IActionResult Edit(int id)
        {
           
            Movie movie;
            try
            {
                movie = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                movie = null;
            }
            catch (InvalidOperationException)
            {
                movie = null;
            }

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(int id, Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Movie myMovie = _repo.Edit(id, movie);
                    return RedirectToAction("List");

                }
            }
            catch (Exception)
            {
                _logger.LogDebug("Edit movie failed " + movie);
            }
            return View();
        }

    }

    
}
