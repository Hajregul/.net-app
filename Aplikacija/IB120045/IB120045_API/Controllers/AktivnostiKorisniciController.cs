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
    public class AktivnostiKorisniciController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/AktivnostiKorisnici
        public IQueryable<AktivnostiKorisnici> GetAktivnostiKorisnicis()
        {
            return db.AktivnostiKorisnici;
        }

        // GET: api/AktivnostiKorisnici/5
        [ResponseType(typeof(AktivnostiKorisnici))]
        public IHttpActionResult GetAktivnostiKorisnici(int id)
        {
            AktivnostiKorisnici aktivnostiKorisnici = db.AktivnostiKorisnici.Find(id);
            if (aktivnostiKorisnici == null)
            {
                return NotFound();
            }

            return Ok(aktivnostiKorisnici);
        }
        [HttpGet]
        [Route("api/AktivnostiKorisnici/AllKorisniciNaAktivnosti/{aktivnostID}")]
        public List<AllKorisniciNaAktivnosti_Result> AllKorisniciNaAktivnosti(int aktivnostID)
        {
            return db.AllKorisniciNaAktivnosti(aktivnostID).ToList();
        }

        [HttpGet]
    [Route("api/AktivnostiKorisnici/PrijavaNaAktivnost/{korisnikID}/{aktivnostID}")]
    public int PrijavaNaAktivnost(int korisnikID, int aktivnostID)
        {
            return db.PrijavaNaAktivnost(korisnikID, aktivnostID);

        }
        [HttpGet]
        [ResponseType(typeof(Aktovnosti))]
        [Route("api/AktivnostiKorisnici/OdobriAktivnost/{AktivnostiID?}")]
        public int OdobriAktivnost(int AktivnostiID)
        {
            return db.SetOdobriAktivnost2(AktivnostiID);
        }



        [HttpGet]
    [Route("api/AktivnostiKorisnici/ProvjeraPrijaveNaAktivnost/{korisnikID}/{aktivnostID}")]
    public ProvjeraPrijaveNaAktivnost_Result ProvjeraPrijaveNaAktivnost(int korisnikID, int aktivnostID)
        {
            return db.ProvjeraPrijaveNaAktivnost(korisnikID, aktivnostID).FirstOrDefault();

        }
        // PUT: api/AktivnostiKorisnici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAktivnostiKorisnici(int id, AktivnostiKorisnici aktivnostiKorisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aktivnostiKorisnici.AktivnostiKorisniciID)
            {
                return BadRequest();
            }

            db.Entry(aktivnostiKorisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AktivnostiKorisniciExists(id))
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

        // POST: api/AktivnostiKorisnici
        [ResponseType(typeof(AktivnostiKorisnici))]
        public IHttpActionResult PostAktivnostiKorisnici(AktivnostiKorisnici aktivnostiKorisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AktivnostiKorisnici.Add(aktivnostiKorisnici);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = aktivnostiKorisnici.AktivnostiKorisniciID }, aktivnostiKorisnici);
        }

    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AktivnostiKorisniciExists(int id)
        {
            return db.AktivnostiKorisnici.Count(e => e.AktivnostiKorisniciID == id) > 0;
        }
    }
}