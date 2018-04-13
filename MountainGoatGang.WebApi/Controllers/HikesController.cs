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
using MountainGoatGang.Repository;

namespace MountainGoatGang.WebApi.Controllers
{
    public class HikesController : ApiController
    {
        private MountainGoatGangContext db = new MountainGoatGangContext();

        // GET: api/Hikes
        public IQueryable<Hike> GetHikes()
        {
            return db.Hikes;
        }

        // GET: api/Hikes/5
        [ResponseType(typeof(Hike))]
        public IHttpActionResult GetHike(int id)
        {
            Hike hike = db.Hikes.Find(id);
            if (hike == null)
            {
                return NotFound();
            }

            return Ok(hike);
        }

        // PUT: api/Hikes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHike(int id, Hike hike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hike.Id)
            {
                return BadRequest();
            }

            db.Entry(hike).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HikeExists(id))
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

        // POST: api/Hikes
        [ResponseType(typeof(Hike))]
        public IHttpActionResult PostHike(Hike hike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hikes.Add(hike);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hike.Id }, hike);
        }

        // DELETE: api/Hikes/5
        [ResponseType(typeof(Hike))]
        public IHttpActionResult DeleteHike(int id)
        {
            Hike hike = db.Hikes.Find(id);
            if (hike == null)
            {
                return NotFound();
            }

            db.Hikes.Remove(hike);
            db.SaveChanges();

            return Ok(hike);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HikeExists(int id)
        {
            return db.Hikes.Count(e => e.Id == id) > 0;
        }
    }
}