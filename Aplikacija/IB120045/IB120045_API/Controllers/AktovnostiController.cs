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
using IB120045_API.Util;

namespace IB120045_API.Controllers
{
    public class AktovnostiController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        public List<AllAktivnostii_Result> GetAktivnosti()
        {
            return db.AllAktivnostii().ToList();
        }


        [HttpGet]
        [ResponseType(typeof(Aktovnosti))]

        [Route("api/Aktovnosti/Preporuceno/{aktivnostID}")]
        public List<PreporucenoById_Result> Preporuceno(int aktivnostID)
        {
            Preporuceno p = new Preporuceno();
            return p.GetSlicneAktivnosti(aktivnostID);
        }


        [HttpGet]
        [ResponseType(typeof(Aktovnosti))]

        [Route("api/Aktovnosti/AllAktivnosti")]
        // GET: api/Aktovnosti
        public List<AllAktivnostii_Result> AllAktivnosti()
        {
            return db.AllAktivnostii().ToList();
        }

        
             [HttpGet]
        [ResponseType(typeof(Aktovnosti))]

        [Route("api/Aktovnosti/GetAktivnostById/{aktivnostID}")]
        public AktivnostById_Result GetAktivnostById(int aktivnostID)
        {
            AktivnostById_Result ak = db.AktivnostById(aktivnostID).FirstOrDefault();
            return ak;
        }

               [HttpGet]
    [Route("api/Aktovnosti/Select_ByVrstaNazivAktivnosti/{vrstaID}/{naziv}")]
    public List<test_Result> Select_ByVrstaNazivAktivnosti(int vrstaID, string naziv)
        {
            return db.test(vrstaID,naziv).ToList();

        }
        [HttpGet]
    [Route("api/Aktovnosti/Select_ByVrstaAktivnosti/{vrstaID}")]
    public List<Select_ByVrstaAktivnosti_Result> Select_ByVrstaAktivnosti(int vrstaID)
    {
        return db.Select_ByVrstaAktivnosti(vrstaID).ToList();

    }
    [HttpGet]
        [Route("api/Aktovnosti/SearchByNaziv/{naziv}")]
        public List<SearchByNaziv_Result> SearchByNaziv(string naziv)
        {
            return db.SearchByNaziv(naziv).ToList();
        }
        [HttpGet]
        [Route("api/Aktovnosti/ListaAktivnosti")]
        public List<esp_ListaAktivnosti_Result> ListaAktivnosti()
        {
            return db.esp_ListaAktivnosti().ToList();
        }
       
        // GET: api/Aktovnosti/5
        [ResponseType(typeof(Aktovnosti))]
        public IHttpActionResult GetAktovnosti(int id)
        {
            Aktovnosti aktovnosti = db.Aktovnosti.Find(id);
            if (aktovnosti == null)
            {
                return NotFound();
            }

            return Ok(aktovnosti);
        }

        // PUT: api/Aktovnosti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAktovnosti(int id, Aktovnosti aktovnosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aktovnosti.AktivnostID)
            {
                return BadRequest();
            }

            db.esp_Aktivnosti_Update2(id,aktovnosti.Naziv,aktovnosti.Ogranicenja, aktovnosti.Datum,aktovnosti.VrstaAktivnostiID,aktovnosti.VrijemeAktivnosti,aktovnosti.Stalna,aktovnosti.Slika,aktovnosti.SlikaThumb,aktovnosti.ZaposlenikID);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AktovnostiExists(id))
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

        // POST: api/Aktovnosti
        [ResponseType(typeof(Aktovnosti))]
        public IHttpActionResult PostAktovnosti(Aktovnosti aktovnosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Aktovnosti.Add(aktovnosti);
            db.SaveChanges();
       

            return CreatedAtRoute("DefaultApi", new { id = aktovnosti.AktivnostID }, aktovnosti);
        }

        // DELETE: api/Aktovnosti/5
        [Route("api/Aktovnosti/DeleteAktovnosti/{id}")]
        [ResponseType(typeof(Aktovnosti))]
        public IHttpActionResult DeleteAktovnosti(int id)
        {
            Aktovnosti a = new Aktovnosti();
            if (a == null)
            {
                return NotFound();
            }
            db.esp_AktivnostiKomentari_del(id);
            db.esp_AktivnostiKorisnici_del(id);
            db.esp_AktivnostiOcjene_del(id);
            db.esp_Aktivnosti_del(id);
            

            return Ok(a);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AktovnostiExists(int id)
        {
            return db.Aktovnosti.Count(e => e.AktivnostID == id) > 0;
        }

        [HttpPost]
        [Route("api/Aktovnosti/Update/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Update(int id, Aktovnosti p)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != p.AktivnostID)
                return BadRequest();

         //   db.esp_Aktivnosti_Update(p.AktivnostID, p.Naziv,p.Ogranicenja,p.Datum,p.VrstaAktivnostiID,p.VrijemeAktivnosti,
         //       p.Stalna,p.Slika,p.SlikaThumb,p.PrijavaNaAktivnost,p.OdobrenjePrijaveNaAktivnost,p.ZaposlenikID);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}