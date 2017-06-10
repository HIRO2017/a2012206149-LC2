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
    public class EncomiendasController : Controller
    {
        //private a12206149DbContext db = new a12206149DbContext();
        private readonly IUnityOfWork _UnityOfWork;


        public EncomiendasController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }
        // GET: Encomiendas
        public ActionResult Index()
        {
            return View(_UnityOfWork.Encomiendas.GetAll());
        }

        // GET: Encomiendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = _UnityOfWork.Encomiendas.Get(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            return View(encomienda);
        }

        // GET: Encomiendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Encomiendas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "encomiendaId,destino")] Encomienda encomienda)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(encomienda);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encomienda);
        }

        // GET: Encomiendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = _UnityOfWork.Encomiendas.Get(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            return View(encomienda);
        }

        // POST: Encomiendas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "encomiendaId,destino")] Encomienda encomienda)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(encomienda);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encomienda);
        }

        // GET: Encomiendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = _UnityOfWork.Encomiendas.Get(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            return View(encomienda);
        }

        // POST: Encomiendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Encomienda encomienda = _UnityOfWork.Encomiendas.Get(id);
           _UnityOfWork.Encomiendas.Remove(encomienda);
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
