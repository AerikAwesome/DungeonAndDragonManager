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

        public string Group { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }

        public DbSource() { }

        public DbSource(string name, string abbr, string group, string url, DateTime date)
        {
            Name = name;
            Abbreviation = abbr;
            Group = group;
            Url = url;
            Date = date;
        }
    }
}
