using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Disturb.Models;

namespace Disturb.Controllers
{

    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DisturbEntities storeDB = new DisturbEntities();
        public ActionResult Index()
        {
            // Get most popular products
            var products = GetLastOrderedProducts(5);

            return View(products);
        }

        private List<Product> GetLastOrderedProducts(int count)
        {
            // Group the order details by product and return
            // the products with the highest date
            return storeDB.Products
                .OrderByDescending(a => a.OrderDetails.Max(o => o.Order.OrderDate))
                .Take(count)
                .ToList();
        }
    }



}
