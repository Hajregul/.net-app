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
    public class PreglediController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Pregledi
        public List<esp_AllPregledi1_Result> GetPregledis()
        {
            return db.esp_AllPregledi1().ToList();
        }
        
              [HttpGet]
        [ResponseType(typeof(Pregledi))]

        [Route("api/Pregledi/PregledByPregledID/{pregledID}")]
        public esp_PregledByID_Result PregledByPregledID(int pregledID)
        {
            return db.esp_PregledByID(pregledID).FirstOrDefault();
        }

        [HttpGet]
        [ResponseType(typeof(Pregledi))]

        [Route("api/Pregledi/PregledByPacijentID/{pacijentID}")]
        public List<esp_PregledByPacijentID_Result> PregledByPacijentID(int pacijentID)
        {
            return db.esp_PregledByPacijentID(pacijentID).ToList();
        }

        [HttpGet]
        [ResponseType(typeof(Pregledi))]

        [Route("api/Pregledi/LastPregled")]
        public int LastPregled()
        {
            int pregled = db.LastPregled1().FirstOrDefault().PregledID;
            return pregled;
        }

        // GET: api/Pregledi/5
        [ResponseType(typeof(Pregledi))]
        public IHttpActionResult GetPregledi(int id)
        {
            Pregledi pregledi = db.Pregledi.Find(id);
            if (pregledi == null)
            {
                return NotFound();
            }

            return Ok(pregledi);
        }

        // PUT: api/Pregledi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPregledi(int id, Pregledi pregledi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pregledi.PregledID)
            {
                return BadRequest();
            }

            db.Entry(pregledi).State = EntityState.Modified;

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

        // POST: api/Pregledi
        [HttpPost]
        [ResponseType(typeof(Pregledi))]
        public IHttpActionResult PostPregledi(Pregledi pregledi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InserPregledi1(pregledi.DatumPregleda,pregledi.Tezina,pregledi.Visina,pregledi.Tlak,pregledi.Secer,pregledi.Opis,pregledi.Zaposlenici_ZaposlenikID,pregledi.Pacijenti_PacijentID);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pregledi.PregledID }, pregledi);
        }

    
    }
}