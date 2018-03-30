using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Models.CharacterModels;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbBackground
    {
        [Key]
        public int Id { get; set; }
        public int SourceId { get; set; }
        public DbSource Source { get; set; }

        public string Name { get; set; }
        public string Regex { get; set; }
        public SkillEnum SkillChoices { get; set; }
        public int SkillNumber { get; set; }
        public int Gold { get; set; }
        //TODO all properties
    }
}
