using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public class BookingRepo : IBookingRepo<Booking, int>
    {
        private readonly CinemaContext _context;
        private readonly ILogger<BookingRepo> _logger;

        public BookingRepo(CinemaContext context, ILogger<BookingRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public int Add(Booking t)
        {
            try
            {
                t.Created_Date = DateTime.Now;
                _context.Bookings.Add(t);
                _context.SaveChanges();
                _logger.LogInformation("Booking added", t);
                return t.Id;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not add booking" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return -1;
        }

        public bool Delete(int k)
        {
            throw new NotImplementedException();
        }

        public Booking Edit(int k, Booking t)
        {
            throw new NotImplementedException();
        }

        public Booking Get(int k)
        {
            try
            {
                var booking = _context.Bookings.Include(c => c.Customer).Include(m => m.Movie).Include(s => s.Show).SingleOrDefault(m => m.Id == k);
                return booking;
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
        public ICollection<Booking> GetByCustomerId(int k)
        {
            try
            {
                return _context.Bookings.Include(c => c.Customer).Include(m => m.Movie).Include(s => s.Show).Where(m => m.Customer_Id == k).ToList();
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

        public ICollection<Booking> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
