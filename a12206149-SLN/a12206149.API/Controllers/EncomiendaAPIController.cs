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
    public class EncomiendaAPIController : ApiController
    {
        private a12206149DbContext db = new a12206149DbContext();

        // GET: api/EncomiendaAPI
        public IQueryable<Encomienda> GetEncomiendas()
        {
            return db.Encomiendas;
        }

        // GET: api/EncomiendaAPI/5
        [ResponseType(typeof(Encomienda))]
        public IHttpActionResult GetEncomienda(int id)
        {
            Encomienda encomienda = db.Encomiendas.Find(id);
            if (encomienda == null)
            {
                return NotFound();
            }

            return Ok(encomienda);
        }

        // PUT: api/EncomiendaAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEncomienda(int id, Encomienda encomienda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != encomienda.encomiendaId)
            {
                return BadRequest();
            }

            db.Entry(encomienda).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EncomiendaExists(id))
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

        // POST: api/EncomiendaAPI
        [ResponseType(typeof(Encomienda))]
        public IHttpActionResult PostEncomienda(Encomienda encomienda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Encomiendas.Add(encomienda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = encomienda.encomiendaId }, encomienda);
        }

        // DELETE: api/EncomiendaAPI/5
        [ResponseType(typeof(Encomienda))]
        public IHttpActionResult DeleteEncomienda(int id)
        {
            Encomienda encomienda = db.Encomiendas.Find(id);
            if (encomienda == null)
            {
                return NotFound();
            }

            db.Encomiendas.Remove(encomienda);
            db.SaveChanges();

            return Ok(encomienda);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EncomiendaExists(int id)
        {
            return db.Encomiendas.Count(e => e.encomiendaId == id) > 0;
        }
    }
}