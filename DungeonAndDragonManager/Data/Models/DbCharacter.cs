using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Models;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbCharacter
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public int PartyId { get; set; }
        public DbParty Party { get; set; }

        public ICollection<DbCharacterClass> Classes { get; set; }
        public int? RaceId { get; set; }
        public DbRace Race { get; set; }
        public int? SubRaceId { get; set; }
        public DbSubRace SubRace { get; set; }

        public string Name { get; set; }

        public byte BaseStrength { get; set; }
        public byte BaseDexterity { get; set; }
        public byte BaseConstitution { get; set; }
        public byte BaseIntelligence { get; set; }
        public byte BaseWisdom { get; set; }
        public byte BaseCharisma { get; set; }
        public int Experience { get; set; }
    }
}
