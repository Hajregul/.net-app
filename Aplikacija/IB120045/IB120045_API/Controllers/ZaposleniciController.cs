using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using IB120045_API.Models;

namespace IB120045_API.Controllers
{
    public class ZaposleniciController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Zaposlenici
        [HttpGet]
        [Route("api/Zaposlenici/ZaposlenikByUserName/{username}")]
        public ZaposlenikByUserName_Result ZaposlenikByUserName(string username)
        {
            return db.ZaposlenikByUserName(username).FirstOrDefault();
        }
        // GET: api/Zaposlenici/5


        // PUT: api/Zaposlenici/5
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
                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Zaposlenici
        [ResponseType(typeof(Zaposlenici))]
        public IHttpActionResult PostZaposlenici(Zaposlenici zaposlenici)
        {

            try
            {
                db.ZaposleniciInsertt(zaposlenici.Ime, zaposlenici.Prezime, zaposlenici.DatumRodjenja, zaposlenici.Adresa, zaposlenici.Email, zaposlenici.Telefon, zaposlenici.Spol, zaposlenici.Uloge_UlogaID, zaposlenici.Status, zaposlenici.KorisnickoIme, zaposlenici.LozinkaHash, zaposlenici.LozinkaSalt);

            }
            catch (EntityException ex)
            {
                throw;
                // throw new NotImplementedException();
            }
            return CreatedAtRoute("DefaultApi", new { id = zaposlenici.ZaposlenikID }, zaposlenici);
        }

        private Exception CreatedHttpResponseException(object p, HttpStatusCode conflict)
        {
            throw new NotImplementedException();
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