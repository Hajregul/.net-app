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
    public class SkrbnicisController : ApiController
    {
        private StarackiEntities db = new StarackiEntities();

        // GET: api/Skrbnicis
        public List<AllSkrbnici_Result> GetSkrbnicis()
        {
            return db.AllSkrbnici().ToList();
        }
        [HttpGet]
        [ResponseType(typeof(Skrbnici))]

        [Route("api/Skrbnicis/SkrbniciById")]
        public int SkrbniciById()
        {
            int skrbnik = db.skrbnikLastByID().FirstOrDefault().SkrbnikID;
            
            return skrbnik;
        }
        // GET: api/Skrbnicis/5
        [ResponseType(typeof(Skrbnici))]
        public IHttpActionResult GetSkrbnici(int id)
        {
            Skrbnici skrbnici = db.Skrbnici.Find(id);
            if (skrbnici == null)
            {
                return NotFound();
            }

            return Ok(skrbnici);
        }

        // PUT: api/Skrbnicis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSkrbnici(int id, Skrbnici skrbnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skrbnici.SkrbnikID)
            {
                return BadRequest();
            }

            db.Entry(skrbnici).State = EntityState.Modified;

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

        // POST: api/Skrbnicis
        [ResponseType(typeof(Skrbnici))]
        public IHttpActionResult PostSkrbnici(Skrbnici skrbnici)
        {
            try
            {
               db.SkrbnikInsert(skrbnici.Ime, skrbnici.Prezime, skrbnici.Adresa, skrbnici.Email, skrbnici.Telefon, skrbnici.SpolID, skrbnici.DatumRodjenja,skrbnici.Status);

            }
            catch (EntityException ex)
            {
               
                 throw ;
            }

            return CreatedAtRoute("DefaultApi", new { id = skrbnici.SkrbnikID }, skrbnici);
        }

      
    }
}