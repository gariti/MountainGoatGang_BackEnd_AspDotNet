using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MountainGoatGang.Repository
{
    [Table("Trail")]
    public partial class Trail
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public double DistanceKM { get; set; }

        public double ElevationInMeters { get; set; }

        public TrailDifficulty TrailDifficulty { get; set; }

        public IQueryable<GpsTrack> GpsTracks { get; set; }

        public Hike hike { get; set; }
    }

}