using DungeonAndDragonManager.Models.CharacterModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CharacterClass> Classes { get; set; }
        public virtual Race Race { get; set; }
        public virtual SubRace SubRace { get; set; }
        public AbilityList Abilities { get; set; }
        public SkillList Skills { get; set; }
    }
}
