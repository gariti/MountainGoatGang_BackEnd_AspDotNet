using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MountainGoatGang.Repository
{
    [Table("Hike")]
    public partial class Hike
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public IQueryable<Trail> Trails { get; set; }
    }
}