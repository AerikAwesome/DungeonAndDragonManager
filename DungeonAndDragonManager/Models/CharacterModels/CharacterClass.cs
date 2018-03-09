using System.ComponentModel.DataAnnotations;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class CharacterClass
    {
        [Key]
        public int Id { get; set; }
        public virtual Character Character { get; set; }
        public virtual Class Class { get; set; }
        public virtual SubClass SubClass { get; set; }
        public int Level { get; set; }
        public bool Primary { get; set; }
    }
}
