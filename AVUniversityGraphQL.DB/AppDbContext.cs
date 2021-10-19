using AVUniversityGraphQL.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AVUniversityGraphQL.DB
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Campus>()
                .HasMany(c => c.Buildings)
                .WithOne(c => c.Campus!)
                .HasForeignKey(c => c.CampusId);

            modelBuilder
                .Entity<Building>()
                .HasOne(b => b.Campus)
                .WithMany(b => b.Buildings)
                .HasForeignKey(b => b.CampusId);


            modelBuilder
                .Entity<Building>()
                .HasMany(b => b.Rooms)
                .WithOne(b => b.Building!)
                .HasForeignKey(b => b.BuildingId);

            modelBuilder
                .Entity<Room>()
                .HasOne(r => r.Building)
                .WithMany(r => r.Rooms)
                .HasForeignKey(r => r.BuildingId);

                
        }
    }
}
