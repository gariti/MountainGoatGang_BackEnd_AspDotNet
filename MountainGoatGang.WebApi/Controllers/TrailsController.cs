using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using Marvin.JsonPatch;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
    [RoutePrefix("api")]
    public class TrailsController : ApiController
    {
        IMountainGoatGangRepository _repository;
        TrailFactory _trailFactory = new TrailFactory();

        public TrailsController()
        {
            _repository = new MountainGoatGangRepository(new
                MountainGoatGangContext());
        }
        public TrailsController(IMountainGoatGangRepository repository)
        {
            _repository = repository;
        }

        [Route("trails")]
        public DbSet<Trail> Get()
        {
            return _repository.GetAllTrails();
        }

        [Route("hikes/{HikeId}/trails")]
        public ICollection<Trail> Get(int id)
        {
            return _repository.GetTrailsForHikeId(id);
        }

        [Route("trails")]
        public void Post([FromBody] Trail trail)
        {
            var t = _trailFactory.AddTrail(trail);
            _repository.AddTrail(t);
        }

        [Route("trails/{id}")]
        public void Put(int id, [FromBody] Trail trail)
        {
            //map
            var t = _trailFactory.AddTrail(trail);

            _repository.UpdateTrail(t);
        }

        [Route("trails/{id}")]
        [HttpPatch]
        public void Patch(int id,
            [FromBody]JsonPatchDocument<Trail> trailJsonPatchDocument)
        {
            var trail = _repository.GetTrail(id);

            //map
            var h = _trailFactory.AddTrail(trail);

            trailJsonPatchDocument.ApplyTo(h);

            _repository.UpdateTrail(_trailFactory.AddTrail(h));

        }

        [Route("trails/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteTrail(id);
        }
    }
}