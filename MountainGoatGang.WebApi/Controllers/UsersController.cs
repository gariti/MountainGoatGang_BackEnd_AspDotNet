using System;
using System.Data.Entity;
using System.Web.Http;
using Marvin.JsonPatch;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
    public class UsersController : ApiController
    {
        IMountainGoatGangRepository _repository;
        UserFactory _userFactory = new UserFactory();

        public UsersController()
        {
            _repository = new MountainGoatGangRepository(new
                MountainGoatGangContext());
        }
        public UsersController(IMountainGoatGangRepository repository)
        {
            _repository = repository;
        }

        public DbSet<User> Get()
        {
            return _repository.GetAllUsers();
        }

        public User Get(int id)
        {
            return _repository.GetUser(id);
        }

        public void Post([FromBody] User user)
        {
            var u = _userFactory.AddUser(user);
            _repository.AddUser(u);
        }

        public void Put(int id, [FromBody] User user)
        {
            //map
            var u = _userFactory.AddUser(user);

            _repository.UpdateUser(u);
        }

        public void Patch(int id,
            [FromBody]JsonPatchDocument<User> userJsonPatchDocument)
        {
            var user = _repository.GetUser(id);

            //map
            var u = _userFactory.AddUser(user);

            userJsonPatchDocument.ApplyTo(u);

            _repository.UpdateUser(_userFactory.AddUser(u));

        }

        public void Delete(int id)
        {
            _repository.DeleteUser(id);
        }
    }
}