using MountainGoatGang.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MountainGoatGang.Repository
{
    public class MountainGoatGangDBInitializer : DropCreateDatabaseIfModelChanges<MountainGoatGangContext>
    {
        protected override void Seed(MountainGoatGangContext context)
        {
            ICollection<User> defaultUsers = new List<User>();
            defaultUsers.Add(new User()
            {
                FirstName = "Garrett",
                LastName = "Carver",
                Email = "gariti@gmail.com"
            });
            defaultUsers.Add(new User()
            {
                FirstName = "Jenny",
                LastName = "Kunte",
                Email = "Jenny@gmail.com"
            });

            ICollection<GpsPoint> gpsPoints = new List<GpsPoint>();
            gpsPoints.Add(new GpsPoint
            {
                Elevation = 1,
                Lat = "1degNorth",
                Long = "2degE"
            });
            gpsPoints.Add(new GpsPoint
            {
                Elevation = 1,
                Lat = "2",
                Long = "4"
            });

            ICollection<GpsTrack> defaultGpsTracks = new List<GpsTrack>();
            defaultGpsTracks.Add(new GpsTrack()
            {
                Name = "Mt Hood hike track",
                GpsPoints = gpsPoints,

            });

            ICollection<Trail> defaultTrails = new List<Trail>();
            defaultTrails.Add(new Trail
            {
                Description = "hike around mt hood 50mi",
                TrailDifficulty = TrailDifficulty.CertainDeath,
                GpsTracks = defaultGpsTracks,
                ElevationInMeters = 1111111,
                DistanceKM = 88,
                Name = "Mt Hood Trail"

            });

            ICollection<Hike> defaultHikes = new List<Hike>();
            defaultHikes.Add(new Hike()
            {
                Name = " Fun hike to Mount Hood!",
                Description = "This will be a REALLY fun hike!",
                Date = DateTime.Now,
                Trails = defaultTrails

            });

            IList<Group> defaultGroups = new List<Group>();

            defaultGroups.Add(new Group()
            {
                Name = "MountainGoatGang",
                Description = "The first Mountain Goat Gang group!!",
                Id = 1,
                Users = (ICollection<User>) defaultUsers.First(),
                Hikes = defaultHikes
            });

            defaultGroups.Add(new Group()
            {
                Name = "MountainGoatGangDos",
                Description = "el segundo group",
                Id = 2,
                Users = (ICollection<User>)defaultUsers.Last(),
                Hikes = defaultHikes
            });

            context.Groups.AddRange(defaultGroups);

            base.Seed(context);
        }
    }
}