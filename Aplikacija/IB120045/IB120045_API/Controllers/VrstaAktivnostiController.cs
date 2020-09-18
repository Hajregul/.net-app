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
    public class VrstaAktivnostiController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/VrstaAktivnosti
        public List<AllVrstaAktivnosti1_Result> GetVrstaAktivnostis()
        {
            return db.AllVrstaAktivnosti1().ToList();
        }

        // GET: api/VrstaAktivnosti/5
        [ResponseType(typeof(VrstaAktivnosti))]
        public IHttpActionResult GetVrstaAktivnosti(int id)
        {
            VrstaAktivnosti vrstaAktivnosti = db.VrstaAktivnosti.Find(id);
            if (vrstaAktivnosti == null)
            {
                return NotFound();
            }

            return Ok(vrstaAktivnosti);
        }

        // PUT: api/VrstaAktivnosti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVrstaAktivnosti(int id, VrstaAktivnosti vrstaAktivnosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vrstaAktivnosti.VrstaAktivnostiID)
            {
                return BadRequest();
            }

            db.Entry(vrstaAktivnosti).State = EntityState.Modified;

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

        // POST: api/VrstaAktivnosti
        [ResponseType(typeof(VrstaAktivnosti))]
        public IHttpActionResult PostVrstaAktivnosti(VrstaAktivnosti vrstaAktivnosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VrstaAktivnosti.Add(vrstaAktivnosti);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vrstaAktivnosti.VrstaAktivnostiID }, vrstaAktivnosti);
        }

        // DELETE: api/VrstaAktivnosti/5
        [ResponseType(typeof(VrstaAktivnosti))]
        public IHttpActionResult DeleteVrstaAktivnosti(int id)
        {
            VrstaAktivnosti vrstaAktivnosti = db.VrstaAktivnosti.Find(id);
            if (vrstaAktivnosti == null)
            {
                return NotFound();
            }

            db.VrstaAktivnosti.Remove(vrstaAktivnosti);
            db.SaveChanges();

            return Ok(vrstaAktivnosti);
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