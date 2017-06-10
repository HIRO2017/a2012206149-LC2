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
    public class TripulacionAPIController : ApiController
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: api/TripulacionAPI
        public IQueryable<Tripulacion> GetTripulaciones()
        {
            return db.Tripulaciones;
        }

        // GET: api/TripulacionAPI/5
        [ResponseType(typeof(Tripulacion))]
        public IHttpActionResult GetTripulacion(int id)
        {
            Tripulacion tripulacion = db.Tripulaciones.Find(id);
            if (tripulacion == null)
            {
                return NotFound();
            }

            return Ok(tripulacion);
        }

        // PUT: api/TripulacionAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTripulacion(int id, Tripulacion tripulacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tripulacion.tripulacionId)
            {
                return BadRequest();
            }

            db.Entry(tripulacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TripulacionExists(id))
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

        // POST: api/TripulacionAPI
        [ResponseType(typeof(Tripulacion))]
        public IHttpActionResult PostTripulacion(Tripulacion tripulacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tripulaciones.Add(tripulacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tripulacion.tripulacionId }, tripulacion);
        }

        // DELETE: api/TripulacionAPI/5
        [ResponseType(typeof(Tripulacion))]
        public IHttpActionResult DeleteTripulacion(int id)
        {
            Tripulacion tripulacion = db.Tripulaciones.Find(id);
            if (tripulacion == null)
            {
                return NotFound();
            }

            db.Tripulaciones.Remove(tripulacion);
            db.SaveChanges();

            return Ok(tripulacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TripulacionExists(int id)
        {
            return db.Tripulaciones.Count(e => e.tripulacionId == id) > 0;
        }
    }
}