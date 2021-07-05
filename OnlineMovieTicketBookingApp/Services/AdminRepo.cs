using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public class AdminRepo : IRepo<int, User>
    {
        private readonly CinemaContext _context;
        private readonly ILogger<AdminRepo> _logger;
        public AdminRepo(CinemaContext context, ILogger<AdminRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public User Add(int t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User k)
        {
            throw new NotImplementedException();
        }

        public int Edit(User k, int t)
        {
            throw new NotImplementedException();
        }

        public int Get(User k)
        {
            try
            {
                var myAdmin = _context.Admins.SingleOrDefault(e => e.Username == k.Username);
                if (myAdmin != null)
                {
                    var checkPass = k.Password;
                    for (int i = 0; i < checkPass.Length; i++)
                    {
                        if (checkPass[i] != myAdmin.Password[i])
                        {
                            return myAdmin.Id;
                        }
                    }
                }

                return -1;
            }
            catch (ArgumentNullException ane)
            {
                _logger.LogError("The argument is null " + ane.Message);
            }
            catch (Exception e)
            {
                _logger.LogError("The details " + e.Message);
            }
            return -1;
        }

        ICollection<int> IRepo<int, User>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
