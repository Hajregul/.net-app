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
    public class AktivnostiKomentarisController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/AktivnostiKomentaris
        public IQueryable<AktivnostiKomentari> GetAktivnostiKomentaris()
        {
            return db.AktivnostiKomentari;
        }

        // GET: api/AktivnostiKomentaris/5
        [ResponseType(typeof(AktivnostiKomentari))]
        public IHttpActionResult GetAktivnostiKomentari(int id)
        {
            AktivnostiKomentari aktivnostiKomentari = db.AktivnostiKomentari.Find(id);
            if (aktivnostiKomentari == null)
            {
                return NotFound();
            }

            return Ok(aktivnostiKomentari);
        }

        // PUT: api/AktivnostiKomentaris/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAktivnostiKomentari(int id, AktivnostiKomentari aktivnostiKomentari)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aktivnostiKomentari.AktivnostiKomentariID)
            {
                return BadRequest();
            }

            db.Entry(aktivnostiKomentari).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AktivnostiKomentariExists(id))
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

        // POST: api/AktivnostiKomentaris
        [ResponseType(typeof(AktivnostiKomentari))]
        public IHttpActionResult PostAktivnostiKomentari(AktivnostiKomentari aktivnostiKomentari)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertAktivnostiKomentar(aktivnostiKomentari.Komentar,aktivnostiKomentari.KorisnikID,aktivnostiKomentari.AktivnostID,aktivnostiKomentari.DatumKomentiranja);

            return CreatedAtRoute("DefaultApi", new { id = aktivnostiKomentari.AktivnostiKomentariID }, aktivnostiKomentari);
        }

        // DELETE: api/AktivnostiKomentaris/5
        [ResponseType(typeof(AktivnostiKomentari))]
        public IHttpActionResult DeleteAktivnostiKomentari(int id)
        {
            AktivnostiKomentari aktivnostiKomentari = db.AktivnostiKomentari.Find(id);
            if (aktivnostiKomentari == null)
            {
                return NotFound();
            }

            db.AktivnostiKomentari.Remove(aktivnostiKomentari);
            db.SaveChanges();

            return Ok(aktivnostiKomentari);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AktivnostiKomentariExists(int id)
        {
            return db.AktivnostiKomentari.Count(e => e.AktivnostiKomentariID == id) > 0;
        }
    }
}