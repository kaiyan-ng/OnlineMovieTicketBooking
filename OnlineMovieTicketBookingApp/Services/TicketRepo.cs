using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public class TicketRepo : ITicketRepo<Show, int>
    {
        private readonly CinemaContext _context;
        private readonly ILogger<TicketRepo> _logger;
        public TicketRepo(CinemaContext context, ILogger<TicketRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public int Add(Show t)
        {
            try
            {
                if (t.Hall_Id == 0 || t.Movie_Id == 0)
                {
                    return -1;
                }

                if (_context.Shows.Any(m => m.Hall_Id == t.Hall_Id && m.Date_And_Time == t.Date_And_Time) == false)
                {
                    _context.Shows.Add(t);
                    _context.SaveChanges();
                    _logger.LogInformation("Show time added", t);
                    return t.Id;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Could not add show time" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return -1;
        }

        public bool Delete(int k)
        {
            try
            {
                _context.Remove(_context.Shows.Single(a => a.Id == k));
                _context.SaveChanges();
                _logger.LogInformation("Showtime deleted", k);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not delete showtime" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return false;
        }

        public Show Edit(int k, Show t)
        {
            try
            {
                if (_context.Shows.Any(m => m.Hall_Id == t.Hall_Id && m.Date_And_Time == t.Date_And_Time) == false)
                {
                    _context.Shows.Update(t);
                    _context.SaveChanges();
                    _logger.LogInformation("Showtime updated", k);
                    return t;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                _logger.LogError("Could not edit showtime" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return null;
        }

        public Show Get(int k)
        {
            try
            {
                var show = _context.Shows.Include(m => m.Movie).Include(h => h.Hall).SingleOrDefault(m => m.Id == k);
                return show;
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


        public ICollection<Show> GetByMovieId(int k)
        {
            try
            {
                List<Show> shows = _context.Shows.Include(m => m.Movie).Include(h => h.Hall).Where(m => m.Movie_Id == k).ToList();
                return shows;
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

        public ICollection<Show> GetAll()
        {
            if (_context.Shows.Count() == 0)
            {
                return null;
            }

            List<Show> myShows = _context.Shows.Include(m => m.Movie).Include(h => h.Hall).ToList();
            return myShows;
        }
    }
}
