using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public class MovieRepo : IRepo<Movie, int>
    {
        private readonly CinemaContext _context;
        private readonly ILogger<MovieRepo> _logger;
        public MovieRepo(CinemaContext context, ILogger<MovieRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public int Add(Movie t)
        {
            try
            {
                _context.Movies.Add(t);
                _context.SaveChanges();
                _logger.LogInformation("Movie added", t);
                return t.Id;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not add movie" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return -1;
        }

        public bool Delete(int k)
        {
            try
            {
                _context.Remove(_context.Movies.Single(a => a.Id == k));
                _context.SaveChanges();
                _logger.LogInformation("Movie deleted", k);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not delete movie" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return false;
        }

        public Movie Edit(int k, Movie t)
        {
            try
            {
                _context.Movies.Update(t);
                _context.SaveChanges();
                _logger.LogInformation("Movie updated", k);
                return t;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not edit movie" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return null;

        }

        public Movie Get(int k)
        {
            try
            {
                var movie = _context.Movies.SingleOrDefault(m => m.Id == k);
                return movie;
            }
            catch (ArgumentNullException ane)
            {
                _logger.LogError("The argument is null " + ane.Message);
            }
            catch (Exception e)
            {
                _logger.LogError("The details " + e.Message);
            }
            return null;
        }

        public ICollection<Movie> GetAll()
        {
            if (_context.Movies.Count() == 0)
            {
                return null;
            }
            return _context.Movies.ToList();
        }
        
    }
}
