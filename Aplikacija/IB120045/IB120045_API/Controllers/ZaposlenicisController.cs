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
    public class ZaposlenicisController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Zaposlenicis
        public List<AllZaposlenici_Result> GetZaposlenicis()
        {
            return db.AllZaposlenici().ToList();
        }
        [HttpGet]
        [Route("api/Zaposlenicis/ZaposlenikByUserName/{username}")]
        public ZaposlenikByUserName_Result ZaposlenikByUserName(string username)
        {
            ZaposlenikByUserName_Result z = db.ZaposlenikByUserName(username).First();
            return z;
        }
        // GET: api/Zaposlenicis/5
        [ResponseType(typeof(Zaposlenici))]
        public IHttpActionResult GetZaposlenici(int id)
        {
            Zaposlenici zaposlenici = db.Zaposlenici.Find(id);
            if (zaposlenici == null)
            {
                return NotFound();
            }

            return Ok(zaposlenici);
        }

        // PUT: api/Zaposlenicis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZaposlenici(int id, Zaposlenici zaposlenici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zaposlenici.ZaposlenikID)
            {
                return BadRequest();
            }

            db.Entry(zaposlenici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZaposleniciExists(id))
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

        // POST: api/Zaposlenicis
        [ResponseType(typeof(Zaposlenici))]
        public IHttpActionResult PostZaposlenici(Zaposlenici zaposlenici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Zaposlenici.Add(zaposlenici);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zaposlenici.ZaposlenikID }, zaposlenici);
        }

        // DELETE: api/Zaposlenicis/5
        [ResponseType(typeof(Zaposlenici))]
        public IHttpActionResult DeleteZaposlenici(int id)
        {
            Zaposlenici zaposlenici = db.Zaposlenici.Find(id);
            if (zaposlenici == null)
            {
                return NotFound();
            }

            db.Zaposlenici.Remove(zaposlenici);
            db.SaveChanges();

            return Ok(zaposlenici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZaposleniciExists(int id)
        {
            return db.Zaposlenici.Count(e => e.ZaposlenikID == id) > 0;
        }
    }
}