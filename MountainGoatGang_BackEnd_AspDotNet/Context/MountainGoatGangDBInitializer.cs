using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MountainGoatGang.Repository
{
    public class MountainGoatGangDBInitializer : DropCreateDatabaseAlways<MountainGoatGangContext>
    {
        protected override void Seed(MountainGoatGangContext context)
        {
            ICollection<User> defaultUsers = new List<User>();
            defaultUsers.Add(new User()
            {
                Id = 1,
                FirstName = "Garrett",
                LastName = "Carver",
                Email = "gariti@gmail.com"
            });
            defaultUsers.Add(new User()
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Kunte",
                Email = "Jenny@gmail.com"
            });

            ICollection<GpsTrack> defaultGpsTracks = new List<GpsTrack>();
            defaultGpsTracks.Add(new GpsTrack()
            {
                Id = 1,
                Name = "Mt Hood hike track",
                GpsDataFile = ",,,,",
                GpsDataFormat = GpsDataFormat.KML
            });

            ICollection<Trail> defaultTrails = new List<Trail>();
            defaultTrails.Add(new Trail
            {
                Id = 1,
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
                Id = 1,
                Name = " Fun hike to Mount Hood!",
                Description = "This will be a REALLY fun hike!",
                Date = DateTime.Now,
                Trails = defaultTrails
            });

            IList<Group> defaultGroups = new List<Group>();

            defaultGroups.Add(new Group()
            {
                Id = 1,
                Name = "MountainGoatGang",
                Description = "The first Mountain Goat Gang group!!",
                Users = defaultUsers,
                Hikes = defaultHikes
            });

            defaultGroups.Add(new Group()
            {
                Id = 2,
                Name = "MountainGoatGangDos",
                Description = "El segundo group",
                Users = defaultUsers,
                Hikes = defaultHikes
            });

            context.Users.AddRange(defaultUsers);
            context.GpsTracks.AddRange(defaultGpsTracks);
            context.Trails.AddRange(defaultTrails);
            context.Hikes.AddRange(defaultHikes);
            context.Groups.AddRange(defaultGroups);

            base.Seed(context);
            context.SaveChanges();
        }
    }
}