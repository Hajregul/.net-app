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
    public class ZahtejviZaPrijavuUDomController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/ZahtejviZaPrijavuUDom
        [HttpGet]
        [Route("api/ZahtejviZaPrijavuUDom/GetZahtejviZaPrijavuUDoms")]
        public List<AllZahtjevi1_Result> GetZahtejviZaPrijavuUDoms()
        {
            return db.AllZahtjevi1().ToList();
        }

        // GET: api/ZahtejviZaPrijavuUDom/5
        [ResponseType(typeof(ZahtejviZaPrijavuUDom))]
        public IHttpActionResult GetZahtejviZaPrijavuUDom(int id)
        {
            ZahtejviZaPrijavuUDom zahtejviZaPrijavuUDom = db.ZahtejviZaPrijavuUDom.Find(id);
            if (zahtejviZaPrijavuUDom == null)
            {
                return NotFound();
            }

            return Ok(zahtejviZaPrijavuUDom);
        }
        
             [HttpGet]
        [Route("api/ZahtejviZaPrijavuUDom/OdobriPrijavuUDom/{zahtjevID}/{odobreno}")]
        public int OdobriPrijavuUDom(int zahtjevID, bool odobreno)
        {
            return db.OdobriPrijavuUDom(zahtjevID, odobreno);

        }
        [HttpGet]
        [Route("api/ZahtejviZaPrijavuUDom/ZahtjeviByParametri/{zahtjevID}/{korisnikID}/{pacijentID}")]
        public ZahtjeviByParametri1_Result ZahtjeviByParametri(int zahtjevID, int korisnikID, int pacijentID)
        {
          return  db.ZahtjeviByParametri1(zahtjevID,korisnikID,pacijentID).FirstOrDefault();
            
        }
        [HttpGet]
        [Route("api/ZahtejviZaPrijavuUDom/PregledOdobrenjaKorisnika/{id?}")]
        public OdobrenjeZahtjeva_Result PregledOdobrenjaKorisnika(int id)
        {
            return db.OdobrenjeZahtjeva(id).FirstOrDefault();
        }
        
               [HttpGet]
        [Route("api/ZahtejviZaPrijavuUDom/Odobreno/{id?}")]
        public ZahtjevOdobren_Result Odobreno(int id)
        {
            return db.ZahtjevOdobren(id).FirstOrDefault();
        }
        // PUT: api/ZahtejviZaPrijavuUDom/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZahtejviZaPrijavuUDom(int id, ZahtejviZaPrijavuUDom zahtejviZaPrijavuUDom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zahtejviZaPrijavuUDom.ZahtjevID)
            {
                return BadRequest();
            }

            db.Entry(zahtejviZaPrijavuUDom).State = EntityState.Modified;

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
        [HttpPost]
        // POST: api/ZahtejviZaPrijavuUDom
        [ResponseType(typeof(ZahtejviZaPrijavuUDom))]
        [HttpGet]
        public IHttpActionResult PostZahtejviZaPrijavuUDom(ZahtejviZaPrijavuUDom zahtejviZaPrijavuUDom)
        {
           
              db.InsertZahtejviZaPrijavuUDom(zahtejviZaPrijavuUDom.Odobreno, zahtejviZaPrijavuUDom.DatumPrijave, zahtejviZaPrijavuUDom.DatumOdobrenja, zahtejviZaPrijavuUDom.KorisnikID, zahtejviZaPrijavuUDom.PacijentID);

            return CreatedAtRoute("DefaultApi", new { id = zahtejviZaPrijavuUDom.ZahtjevID }, zahtejviZaPrijavuUDom);
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