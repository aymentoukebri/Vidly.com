using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_Application.Dtos;
using Vidly_Application.Models;
using System.Data.Entity;

namespace Vidly_Application.Controllers.api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
         
        //GET /api/movies
        public IEnumerable<MovieDto> GetMovies(string query = null)
        {

            var moviesQuery = _context.Movies
                  .Include(m => m.Genre)
                   .Where(m => m.numberAvailable > 0); 
            if (!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));
            return moviesQuery
                 .ToList()
                 .Select(Mapper.Map<Movie, MovieDto>);
        }
        //GET /api/movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return Ok(Mapper.Map<Movie, MovieDto>(movie));

        }

        //PUT /api/movies/1
        [HttpPut]
        public void UpdateMovie(MovieDto movieDto , int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto, movieInDb);
            movieDto.Date_added = DateTime.Now;
            _context.SaveChanges();

        }

        //POST /api/movies/1

        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
                if (!ModelState.IsValid)
                    return BadRequest();
           
          
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);

        }

        //DELETE /api/movies/1
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
           
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }
    }
}
