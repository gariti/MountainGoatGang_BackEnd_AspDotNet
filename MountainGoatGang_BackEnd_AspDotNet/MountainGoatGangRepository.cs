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

    }
}