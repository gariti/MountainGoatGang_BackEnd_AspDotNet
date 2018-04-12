using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;

namespace MountainGoatGang.Repository
{
    [Table("Group")]
    public partial class Group
    {
        public Group()
        {

        }

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public virtual IQueryable<User> Users { get; set; }

        public virtual IQueryable<Hike> Hikes { get; set; }


    }
}