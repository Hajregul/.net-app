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
using IB120045_API.Models;

namespace IB120045_API.Controllers
{
    public class TerapijeController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Terapije
        public IQueryable<Terapije> GetTerapijes()
        {
            return db.Terapije;
        }

        // GET: api/Terapije/5
        [ResponseType(typeof(Terapije))]
        public IHttpActionResult GetTerapije(int id)
        {
            Terapije terapije = db.Terapije.Find(id);
            if (terapije == null)
            {
                return NotFound();
            }

            return Ok(terapije);
        }

        // PUT: api/Terapije/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTerapije(int id, Terapije terapije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != terapije.TerapijaID)
            {
                return BadRequest();
            }

            db.Entry(terapije).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Terapije
        [ResponseType(typeof(Terapije))]
        public IHttpActionResult PostTerapije(Terapije terapije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InserTerapije(terapije.Naziv,terapije.DatumPocetkaTerapije,terapije.DatumKrajaTerapije,terapije.Dijagnoze_DijagnozaID);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = terapije.TerapijaID }, terapije);
        }

  
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

     
    }
}