using System;
using System.Data.Entity;
using System.Web.Http;
using Marvin.JsonPatch;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
    [RoutePrefix("api")]
    public class GroupsController : ApiController
    {
        IMountainGoatGangRepository _repository;
        GroupFactory _groupFactory = new GroupFactory();

        public GroupsController()
        {
            _repository = new MountainGoatGangRepository(new
                MountainGoatGangContext());
        }
        public GroupsController(IMountainGoatGangRepository repository)
        {
            _repository = repository;
        }

        [Route("groups")]
        public DbSet<Group> Get()
        {
           return _repository.GetAllGroups();
        }

        [Route("groups/{GroupId}")]
        public Group Get(int id)
        {
                return _repository.GetGroup(id);
        }

        [Route("groups")]
        public void Post([FromBody] Group group)
        {
                var g = _groupFactory.CreateGroup(group);
                _repository.AddGroup(g);
        }

        [Route("groups/{id}")]
        public void Put(int id, [FromBody] Group group)
        {
                var g = _groupFactory.CreateGroup(group);

                _repository.UpdateGroup(g);
        }

        [Route("groups/{id}")]
        [HttpPatch]
        public void Patch(int id,
            [FromBody]JsonPatchDocument<Group> groupJsonPatchDocument)
        {
                var group = _repository.GetGroup(id);

                //map
                var g = _groupFactory.AddGroup(group);

                groupJsonPatchDocument.ApplyTo(g);

                _repository.UpdateGroup(_groupFactory.AddGroup(g));
        }

        [Route("groups/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteGroup(id);
        }
    }
}