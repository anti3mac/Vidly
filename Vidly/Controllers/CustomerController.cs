using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private IEnumerable<Customer> GetCustomers() 
        { 
            return new List<Customer> 
            { 
                new Customer { Id = 1, Name = "John Smith" }, new Customer { Id = 2, Name = "Mary Williams" } 
            }; 
        }
        // GET: Customer
        [Route("Customer")]
        public ActionResult Customer()
        {
            //var customer = new List<Customer>
            //{
            //    new Customer {Id = 1,Name = "Customer 1"},
            //    new Customer {Id = 2,Name = "Customer 2"}
            //};
            var customer = GetCustomers().ToList();
            var viewModel = new RandomMovieViewModel
            {
                Customers = customer
            };
            return View(viewModel);
        }

        [Route("Customer/{Id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}