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
    public class PacijentiController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        

              [HttpGet]
        [ResponseType(typeof(Pacijenti))]

        [Route("api/Pacijenti/PacijentById")]
        public int PacijentById()
        {
            int pacijent = db.pacijentLastByID().FirstOrDefault().PacijentID;
            return pacijent;
        }
     
        // GET: api/Pacijenti
        public List<AllPacijenti_Result> GetPacijentis()
        {
            return db.AllPacijenti().ToList();
        }

        // GET: api/Pacijenti/5
        [ResponseType(typeof(Pacijenti))]
        public IHttpActionResult GetPacijenti(int id)
        {
            Pacijenti pacijenti = db.Pacijenti.Find(id);
            if (pacijenti == null)
            {
                return NotFound();
            }

            return Ok(pacijenti);
        }

        // PUT: api/Pacijenti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPacijenti(int id, Pacijenti pacijenti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pacijenti.PacijentID)
            {
                return BadRequest();
            }

            db.Entry(pacijenti).State = EntityState.Modified;


                db.SaveChanges();
          

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pacijenti
        [ResponseType(typeof(Pacijenti))]
        public IHttpActionResult PostPacijenti(Pacijenti pacijenti)
        {
            try
            {
                db.PacijentInsert(pacijenti.Ime,pacijenti.Prezime,pacijenti.DatumRodjenja, pacijenti.JMBG,pacijenti.DatumPrijave,pacijenti.Skrbnici_SkrbnikID,pacijenti.SpolID,pacijenti.Status,pacijenti.ZaposlenikID,pacijenti.SobaID);

            }
            catch {
                throw;
            }

            return CreatedAtRoute("DefaultApi", new { id = pacijenti.PacijentID }, pacijenti);
        }

        // DELETE: api/Pacijenti/5
        [ResponseType(typeof(Pacijenti))]
        public IHttpActionResult DeletePacijenti(int id)
        {
            Pacijenti pacijenti = db.Pacijenti.Find(id);
            if (pacijenti == null)
            {
                return NotFound();
            }

            db.Pacijenti.Remove(pacijenti);
            db.SaveChanges();

            return Ok(pacijenti);
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