using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Models;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbSource
    {
        [Key]
        public int Id { get; set; }

        public string CreatorId { get; set; }
        public ApplicationUser Creator { get; set; }

        public string Name { get; set; }
        public string Abbreviation { get; set; }

    }
}
