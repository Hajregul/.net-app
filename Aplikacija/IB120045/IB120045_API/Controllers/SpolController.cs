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
    public class SpolController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Spol
        public List<AllSpol_Result> GetSpols()
        {
            return db.AllSpol().ToList();
        }

        // GET: api/Spol/5
        [ResponseType(typeof(Spol))]
        public IHttpActionResult GetSpol(int id)
        {
            Spol spol = db.Spol.Find(id);
            if (spol == null)
            {
                return NotFound();
            }

            return Ok(spol);
        }

        // PUT: api/Spol/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSpol(int id, Spol spol)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != spol.SpolID)
            {
                return BadRequest();
            }

            db.Entry(spol).State = EntityState.Modified;

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