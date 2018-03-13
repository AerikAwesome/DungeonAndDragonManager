using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbClass
    {
        [Key]
        public int Id { get; set; }
        public int SourceId { get; set; }
        public DbSource Source { get; set; }

        public ICollection<DbSubClass> SubClasses { get; set; }

        public string Name { get; set; }
        public string Regex { get; set; }

        public byte PrimaryAbility { get; set; }
        public byte MinimumStrength { get; set; }
        public byte MinimumDexterity { get; set; }
        public byte MinimumConstitution { get; set; }
        public byte MinimumIntelligence { get; set; }
        public byte MinimumWisdom { get; set; }
        public byte MinimumCharisma { get; set; }
        public byte HitDie { get; set; }
        public int SaveProficiencies { get; set; }
        public int SkillProficiencies { get; set; }
    }
}
