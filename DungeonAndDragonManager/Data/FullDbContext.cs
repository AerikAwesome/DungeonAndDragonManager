using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DungeonAndDragonManager.Data
{
    public class FullDbContext : DbContext
    {
        public FullDbContext(DbContextOptions<FullDbContext> options) : base(options)  { }

        public DbSet<DbCampaign> Campaigns { get; set; }
        public DbSet<DbParty> Parties { get; set; }
        public DbSet<DbCharacter> Characters { get; set; }
        public DbSet<DbCharacterClass> CharacterClasses { get; set; }
        public DbSet<DbClass> Classes { get; set; }
        public DbSet<DbSubClass> SubClasses { get; set; }
        public DbSet<DbRace> Races { get; set; }
        public DbSet<DbSubRace> SubRaces { get; set; }
        public DbSet<DbSource> Sources { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<DbCharacterClass>().HasKey(c => new {c.CharacterId, c.ClassId});
            mb.Entity<DbSubClass>().HasOne(s => s.Class).WithMany(c => c.SubClasses).IsRequired().OnDelete(DeleteBehavior.Restrict);
            mb.Entity<DbSubRace>().HasOne(s => s.Race).WithMany(c => c.SubRaces).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
