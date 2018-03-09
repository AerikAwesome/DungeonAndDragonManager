using System.ComponentModel.DataAnnotations;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class ClassFeature
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
