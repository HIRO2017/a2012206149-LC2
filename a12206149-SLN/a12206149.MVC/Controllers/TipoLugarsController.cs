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
    public class TipoLugarsController : Controller
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: TipoLugars
        public ActionResult Index()
        {
            return View(db.TipoLugars.ToList());
        }

        // GET: TipoLugars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLugar tipoLugar = db.TipoLugars.Find(id);
            if (tipoLugar == null)
            {
                return HttpNotFound();
            }
            return View(tipoLugar);
        }

        // GET: TipoLugars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoLugars/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tipoLugarId,nombreTipoLugar")] TipoLugar tipoLugar)
        {
            if (ModelState.IsValid)
            {
                db.TipoLugars.Add(tipoLugar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoLugar);
        }

        // GET: TipoLugars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLugar tipoLugar = db.TipoLugars.Find(id);
            if (tipoLugar == null)
            {
                return HttpNotFound();
            }
            return View(tipoLugar);
        }

        // POST: TipoLugars/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tipoLugarId,nombreTipoLugar")] TipoLugar tipoLugar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoLugar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoLugar);
        }

        // GET: TipoLugars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLugar tipoLugar = db.TipoLugars.Find(id);
            if (tipoLugar == null)
            {
                return HttpNotFound();
            }
            return View(tipoLugar);
        }

        // POST: TipoLugars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoLugar tipoLugar = db.TipoLugars.Find(id);
            db.TipoLugars.Remove(tipoLugar);
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
