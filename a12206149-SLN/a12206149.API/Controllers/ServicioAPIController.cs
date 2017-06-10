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
    public class ServicioAPIController : ApiController
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: api/ServicioAPI
        public IQueryable<Servicio> GetServicios()
        {
            return db.Servicios;
        }

        // GET: api/ServicioAPI/5
        [ResponseType(typeof(Servicio))]
        public IHttpActionResult GetServicio(int id)
        {
            Servicio servicio = db.Servicios.Find(id);
            if (servicio == null)
            {
                return NotFound();
            }

            return Ok(servicio);
        }

        // PUT: api/ServicioAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutServicio(int id, Servicio servicio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != servicio.servicioId)
            {
                return BadRequest();
            }

            db.Entry(servicio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicioExists(id))
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

        // POST: api/ServicioAPI
        [ResponseType(typeof(Servicio))]
        public IHttpActionResult PostServicio(Servicio servicio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Servicios.Add(servicio);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = servicio.servicioId }, servicio);
        }

        // DELETE: api/ServicioAPI/5
        [ResponseType(typeof(Servicio))]
        public IHttpActionResult DeleteServicio(int id)
        {
            Servicio servicio = db.Servicios.Find(id);
            if (servicio == null)
            {
                return NotFound();
            }

            db.Servicios.Remove(servicio);
            db.SaveChanges();

            return Ok(servicio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServicioExists(int id)
        {
            return db.Servicios.Count(e => e.servicioId == id) > 0;
        }
    }
}