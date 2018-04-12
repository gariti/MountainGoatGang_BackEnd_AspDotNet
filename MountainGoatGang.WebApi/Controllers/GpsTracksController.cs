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
    public class GpsTracksController : ApiController
    {
        private MountainGoatGangContext db = new MountainGoatGangContext();

        // GET: api/GpsTracks
        public IQueryable<GpsTrack> GetGpsTracks()
        {
            return db.GpsTracks;
        }

        // GET: api/GpsTracks/5
        [ResponseType(typeof(GpsTrack))]
        public IHttpActionResult GetGpsTrack(int id)
        {
            GpsTrack gpsTrack = db.GpsTracks.Find(id);
            if (gpsTrack == null)
            {
                return NotFound();
            }

            return Ok(gpsTrack);
        }

        // PUT: api/GpsTracks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGpsTrack(int id, GpsTrack gpsTrack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gpsTrack.Id)
            {
                return BadRequest();
            }

            db.Entry(gpsTrack).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GpsTrackExists(id))
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

        // POST: api/GpsTracks
        [ResponseType(typeof(GpsTrack))]
        public IHttpActionResult PostGpsTrack(GpsTrack gpsTrack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GpsTracks.Add(gpsTrack);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gpsTrack.Id }, gpsTrack);
        }

        // DELETE: api/GpsTracks/5
        [ResponseType(typeof(GpsTrack))]
        public IHttpActionResult DeleteGpsTrack(int id)
        {
            GpsTrack gpsTrack = db.GpsTracks.Find(id);
            if (gpsTrack == null)
            {
                return NotFound();
            }

            db.GpsTracks.Remove(gpsTrack);
            db.SaveChanges();

            return Ok(gpsTrack);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GpsTrackExists(int id)
        {
            return db.GpsTracks.Count(e => e.Id == id) > 0;
        }
    }
}