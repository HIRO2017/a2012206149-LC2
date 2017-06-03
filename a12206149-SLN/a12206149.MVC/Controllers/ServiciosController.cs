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
using a12206149_PER.Repositories;

namespace a12206149.MVC.Controllers
{
    public class ServiciosController : Controller
    {
        //private a12206149DbContext db = new a12206149DbContext();

        //private UnityOfWork unityOfWork = UnityOfWork.Instance;

        private readonly UnityOfWork _UnityOfWOrk;
        private ServiciosController(UnityOfWork unityOfWork)
        {
            _UnityOfWOrk = unityOfWork;
        }

        // GET: Servicios
        public ActionResult Index()
        {
            //return View(db.Servicios.ToList());
            return View(_UnityOfWOrk.Servicios.GetAll());
        }

        // GET: Servicios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Servicio servicio = db.Servicios.Find(id);
            Servicio servicio = _UnityOfWOrk.Servicios.Get(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // GET: Servicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "servicioId,nombreServicio,tipoServicio")] Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                //db.Servicios.Add(servicio);
                _UnityOfWOrk.Servicios.Add(servicio);
                //db.SaveChanges();
                _UnityOfWOrk.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicio);
        }

        // GET: Servicios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Servicio servicio = db.Servicios.Find(id);
            Servicio servicio = _UnityOfWOrk.Servicios.Get(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // POST: Servicios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "servicioId,nombreServicio,tipoServicio")] Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(servicio).State = EntityState.Modified;
                _UnityOfWOrk.StateModified(servicio);
                //db.SaveChanges();
                _UnityOfWOrk.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicio);
        }

        // GET: Servicios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Servicio servicio = db.Servicios.Find(id);
            Servicio servicio = _UnityOfWOrk.Servicios.Get(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // POST: Servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // Servicio servicio = db.Servicios.Find(id);
            Servicio servicio = _UnityOfWOrk.Servicios.Get(id);
            //db.Servicios.Remove(servicio);
            _UnityOfWOrk.Servicios.Delete(servicio);
            //db.SaveChanges();
            _UnityOfWOrk.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                _UnityOfWOrk.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
