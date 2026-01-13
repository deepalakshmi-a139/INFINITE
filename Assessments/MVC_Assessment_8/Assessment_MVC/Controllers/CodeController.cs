using Assessment_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Assessment_MVC.Controllers
{
    public class CodeController : Controller
    {
        private NorthWindEntities db = new NorthWindEntities();
        public ActionResult CustomersInGermany()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();

            return View(customers);
        }

        public ActionResult CustomerByOrder()
        {
            var customer = db.Orders
                             .Where(o => o.OrderID == 10248)
                             .Select(o => o.Customer)
                             .FirstOrDefault();

            return View(customer);
        }
    }
}
