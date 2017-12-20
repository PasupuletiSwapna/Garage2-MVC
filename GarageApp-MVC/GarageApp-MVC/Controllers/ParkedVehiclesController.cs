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
using GarageApp_MVC.Models.ViewModels;

namespace GarageApp_MVC.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private RegisterContext db = new RegisterContext();

        // GET: ParkedVehicles
        public ActionResult Index(string searchBy, string search)
        {
            //var vehicles = db.Vehicles.Include(p => p.Member).Include(p => p.VehicleType);
            //var vehis = db.Vehicles.Include(v => v.RegNum).Include(v => v.VehicleType);
            var vehicls = from s in db.Vehicles select s;
            //if (!string.IsNullOrEmpty(Searchstring))
            //{
            //    vehicls = vehicls.Where(s => s.RegNum.Contains(Searchstring) || s.VehicleType.VType.Contains(Searchstring));

            //}

            if (searchBy == "RegNum")
            {
                vehicls = vehicls.Where(x => x.RegNum == search || search == null);
            }
            else if (searchBy == "VType")
            {
                vehicls = vehicls.Where(x => x.VehicleType.VType == search || search == null);
            }
            else
            {
                vehicls = vehicls.Where(x => x.RegNum.StartsWith(search) || search == null);
            }
            return View(vehicls);
        }



        public ActionResult OverViewIndex()
        {
            var pvehicles = db.Vehicles;
            List<Overview> model = new List<Overview>();
            foreach(ParkedVehicle p in pvehicles)
            {
                Overview ov = new Overview();
                ov.OwnerName = p.Member.OwnerName;
                ov.VType = p.VehicleType.VType;
                ov.RegNum = p.RegNum;
                ov.ParkingTime = p.ParkingTime;
                model.Add(ov);
            }
            return View(model.OrderByDescending(p=>p.RegNum));
        }

        // GET: ParkedVehicles/Details/5
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

        // GET: ParkedVehicles/Create
        public ActionResult Create()
        {
            ViewBag.MemberId = new SelectList(db.Members, "Id", "OwnerName");
            ViewBag.VehicleTypeId = new SelectList(db.Vehicletypes, "Id", "VType");
            return View();
        }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegNum,Color,Brand,Model,NoOfWheels,SeatCapacity,ParkingTime,MemberId,VehicleTypeId")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                parkedVehicle.ParkingTime = DateTime.Now;
                db.Vehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MemberId = new SelectList(db.Members, "Id", "OwnerName", parkedVehicle.MemberId);
            ViewBag.VehicleTypeId = new SelectList(db.Vehicletypes, "Id", "VType", parkedVehicle.VehicleTypeId);
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Edit/5
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
            ViewBag.MemberId = new SelectList(db.Members, "Id", "OwnerName", parkedVehicle.MemberId);
            ViewBag.VehicleTypeId = new SelectList(db.Vehicletypes, "Id", "VType", parkedVehicle.VehicleTypeId);
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RegNum,Color,Brand,Model,NoOfWheels,SeatCapacity,ParkingTime,MemberId,VehicleTypeId")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parkedVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MemberId = new SelectList(db.Members, "Id", "OwnerName", parkedVehicle.MemberId);
            ViewBag.VehicleTypeId = new SelectList(db.Vehicletypes, "Id", "VType", parkedVehicle.VehicleTypeId);
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
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

        // POST: ParkedVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            var pv = new PrintReceiptView(parkedVehicle);
          
            db.Vehicles.Remove(parkedVehicle);
            db.SaveChanges();
            return View("DeleteConfirmed",pv);
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
