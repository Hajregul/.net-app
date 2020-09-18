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
    public class SobeController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        

               [HttpGet]
        [Route("api/Sobe/ZauzmiSobuIKrevet/{sobaID?}")]
        public int ZauzmiSobuIKrevet(int sobaID)
        {
            return db.esp_ZauzmiSobu(sobaID);

        }

        // GET: api/Sobe
        public List<AllSobe2_Result> GetSobes()
        {
            return db.AllSobe2().ToList();
        }

        // GET: api/Sobe/5
        [ResponseType(typeof(Sobe))]
        public IHttpActionResult GetSobe(int id)
        {
            Sobe sobe = db.Sobe.Find(id);
            if (sobe == null)
            {
                return NotFound();
            }

            return Ok(sobe);
        }

        // PUT: api/Sobe/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSobe(int id, Sobe sobe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sobe.SobaID)
            {
                return BadRequest();
            }

            db.Entry(sobe).State = EntityState.Modified;

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

     
    }
}