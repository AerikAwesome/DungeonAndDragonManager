using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Data.Models;
using DungeonAndDragonManager.ImportFiles;
using DungeonAndDragonManager.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DungeonAndDragonManager.Data.Seed
{
    public static class RaceSeed
    {
        public static void Seed(ApplicationDbContext db, JToken json)
        {
            var phbSource = db.Sources.SingleOrDefault(s => s.Name == "Player's Handbook");

            var races = new List<DbRace>();
            foreach (var jToken in json)
            {
                var jsonRace = jToken.ToObject<JsonRace>();
                var race = new DbRace(phbSource, jsonRace.Name, jsonRace.Plural, jsonRace.RegExpSearch, "", jsonRace.Trait, (Size)jsonRace.Size, jsonRace.LanguageProfs.ToArray(), jsonRace.Plural + jsonRace.Age, jsonRace.Plural + jsonRace.Height, jsonRace.Plural + jsonRace.Weight, jsonRace.Scores[0], jsonRace.Scores[1], jsonRace.Scores[2], jsonRace.Scores[3], jsonRace.Scores[4], jsonRace.Scores[5], jsonRace.SubRaces.Select(j => new DbSubRace(phbSource, j.Name, j.RegExpSearch, "", j.Trait, j.Dmgres.ToArray(), )));
            }

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
