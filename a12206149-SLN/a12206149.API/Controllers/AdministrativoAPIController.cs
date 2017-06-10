using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using a12206149_ENT.Entities;
using a12206149_PER;

namespace a12206149.API.Controllers
{
    public class AdministrativoAPIController : ApiController
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: api/AdministrativoAPI
        public IQueryable<Administrativo> GetAdministrativos()
        {
            return db.Administrativos;
        }

        // GET: api/AdministrativoAPI/5
        [ResponseType(typeof(Administrativo))]
        public IHttpActionResult GetAdministrativo(int id)
        {
            Administrativo administrativo = db.Administrativos.Find(id);
            if (administrativo == null)
            {
                return NotFound();
            }

            return Ok(administrativo);
        }

        // PUT: api/AdministrativoAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAdministrativo(int id, Administrativo administrativo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != administrativo.administrativoId)
            {
                return BadRequest();
            }

            db.Entry(administrativo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministrativoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AdministrativoAPI
        [ResponseType(typeof(Administrativo))]
        public IHttpActionResult PostAdministrativo(Administrativo administrativo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Administrativos.Add(administrativo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = administrativo.administrativoId }, administrativo);
        }

        // DELETE: api/AdministrativoAPI/5
        [ResponseType(typeof(Administrativo))]
        public IHttpActionResult DeleteAdministrativo(int id)
        {
            Administrativo administrativo = db.Administrativos.Find(id);
            if (administrativo == null)
            {
                return NotFound();
            }

            db.Administrativos.Remove(administrativo);
            db.SaveChanges();

            return Ok(administrativo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdministrativoExists(int id)
        {
            return db.Administrativos.Count(e => e.administrativoId == id) > 0;
        }
    }
}