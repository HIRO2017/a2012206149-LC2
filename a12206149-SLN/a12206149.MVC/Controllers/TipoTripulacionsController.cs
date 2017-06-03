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
    public class TipoTripulacionsController : Controller
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: TipoTripulacions
        public ActionResult Index()
        {
            return View(db.TipoTripulacions.ToList());
        }

        // GET: TipoTripulacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTripulacion tipoTripulacion = db.TipoTripulacions.Find(id);
            if (tipoTripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoTripulacion);
        }

        // GET: TipoTripulacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTripulacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoTripulacionId,nombreTipoTripulacion")] TipoTripulacion tipoTripulacion)
        {
            if (ModelState.IsValid)
            {
                db.TipoTripulacions.Add(tipoTripulacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTripulacion);
        }

        // GET: TipoTripulacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTripulacion tipoTripulacion = db.TipoTripulacions.Find(id);
            if (tipoTripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoTripulacion);
        }

        // POST: TipoTripulacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoTripulacionId,nombreTipoTripulacion")] TipoTripulacion tipoTripulacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoTripulacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTripulacion);
        }

        // GET: TipoTripulacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTripulacion tipoTripulacion = db.TipoTripulacions.Find(id);
            if (tipoTripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoTripulacion);
        }

        // POST: TipoTripulacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoTripulacion tipoTripulacion = db.TipoTripulacions.Find(id);
            db.TipoTripulacions.Remove(tipoTripulacion);
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
