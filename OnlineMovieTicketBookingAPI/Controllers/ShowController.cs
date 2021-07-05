using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingAPI.Models;
using OnlineMovieTicketBookingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly IRepo<Show, int> _repo;
        private readonly ILogger<ShowController> _logger;

        public ShowController(IRepo<Show, int> repo, ILogger<ShowController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var shows = _repo.GetAll();
                return Ok(shows);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not get all the showtimes " + e.Message);
            }
            return BadRequest("No showtimes available");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var show = _repo.Get(id);
                if (show != null)
                    return Ok(show);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not get the showtime " + e.Message);
            }
            return BadRequest("Unable to fetch showtime");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Show show)
        {
            try
            {
                int id = _repo.Add(show);
                if (id != -1)
                    return Ok(show);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not add showtime " + e.Message);
            }
            return BadRequest("Showtime not added");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Show show)
        {
            try
            {
                var myPizza = _repo.Edit(id, show);
                if (myPizza != null)
                    return Ok(show);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not update showtime " + e.Message);
            }
            return BadRequest("Showtime not updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var myShow= _repo.Delete(id);
                if (myShow != null)
                    return Ok(myShow);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not delete " + e.Message);
            }
            return BadRequest("Showtime not deleted");
        }



    }
}
