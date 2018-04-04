using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MountainGoatGang.Repository
{
    [Table("Group")]
    public partial class Group
    {
        public Group()
        {

        }

        [Required]
        [StringLength(100)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string GroupName { get; set; }

        [Required]
        [StringLength(1000)]
        public string GroupDescription { get; set; }

        public int GroupStatusId { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Hike> Hikes { get; set; }


    }
}