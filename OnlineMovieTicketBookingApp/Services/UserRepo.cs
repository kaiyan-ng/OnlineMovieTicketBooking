using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public class UserRepo : IRepo<Customer, int>
    {
        private readonly CinemaContext _context;
        private readonly ILogger<UserRepo> _logger;

        public UserRepo(CinemaContext context, ILogger<UserRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public int Add(Customer t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int k)
        {
            throw new NotImplementedException();
        }

        public Customer Edit(int k, Customer t)
        {
            try
            {
                var customer = Get(k);

                t.Username = customer.Username;
                t.Password = customer.Password;
                t.PasswordSalt = customer.PasswordSalt;

                //var group = _context.Group.First(g => g.Id == model.Group.Id);

                //_context.Entry(group).CurrentValues.SetValues(model.Group);

                _context.Entry(customer).CurrentValues.SetValues(t);

                // _context.Update(t);
                _context.SaveChanges();
                _logger.LogInformation("Customer details updated");
                return t;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to update the pizza details" + k + " " + e.Message);
            }
            return null;
        }

        public Customer Get(int k)
        {
            try
            {
                var cust = _context.Customers.SingleOrDefault(m => m.Id == k);
                return cust;
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

        public ICollection<Customer> GetAll()
        {
            var customerList = _context.Customers.ToList();
            return customerList;

            //List<Customer> custList = _context.Customers.Where(c => c.Id == id).ToList();
            //return custList;
        }
    }
}
