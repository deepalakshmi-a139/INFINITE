using OrdersApiDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrdersApiDemo.Controllers
{
    public class OrdersController : ApiController
    {

        private NorthWindEntities db = new NorthWindEntities();

        
        [HttpGet]
        [Route("api/orders/employee/{id}")]
        public IHttpActionResult GetOrdersByEmployee(int id)
        {
            var orders = db.Orders
                           .Where(o => o.EmployeeID == id)
                           .ToList();

            if (!orders.Any())
                return NotFound();

            return Ok(orders);
        }
    }
}
