using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GarageApp_MVC.DataAccessLayer;
using GarageApp_MVC.Models;

namespace GarageApp_MVC.Controllers
{
    public class SortingController : Controller
    {
        private RegisterContext db = new RegisterContext();

      
        
        // GET: Sorting
        public ActionResult Index(string sortOrder)                                   
        {
        
            List<ParkedVehicle> allvehicles;                                                                                                                                                                                                                                                                                                                                                                                                              //here no neeed to create new list,then sorting will work
          
            switch (sortOrder)
                {
                    case "VehicleType":
                        allvehicles = db.Vehicles.OrderByDescending(a => a.VehicleType).ToList();
                        break;

                    case "RegNum":
                        allvehicles = db.Vehicles.OrderByDescending(a => a.RegNum).ToList(); 
                        break;

                    case "Color":
                        allvehicles = db.Vehicles.OrderByDescending(a => a.Color).ToList(); 
                        break;

                    case "Brand":
                        allvehicles = db.Vehicles.OrderByDescending(a => a.Brand).ToList(); 
                        break;

                    case "Model":
                        allvehicles = db.Vehicles.OrderByDescending(a => a.Model).ToList(); 
                        break;

                    case "NoOfWheels":
                        allvehicles = db.Vehicles.OrderByDescending(a => a.NoOfWheels).ToList(); 
                        break;

                    case "SeatCapacity":
                        allvehicles = db.Vehicles.OrderByDescending(a => a.SeatCapacity).ToList(); 
                        break;
                default:
                    allvehicles = db.Vehicles.OrderBy(a => a.Brand).ToList(); 
                    break;

                
            }
            return View(allvehicles);
        }

    
        
        
        
        
        
        
        
        
        
        
        
        // GET: Sorting/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // GET: Sorting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sorting/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VehicleType,RegNum,Color,Brand,Model,NoOfWheels,SeatCapacity,ParkingTime,Search")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }

        // GET: Sorting/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // POST: Sorting/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VehicleType,RegNum,Color,Brand,Model,NoOfWheels,SeatCapacity,ParkingTime,Search")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parkedVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parkedVehicle);
        }

        // GET: Sorting/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // POST: Sorting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(parkedVehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
