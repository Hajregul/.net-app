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
    public class UlogeController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Uloge
        public List<AllUloge_Result> GetUloges()
        {
            return db.AllUloge().ToList();
        }


        // PUT: api/Uloge/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUloge(int id, Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uloge.UlogaID)
            {
                return BadRequest();
            }

            db.Entry(uloge).State = EntityState.Modified;

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

        // POST: api/Uloge
        [ResponseType(typeof(Uloge))]
        public IHttpActionResult PostUloge(Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uloge.Add(uloge);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uloge.UlogaID }, uloge);
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