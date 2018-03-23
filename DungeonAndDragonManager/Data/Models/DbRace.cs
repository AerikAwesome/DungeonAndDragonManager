using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Models;
using Newtonsoft.Json.Linq;

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
        public string Plural { get; set; }
        public string Regex { get; set; }
        public string Description { get; set; }
        public string Trait { get; set; }

        public Size Size { get; set; }
        private string _languages { get; set; }
        [NotMapped]
        public List<string> Languages { get => _languages.Split(";;").ToList(); set => _languages = string.Join(";;", value); }

        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        
        public short BonusStrength { get; set; }
        public short BonusDexterity { get; set; }
        public short BonusConstitution { get; set; }
        public short BonusIntelligence { get; set; }
        public short BonusWisdom { get; set; }
        public short BonusCharisma { get; set; }

        public DbRace(){}

        public DbRace(DbSource source, string name, string plural, string regex, string description, string trait, Size size, string[] languages, string age, string height, string weight, short str, short dex, short con, short intl, short wis, short cha, ICollection<DbSubRace> subraces)
        {
            Source = source;
            Name = name;
            Plural = plural;
            Regex = regex;
            Description = description;
            Trait = trait;
            Size = size;
            Languages = languages.ToList();
            Age = age;
            Height = height;
            Weight = weight;
            BonusStrength = str;
            BonusDexterity = dex;
            BonusConstitution = con;
            BonusIntelligence = intl;
            BonusWisdom = wis;
            BonusCharisma = cha;
            SubRaces = subraces;
        }
    }
}
