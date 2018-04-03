using MountainGoatGang_BackEnd_AspDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MountainGoatGang_BackEnd_AspDotNet
{
    public class MountainGoatGangRepository
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
    }
}