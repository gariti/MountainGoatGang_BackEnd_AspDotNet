using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MountainGoatGang_BackEnd_AspDotNet.Entities
{
    [Table("Group")]
    public partial class Group
    {
        public Group()
        {

        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UserId { get; set; }

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