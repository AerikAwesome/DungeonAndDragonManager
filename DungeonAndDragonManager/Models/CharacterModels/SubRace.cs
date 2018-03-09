using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class SubRace
    {
        [Key]
        public int Id { get; set; }
        public virtual Race Race { get; set; }
        public string Name { get; set; }
    }
}
