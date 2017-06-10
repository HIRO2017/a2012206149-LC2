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
    public class TransporteAPIController : ApiController
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: api/TransporteAPI
        public IQueryable<Transporte> GetTransportes()
        {
            return db.Transportes;
        }

        // GET: api/TransporteAPI/5
        [ResponseType(typeof(Transporte))]
        public IHttpActionResult GetTransporte(int id)
        {
            Transporte transporte = db.Transportes.Find(id);
            if (transporte == null)
            {
                return NotFound();
            }

            return Ok(transporte);
        }

        // PUT: api/TransporteAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTransporte(int id, Transporte transporte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transporte.transporteId)
            {
                return BadRequest();
            }

            db.Entry(transporte).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransporteExists(id))
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

        // POST: api/TransporteAPI
        [ResponseType(typeof(Transporte))]
        public IHttpActionResult PostTransporte(Transporte transporte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Transportes.Add(transporte);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = transporte.transporteId }, transporte);
        }

        // DELETE: api/TransporteAPI/5
        [ResponseType(typeof(Transporte))]
        public IHttpActionResult DeleteTransporte(int id)
        {
            Transporte transporte = db.Transportes.Find(id);
            if (transporte == null)
            {
                return NotFound();
            }

            db.Transportes.Remove(transporte);
            db.SaveChanges();

            return Ok(transporte);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TransporteExists(int id)
        {
            return db.Transportes.Count(e => e.transporteId == id) > 0;
        }
    }
}