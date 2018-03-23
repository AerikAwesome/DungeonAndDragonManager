using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbSubRace
    {
        [Key]
        public int Id { get; set; }
        public int RaceId { get; set; }
        public DbRace Race { get; set; }

        public int SourceId { get; set; }
        public DbSource Source { get; set; }

        public string Name { get; set; }
        public string Regex { get; set; }
        public string Description { get; set; }
        public string Trait { get; set; }
        private string _dmgresistances { get; set; }
        [NotMapped]
        public List<string> DamageResistances { get => _dmgresistances.Split(";;").ToList(); set => _dmgresistances = string.Join(";;", value); }

        public short BonusStrength { get; set; }
        public short BonusDexterity { get; set; }
        public short BonusConstitution { get; set; }
        public short BonusIntelligence { get; set; }
        public short BonusWisdom { get; set; }
        public short BonusCharisma { get; set; }

        public DbSubRace(){}

        public DbSubRace(DbSource source, string name, string regex, string description, string trait, string[] dmgresistances, short str, short dex, short con, short intl, short wis, short cha)
        {
            Source = source;
            Name = name;
            Regex = regex;
            Description = description;
            Trait = trait;
            DamageResistances = dmgresistances.ToList();
            BonusStrength = str;
            BonusDexterity = dex;
            BonusConstitution = con;
            BonusIntelligence = intl;
            BonusWisdom = wis;
            BonusCharisma = cha;
        }
    }
}
