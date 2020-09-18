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
    public class OcjeneController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Ocjene
        [HttpGet]
        [Route("api/Ocjene/AllOcjene")]
        public List<AllOcjene_Result> AllOcjene()
        {
            return db.AllOcjene().ToList();
        }

        // GET: api/Ocjene/5
        [ResponseType(typeof(Ocjene))]
        public IHttpActionResult GetOcjene(int id)
        {
            Ocjene ocjene = db.Ocjene.Find(id);
            if (ocjene == null)
            {
                return NotFound();
            }

            return Ok(ocjene);
        }

        // PUT: api/Ocjene/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjene(int id, Ocjene ocjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjene.OcjenaID)
            {
                return BadRequest();
            }

            db.Entry(ocjene).State = EntityState.Modified;

            
                db.SaveChanges();
          
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Ocjene
        [ResponseType(typeof(Ocjene))]
        public IHttpActionResult PostOcjene(Ocjene ocjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ocjene.Add(ocjene);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjene.OcjenaID }, ocjene);
        }

     
    }
}