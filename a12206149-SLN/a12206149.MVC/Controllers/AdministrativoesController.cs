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
    public class AdministrativoesController : Controller
    {
        //private a12206149DbContext db = new a12206149DbContext();

        private readonly IUnityOfWork _UnityOfWork;

       
        public AdministrativoesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Administrativoes
        public ActionResult Index()
        {
            return View(_UnityOfWork.Administrativos.GetAll());
        }

        // GET: Administrativoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = _UnityOfWork.Administrativos.Get(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // GET: Administrativoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrativoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "administrativoId,nombre,apellidos,celular,sexo")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Administrativos.Add(administrativo);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administrativo);
        }

        // GET: Administrativoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = _UnityOfWork.Administrativos.Get(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "administrativoId,nombre,apellidos,celular,sexo")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(administrativo);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administrativo);
        }

        // GET: Administrativoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = _UnityOfWork.Administrativos.Get(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administrativo administrativo = _UnityOfWork.Administrativos.Get(id);
            _UnityOfWork.Administrativos.Remove(administrativo);
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
