using System;
using System.Data.Entity;
using System.Web.Http;
using Marvin.JsonPatch;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
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

        public DbSet<Trail> Get()
        {
            return _repository.GetAllTrails();
        }

        public Trail Get(int id)
        {
            return _repository.GetTrail(id);
        }

        public void Post([FromBody] Trail trail)
        {
            var t = _trailFactory.AddTrail(trail);
            _repository.AddTrail(t);
        }

        public void Put(int id, [FromBody] Trail trail)
        {
            //map
            var t = _trailFactory.AddTrail(trail);

            _repository.UpdateTrail(t);
        }

        public void Patch(int id,
            [FromBody]JsonPatchDocument<Trail> trailJsonPatchDocument)
        {
            var trail = _repository.GetTrail(id);

            //map
            var h = _trailFactory.AddTrail(trail);

            trailJsonPatchDocument.ApplyTo(h);

            _repository.UpdateTrail(_trailFactory.AddTrail(h));

        }

        public void Delete(int id)
        {
            _repository.DeleteTrail(id);
        }
    }
}