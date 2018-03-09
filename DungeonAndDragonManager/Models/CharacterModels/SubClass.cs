using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class SubClass
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SubClass> SubClasses { get; set; }
    }
}
