using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Application.Models;
using System.Data.Entity;
using Vidly_Application.View_Models;



namespace Vidly_Application.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            this._context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult New()

        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save (Customer Customer)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                   
                    customer = Customer, 
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View ("New", viewModel);
            }
           
                if (Customer.Id == 0)
                    _context.Customers.Add(Customer);
                else
                {
                    var customerInDb = _context.Customers.Single(c => c.Id == Customer.Id);
                    customerInDb.Name = Customer.Name;
                    customerInDb.IsSubscribedToNewsletter = Customer.IsSubscribedToNewsletter;
                    customerInDb.Birthdate = Customer.Birthdate;
                    customerInDb.MembershipTypeId = Customer.MembershipTypeId;
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Customers");

           
        }
        public ActionResult Index()
        {
            
          
            return View();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(x => x.MembershipType).SingleOrDefault(c =>  c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
        public ActionResult Edit(int id )
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new NewCustomerViewModel
            {
                customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList() 


            };
            return View("New",viewModel);
        }
       
    }
}