using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<SubRace> SubRaces { get; set; }
        public string Name { get; set; }
    }
}
