using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DungeonAndDragonManager.Models.CharacterModels;

namespace DungeonAndDragonManager.Models
{
    public class Campaign
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser DungeonMaster { get; set; }
        public virtual ICollection<Character> Party { get; set; }
    }
}
