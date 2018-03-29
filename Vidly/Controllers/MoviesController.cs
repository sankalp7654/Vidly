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
        // GET: Movies
        /*
        public ActionResult Index()
        {
            return View();
        }
        */

        public ActionResult List()
        {
            return View();
        }

        [Route("Movies/Released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month) => Content("Fuck Off!");
        
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
           

            var customers = new List<Customer>
            {
                new Customer { Name = "Sankalp" },
                new Customer { Name = "Dibyo" },
                new Customer { Name = "Nishant" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
          
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Index(int ? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Ascending";

            return Content("Page Index = " + pageIndex + "&SortBy = " + sortBy);
   //         return Content("PageIndex");
        }

    }
}