using System;
using System.Collections.Generic;
using System.Linq;
using MountainGoatGang.Repository;

namespace MountainGoatGang
{
    public class GroupFactory
    {
        public GroupFactory()
        {

        }

        public Group CreateGroup(Group Group)
        {
            return new Group()
            {
                Description = Group.Description,
                StatusId = Group.StatusId,
                Id = Group.Id,
                Users = Group.Users,
                Hikes = Group.Hikes
            };
        }
    }
}