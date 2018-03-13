using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbCampaign
    {
        [Key]
        public int Id { get; set; }

        public string DungeonMasterId { get; set; }
        [ForeignKey("DungeonMasterId")]
        public ApplicationUser DungeonMaster { get; set; }
        public ICollection<DbParty> Parties { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
