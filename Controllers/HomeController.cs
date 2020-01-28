using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AJW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AJWTEST.Models;
using Newtonsoft.Json.Linq;

namespace AJWTEST.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

public ActionResult Index(string query)
        {
            JObject o = JObject.Parse(System.IO.File.ReadAllText(@"Models/Orders.json"));
            
              JArray so = (JArray)o["orders"]["sOrders"]["data"];
              JArray po =  (JArray)o["orders"]["pOrders"]["data"];

              IList<Order> orders = so.ToObject<IList<Order>>();
              ((List<Order>)orders).AddRange(po.ToObject<IList<Order>>());
              
              IList<Order> searchReturned = new List<Order>();
                Console.WriteLine("query = " + query);
              //return search items
              foreach (Order order in orders)
              {
                  if (order.PnUpper == query | order.SoNumber == query)
                  {
                      searchReturned.Add(order);
                  }
                
              }              
              //nothing searched
              if (query == null | query == "")
              {
                  
                  return View(orders);
              }

              //no results returned
              if (searchReturned.Count < 1)
              {

                  //write that nothing has appeared
                  return View();
              }

              
              return View(searchReturned);
    
        }

        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}