using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.Data.Models
{
    public class DbSubClass
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public DbClass Class { get; set; }
        public int SourceId { get; set; }
        public DbSource Source { get; set; }

        public string Name { get; set; }
    }
}
