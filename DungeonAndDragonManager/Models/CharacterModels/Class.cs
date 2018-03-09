using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Regex Search { get; set; }
        public string Source { get; set; }
        public AbilityEnum PrimaryAbility { get; set; }
        public AbilityList Prerequisites { get; set; }
        public Die HitDie { get; set; }
        public ICollection<AbilityEnum> Saves { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
