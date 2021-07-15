using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = _context.Movies.Include(c=>c.Genre).ToList();
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie
            };
            return View(viewModel);
        }
        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c=>c.Genre).SingleOrDefault(c=>c.Id == id);
            //var movie = _context.Movies.Include(c => c.Id == id).SingleOrDefault();
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
    }
}