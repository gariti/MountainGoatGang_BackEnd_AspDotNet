using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MountainGoatGang.Repository
{
    public class MountainGoatGangRepository : IMountainGoatGangRepository
    {
        private MountainGoatGangContext _dbContext;

        public MountainGoatGangRepository(MountainGoatGangContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<Group> GetAllGroups()
        {
            return _dbContext.Groups;
        }

        public Group GetGroup(int id)
        {
            return _dbContext.Groups.FirstOrDefault(g => g.Id.Equals(id));
        }

        public DbSet<Hike> GetAllHikes()
        {
            return _dbContext.Hikes;
        }

        public Hike GetHike(int id)
        {
            return _dbContext.Hikes.FirstOrDefault(h => h.Id.Equals(id));
        }

        public DbSet<Trail> GetTrails()
        {
            return _dbContext.Trails;
        }

        public Trail GetTrail(int id)
        {
            return _dbContext.Trails.FirstOrDefault(t => t.Id.Equals(id));
        }

        public DbSet<User> GetUsers()
        {
            return _dbContext.Users;
        }

        public User GetUser(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(id));
        }

        public void AddGroup(Group g)
        {
            throw new NotImplementedException();
        }

        public void UpdateGroup(Group g)
        {
            throw new NotImplementedException();
        }

        public void DeleteGroup(int id)
        {
            throw new NotImplementedException();
        }

        public void AddHike(Hike h)
        {
            throw new NotImplementedException();
        }

        public void UpdateHike(Hike g)
        {
            throw new NotImplementedException();
        }

        public void DeleteHike(int id)
        {
            throw new NotImplementedException();
        }

        public DbSet<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public void AddUser(User u)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User h)
        {
            throw new NotImplementedException();
        }

        public DbSet<Trail> GetAllTrails()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrail(Trail h)
        {
            throw new NotImplementedException();
        }

        public void AddTrail(Trail t)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrail(int id)
        {
            throw new NotImplementedException();
        }
    }
}