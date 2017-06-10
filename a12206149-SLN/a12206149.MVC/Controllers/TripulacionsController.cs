using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using a12206149_ENT.Entities;
using a12206149_PER;
using a12206149_ENT.IRepositories;

namespace a12206149.MVC.Controllers
{
    public class TripulacionsController : Controller
    {
        //private a12206149DbContext db = new a12206149DbContext();
        private readonly IUnityOfWork _UnityOfWork;


        public TripulacionsController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }
        // GET: Tripulacions
        public ActionResult Index()
        {
            return View(_UnityOfWork.Tripulaciones.GetAll());
        }

        // GET: Tripulacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = _UnityOfWork.Tripulaciones.Get(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // GET: Tripulacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tripulacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tripulacionId,nombre,tipo")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Tripulaciones.Add(tripulacion);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tripulacion);
        }

        // GET: Tripulacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = _UnityOfWork.Tripulaciones.Get(id);

            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // POST: Tripulacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tripulacionId,nombre,tipo")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(tripulacion);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tripulacion);
        }

        // GET: Tripulacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = _UnityOfWork.Tripulaciones.Get(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // POST: Tripulacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tripulacion tripulacion = _UnityOfWork.Tripulaciones.Get(id);

            _UnityOfWork.Tripulaciones.Remove(tripulacion);
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
