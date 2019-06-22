using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_Application.Dtos;
using Vidly_Application.Models;

namespace Vidly_Application.Controllers.api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MoviesIds.Contains(m.Id)).ToList();

            foreach(var movie in movies)
            {
                if (movie.numberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.numberAvailable--;
                var rental = new rental
                {
                    
                    customer = customer,
                    movie = movie,
                    dateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);  
            }
            _context.SaveChanges();
            return Ok();

        }
    }
}
