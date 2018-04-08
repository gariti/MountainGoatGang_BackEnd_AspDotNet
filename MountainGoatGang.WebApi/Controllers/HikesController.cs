using System;
using System.Linq;
using System.Data.Entity;
using System.Web.Http;
using Marvin.JsonPatch;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
    [RoutePrefix("api")]
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

        [Route("hikes")]
        public DbSet<Hike> Get()
        {
            return _repository.GetAllHikes();
        }

        [Route("groups/{GroupId}/hikes")]
        public IQueryable<Hike> Get(int groupId)
        {
            return _repository.GetHikesForGroupId(groupId);
        }

        [Route("expenses")]
        public void Post([FromBody] Hike hike)
        {
            var h = _hikeFactory.AddHike(hike);
            _repository.AddHike(h);
        }

        [Route("hikes/{id}")]
        public void Put(int id, [FromBody] Hike hike)
        {
            //map
            var h = _hikeFactory.AddHike(hike);

            _repository.UpdateHike(h);
        }

        [Route("hikes/{id}")]
        [HttpPatch]
        public void Patch(int id,
            [FromBody]JsonPatchDocument<Hike> hikeJsonPatchDocument)
        {
            var hike = _repository.GetHike(id);

            //map
            var h = _hikeFactory.AddHike(hike);

            hikeJsonPatchDocument.ApplyTo(h);

            _repository.UpdateHike(_hikeFactory.AddHike(h));

        }

        [Route("hikes/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteHike(id);
        }
    }
}