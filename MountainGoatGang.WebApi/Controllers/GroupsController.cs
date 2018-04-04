using System;
using System.Data.Entity;
using System.Web.Http;
using Marvin.JsonPatch;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
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

        public DbSet<Group> Get()
        {
           return _repository.GetAllGroups();
        }

        public Group Get(int id)
        {
                return _repository.GetGroup(id);
        }

        public void Post([FromBody] Group group)
        {
                var g = _groupFactory.CreateExpenseGroup(group);
                _repository.AddGroup(g);
        }

        public void Put(int id, [FromBody] Group group)
        {
                //map
                var g = _groupFactory.AddGroup(group);

                _repository.UpdateGroup(g);
        }

        public void Patch(int id,
            [FromBody]JsonPatchDocument<Group> groupJsonPatchDocument)
        {
                var group = _repository.GetGroup(id);

                //map
                var g = _groupFactory.AddGroup(group);

                groupJsonPatchDocument.ApplyTo(g);

                _repository.UpdateGroup(_groupFactory.AddGroup(g));

        }

        public void Delete(int id)
        {
            _repository.DeleteGroup(id);
        }
    }
}