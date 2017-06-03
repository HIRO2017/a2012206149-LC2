using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using a12206149_ENT.ENT.Entities;
using a12206149_PER;

namespace a12206149.MVC.Controllers
{
    public class LugarViajesController : Controller
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: LugarViajes
        public ActionResult Index()
        {
            return View(db.LugarViajes.ToList());
        }

        // GET: LugarViajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LugarViaje lugarViaje = db.LugarViajes.Find(id);
            if (lugarViaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarViaje);
        }

        // GET: LugarViajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LugarViajes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lugarViajeId,Descripcion,NombreLugarViaje")] LugarViaje lugarViaje)
        {
            if (ModelState.IsValid)
            {
                db.LugarViajes.Add(lugarViaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lugarViaje);
        }

        // GET: LugarViajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LugarViaje lugarViaje = db.LugarViajes.Find(id);
            if (lugarViaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarViaje);
        }

        // POST: LugarViajes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lugarViajeId,Descripcion,NombreLugarViaje")] LugarViaje lugarViaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lugarViaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lugarViaje);
        }

        // GET: LugarViajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LugarViaje lugarViaje = db.LugarViajes.Find(id);
            if (lugarViaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarViaje);
        }

        // POST: LugarViajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LugarViaje lugarViaje = db.LugarViajes.Find(id);
            db.LugarViajes.Remove(lugarViaje);
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
