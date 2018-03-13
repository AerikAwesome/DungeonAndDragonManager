using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbCharacterClass
    {
        public int ClassId { get; set; }
        public DbClass Class { get; set; }
        public int CharacterId { get; set; }
        public DbCharacter Character { get; set; }
        public int? SubClassId { get; set; }
        public DbSubClass SubClass { get; set; }

        public byte Level { get; set; }
        public bool Primary { get; set; }
        public int SkillProficiencies { get; set; }
    }
}
