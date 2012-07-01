using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Disturb.Models;

namespace Disturb.Controllers
{ 
    public class DeliveryController : Controller
    {
        private DisturbEntities db = new DisturbEntities();

        //
        // GET: /Delivery/

        public ViewResult Index()
        {
            return View(db.Deliveries.ToList());
        }

        //
        // GET: /Delivery/Details/5

        public ViewResult Details(int id)
        {
            Delivery delivery = db.Deliveries.Find(id);
            return View(delivery);
        }

        //
        // GET: /Delivery/Create

        public ActionResult Create()
        {            
            return View();
        } 

        //
        // POST: /Delivery/Create

        [HttpPost]
        public ActionResult Create(Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                db.Deliveries.Add(delivery);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(delivery);
        }
        
        //
        // GET: /Delivery/Edit/5
 
        public ActionResult Edit(int id)
        {
            Delivery delivery = db.Deliveries.Find(id);
            return View(delivery);
        }

        //
        // POST: /Delivery/Edit/5

        [HttpPost]
        public ActionResult Edit(Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(delivery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(delivery);
        }

        //
        // GET: /Delivery/Delete/5
 
        public ActionResult Delete(int id)
        {
            Delivery delivery = db.Deliveries.Find(id);
            return View(delivery);
        }

        //
        // POST: /Delivery/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Delivery delivery = db.Deliveries.Find(id);
            db.Deliveries.Remove(delivery);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}