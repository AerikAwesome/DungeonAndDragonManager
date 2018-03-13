using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbParty
    {
        [Key]
        public int Id { get; set; }

        public int CampaignId { get; set; }
        public DbCampaign Campaign { get; set; }
        public ICollection<DbCharacter> PartyMembers { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
