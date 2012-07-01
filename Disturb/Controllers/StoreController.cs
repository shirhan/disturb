using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Disturb.Models;

namespace Disturb.Controllers
{
    public class StoreController : Controller
    {
        DisturbEntities storeDB = new DisturbEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var categories = storeDB.Categories.ToList();
            return View(categories);

        }
        //
        // GET: /Store/Browse?category=Поли
        public ActionResult Browse(string category)
        {
            var categoryModel = storeDB.Categories.Include("Products").Single(g => g.Name == category);

            return View(categoryModel);
        }
        //
        // GET: /Store/Details/id
        public ActionResult Details(string id)
        {
            var product = storeDB.Products.Single(p => p.Code == id);
            return View(product);
        }

        //
        // GET: /Store/CategoryMenu
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();
            return PartialView(categories);
        }
    }
}
