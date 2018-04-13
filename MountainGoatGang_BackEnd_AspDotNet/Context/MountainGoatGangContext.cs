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
            //group has many to many relationship with users & hikes
            modelBuilder.Entity<Group>()
                .HasMany(g => g.Users).WithMany();

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Hikes).WithMany();

            //Hike has many to many relationship with trails
            modelBuilder.Entity<Hike>()
                .HasMany(h => h.Trails).WithMany();


            modelBuilder.Entity<User>();

            modelBuilder.Entity<Trail>()
                .HasOptional(t => t.GpsTracks);

            modelBuilder.Entity<GpsTrack>();

        }
    }
}