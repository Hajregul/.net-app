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
    public class DijagnozeController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();


              [HttpGet]
        [ResponseType(typeof(Dijagnoze))]

        [Route("api/Dijagnoze/LastDijagnoza")]
        public int LastDijagnoza()
        {
            int dijagnoza = db.LastDijagnoze1().FirstOrDefault().DijagnozaID;
            return dijagnoza;
        }
        // GET: api/Dijagnoze
        public IQueryable<Dijagnoze> GetDijagnozes()
        {
            return db.Dijagnoze;
        }

        // GET: api/Dijagnoze/5
        [ResponseType(typeof(Dijagnoze))]
        public IHttpActionResult GetDijagnoze(int id)
        {
            Dijagnoze dijagnoze = db.Dijagnoze.Find(id);
            if (dijagnoze == null)
            {
                return NotFound();
            }

            return Ok(dijagnoze);
        }

        // PUT: api/Dijagnoze/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDijagnoze(int id, Dijagnoze dijagnoze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dijagnoze.DijagnozaID)
            {
                return BadRequest();
            }

            db.Entry(dijagnoze).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DijagnozeExists(id))
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
        [HttpPost]
        // POST: api/Dijagnoze
        [ResponseType(typeof(Dijagnoze))]
        public IHttpActionResult PostDijagnoze(Dijagnoze dijagnoze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InserDijagnoza(dijagnoze.Naziv,dijagnoze.Opis,dijagnoze.Pregledi_PregledID);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dijagnoze.DijagnozaID }, dijagnoze);
        }

   
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DijagnozeExists(int id)
        {
            return db.Dijagnoze.Count(e => e.DijagnozaID == id) > 0;
        }
    }
}