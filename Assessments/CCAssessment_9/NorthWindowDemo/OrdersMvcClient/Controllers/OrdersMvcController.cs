using OrdersMvcClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Formatting;

public class OrdersMvcController : Controller
{
    public async Task<ActionResult> Index()
    {
        List<OrderViewModel> orders = new List<OrderViewModel>();

        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:44316/"); 
            var response = await client.GetAsync("api/orders/employee/5");

            if (response.IsSuccessStatusCode)
            {
                orders = await response.Content.ReadAsAsync<List<OrderViewModel>>();
            }
        }

        return View(orders);
    }
}
