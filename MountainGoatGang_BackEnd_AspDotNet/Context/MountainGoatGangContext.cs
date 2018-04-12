using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MountainGoatGang.Repository
{
    public partial class MountainGoatGangContext : DbContext
    {
        public MountainGoatGangContext() : base("name=MountainGoatGangContext")
        {
            Database.SetInitializer(new MountainGoatGangDBInitializer ());
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Hike> Hikes { get; set; }
        public virtual DbSet<Trail> Trails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<GpsTrack> GpsTracks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>();
 
            modelBuilder.Entity<Hike>();

            modelBuilder.Entity<Trail>();

            modelBuilder.Entity<User>();

            modelBuilder.Entity<GpsTrack>();

        }

    }
}