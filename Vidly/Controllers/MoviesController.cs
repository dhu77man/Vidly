using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;



namespace Vidly.Controllers
{

    public class MoviesController : Controller
    {
        // GET: Movie

        private MoviesViewModel moviesDB = new MoviesViewModel
        {
            Movies = new List<Movie>{
                new Movie { Name = "Wheel Of Time" },
                new Movie { Name = "Lord of The Rings" }
            }
        };

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            return View(moviesDB);
        }



        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"},
                new Customer { Name = "Customer 3"},
                new Customer { Name = "Customer 4"},
                new Customer { Name = "Customer 5"},
                new Customer { Name = "Customer 6"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }
    }
}