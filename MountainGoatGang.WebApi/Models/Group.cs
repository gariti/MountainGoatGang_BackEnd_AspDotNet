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
        public string UserId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public int GroupStatusId { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Hike> Hikes { get; set; }
    }
}