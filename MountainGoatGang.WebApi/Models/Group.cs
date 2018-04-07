using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MountainGoatGang.WebApi.Models
{
    public class Group
    {
        public Group()
        {

        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Hike> Hikes { get; set; }
    }
}