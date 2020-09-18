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
    public class KorisniciController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();


        [HttpGet]
        [ResponseType(typeof(Korisnici))]

        [Route("api/Korisnici/KorisniciById")]
        public int KorisniciById()
        {
            int koriskik = db.korisnikLastByID().FirstOrDefault().KorisnikID;
            return koriskik;
        }

        // GET: api/Korisnici
        public IQueryable<Korisnici> GetKorisnicis()
        {
            return db.Korisnici;
        }
        [HttpGet]
        [Route("api/Korisnici/ZahtjeviKorisnikaZaRegistraciju")]
        public List<esp_ZahtjeviKorisnikaZaRegistraciju_Result> ZahtjeviKorisnikaZaRegistraciju()
        {
            return db.esp_ZahtjeviKorisnikaZaRegistraciju().ToList();

        }
        [HttpGet]
        [Route("api/Korisnici/OdobrenjeRegistracije/{korisnikID?}")]
        public int OdobrenjeRegistracije(int korisnikID )
        {
            return db.esp_OdobrenjeRegistracije(korisnikID);

        }

        
        [HttpGet]
        [Route("api/Korisnici/PregledKorisnikaDomaALL")]
        public List<esp_PregledKorisnikaDomaALL_Result> PregledKorisnikaDomaALL()
        {
            return db.esp_PregledKorisnikaDomaALL().ToList();

        }
        [HttpGet]
        [Route("api/Korisnici/KorisnikByKorisnickoImeStatus/{name?}")]
        public KorisnikByKorisnickoImeStatusPrijava_Result KorisnikByKorisnickoImeStatus(string name = "")
        {
            return db.KorisnikByKorisnickoImeStatusPrijava(name).FirstOrDefault();

        }
        
             [HttpGet]
        [Route("api/Korisnici/Search/{jmbg}/{kime}")]
        public List<esp_PregledKorisnikaDoma_Result> Search(string jmbg,string kime )
        {
           
            return db.esp_PregledKorisnikaDoma(jmbg,kime).ToList();

        }
        // GET: api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult GetKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        // PUT: api/Korisnici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnici.KorisnikID)
            {
                return BadRequest();
            }

            db.Entry(korisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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

        // POST: api/Korisnici
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult PostKorisnici(Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            db.KorisniciInsert1(korisnici.Ime,korisnici.Prezime,korisnici.Grad,korisnici.Mail,korisnici.KorisnickoIme,korisnici.LozinkaSlt,korisnici.LozinkaHash,korisnici.DatumRegistracije,korisnici.StatusPrijave);

            return CreatedAtRoute("DefaultApi", new { id = korisnici.KorisnikID }, korisnici);
        }

        // DELETE: api/Korisnici/5
    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisniciExists(int id)
        {
            return db.Korisnici.Count(e => e.KorisnikID == id) > 0;
        }
    }
}