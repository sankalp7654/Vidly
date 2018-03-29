using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        //  [Route("customer/list")]
        // Once the route has been provided explicitly It will not further match to Customers/List
        // Instead it will match to customer/list
        public ActionResult List()
        {

            /*
            var customer = new List<Customer>
            {
                new Customer { Id = 1, Name = "Sankalp Saxena" },
                new Customer { Id = 2, Name = "Shashank Soni" },
                new Customer { Id = 3, Name = "Selena Gomez" }
            };
         */

            return View();
        }

        public ActionResult Index()
        {
            return Content("In View action method");
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var Customer = new CustomersController {  };
            return View(Customer);
        }
    }
}