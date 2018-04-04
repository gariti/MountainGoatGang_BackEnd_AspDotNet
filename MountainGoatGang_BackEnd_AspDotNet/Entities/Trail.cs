using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public List<GpsPoint> GpsCoordinates { get; set; }

    }

    public enum TrailDifficulty { Easy, Medium, Difficult, Extreme, CertainDeath};
}