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
    public class ClientesController : Controller
    {
        //private a12206149DbContext db = new a12206149DbContext();

        private readonly UnityOfWork _UnityOfWOrk;
        private ClientesController(UnityOfWork unityOfWork)
        {
            _UnityOfWOrk = unityOfWork;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            //return View(db.Clientes.ToList());
            return View(_UnityOfWOrk.Clientes.GetAll());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = _UnityOfWOrk.Clientes.Get(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "clienteId,Nombre,Apellidos,Direccion,numCel")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //db.Clientes.Add(cliente);
                _UnityOfWOrk.Clientes.Add(cliente);
                //db.SaveChanges();
                _UnityOfWOrk.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = _UnityOfWOrk.Clientes.Get(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "clienteId,Nombre,Apellidos,Direccion,numCel")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWOrk.StateModified(cliente);
                //db.SaveChanges();
                _UnityOfWOrk.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = _UnityOfWOrk.Clientes.Get(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = _UnityOfWOrk.Clientes.Get(id);
            //db.Clientes.Remove(cliente);
            _UnityOfWOrk.Clientes.Delete(cliente);
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
