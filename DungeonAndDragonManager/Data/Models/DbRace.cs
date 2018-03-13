using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbRace
    {
        [Key]
        public int Id { get; set; }
        public int SourceId { get; set; }
        public DbSource Source { get; set; }
        public ICollection<DbSubRace> SubRaces { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public short BonusStrength { get; set; }
        public short BonusDexterity { get; set; }
        public short BonusConstitution { get; set; }
        public short BonusIntelligence { get; set; }
        public short BonusWisdom { get; set; }
        public short BonusCharisma { get; set; }
    }
}
