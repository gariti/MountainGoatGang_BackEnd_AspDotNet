using System;
using System.Data.Entity;
using System.Web.Http;
using Marvin.JsonPatch;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
    public class HikesController : ApiController
    {
        IMountainGoatGangRepository _repository;
        HikeFactory _hikeFactory = new HikeFactory();

        public HikesController()
        {
            _repository = new MountainGoatGangRepository(new
                MountainGoatGangContext());
        }
        public HikesController(IMountainGoatGangRepository repository)
        {
            _repository = repository;
        }

        public DbSet<Hike> Get()
        {
            return _repository.GetAllHikes();
        }

        public Hike Get(int id)
        {
            return _repository.GetHike(id);
        }

        public void Post([FromBody] Hike hike)
        {
            var h = _hikeFactory.AddHike(hike);
            _repository.AddHike(h);
        }

        public void Put(int id, [FromBody] Hike hike)
        {
            //map
            var h = _hikeFactory.AddHike(hike);

            _repository.UpdateHike(h);
        }

        public void Patch(int id,
            [FromBody]JsonPatchDocument<Hike> hikeJsonPatchDocument)
        {
            var hike = _repository.GetHike(id);

            //map
            var h = _hikeFactory.AddHike(hike);

            hikeJsonPatchDocument.ApplyTo(h);

            _repository.UpdateHike(_hikeFactory.AddHike(h));

        }

        public void Delete(int id)
        {
            _repository.DeleteHike(id);
        }
    }
}