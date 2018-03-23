using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Data.Models;
using DungeonAndDragonManager.Models;
using Newtonsoft.Json.Linq;

namespace DungeonAndDragonManager.Data.Seed
{
    public static class RaceSeed
    {
        public static void Seed(FullDbContext db, ICollection<JObject> json)
        {
            var phbSource = db.Sources.SingleOrDefault(s => s.Name == "Player's Handbook");

            var races = json.Select(j => new DbRace
            {

            }).ToList();

            foreach (var race in races)
            {
                var dbRace = db.Races.SingleOrDefault(r => r.Name == race.Name);
                if (dbRace != null)
                {
                    foreach (var subRace in race.SubRaces)
                    {
                        if (dbRace.SubRaces.All(r => r.Name != subRace.Name))
                        {
                            dbRace.SubRaces.Add(subRace);
                        }
                    }
                }
                else
                {
                    db.Races.Add(race);
                }
            }

            db.SaveChanges();
        }
    }
}
