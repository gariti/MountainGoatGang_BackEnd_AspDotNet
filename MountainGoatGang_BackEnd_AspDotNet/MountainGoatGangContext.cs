using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using MountainGoatGang_BackEnd_AspDotNet.Entities;

namespace MountainGoatGang_BackEnd_AspDotNet
{
    public partial class MountainGoatGangContext : DbContext
    {
        public MountainGoatGangContext() : base("name=MountainGoatGangContext")
        {
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Hike> Hikes { get; set; }
        public virtual DbSet<Trail> Trails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>();
 
            modelBuilder.Entity<Hike>();

            modelBuilder.Entity<Trail>();

            modelBuilder.Entity<User>();


        }

    }
}