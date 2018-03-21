using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Models.CharacterModels;

namespace DungeonAndDragonManager.Models
{
    public class Party
    {
        [Key]
        public int Id { get; set; }
        public virtual Campaign Campaign { get; set; }
        public virtual ICollection<Character> PartyMembers { get; set; }
    }
}
