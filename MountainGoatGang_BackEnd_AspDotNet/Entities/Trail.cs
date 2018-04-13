using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MountainGoatGang.Repository
{
    public partial class Trail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double DistanceKM { get; set; }

        public double ElevationInMeters { get; set; }

        public TrailDifficulty TrailDifficulty { get; set; }

        public ICollection<GpsTrack> GpsTracks { get; set; }

        public Hike hike { get; set; }
    }

}