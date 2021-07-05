using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public class TicketRepo : IRepo<Ticket, int>
    {
        private readonly CinemaContext _context;
        private readonly ILogger<TicketRepo> _logger;

        public TicketRepo(CinemaContext context, ILogger<TicketRepo> logger)
        {
            _context = context;
            _logger = logger;

        }
        public int Add(Ticket t)
        {
            try
            {
                _context.Tickets.Add(t);
                _context.SaveChanges();
                _logger.LogInformation("Ticket Booked Successfully", t);
                return t.ticket_id;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not Book tickets" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return -1;
        }

        public bool Delete(int k)
        {
            try
            {
                _context.Remove(_context.Tickets.Single(a => a.ticket_id == k));
                _context.SaveChanges();
                _logger.LogInformation("Ticket Cancelled Sucessfully", k);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not Cancel the tickets " + DateTime.Now.ToString() + " Please try Later");
                _logger.LogError("The details " + e.Message);
            }
            return false;
        }

        public Ticket Edit(int k, Ticket t)
        {
            try
            {
                _context.Tickets.Update(t);
                _context.SaveChanges();
                _logger.LogInformation("Ticket details updated", k);
                return t;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not update movie ticket" + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return null;
        }

        public Ticket Get(int k)
        {
            try
            {
                var ticket = _context.Tickets.SingleOrDefault(m => m.ticket_id == k);
                return ticket;
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


        public ICollection<Ticket> GetAll()
        {

            if (_context.Tickets.Count() == 0)
            {
                return null;
            }
            return _context.Tickets.ToList();
        }
    
    }
}
