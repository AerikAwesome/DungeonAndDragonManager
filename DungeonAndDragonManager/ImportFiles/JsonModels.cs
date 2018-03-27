using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.ImportFiles
{
    public class JsonRace
    {
        public string RegExpSearch { get; set; }
        public string Name { get; set; }
        public List<List<object>> Source { get; set; }
        public string Plural { get; set; }
        public int Size { get; set; }
        public JsonSpeed Speed { get; set; }
        public List<string> LanguageProfs { get; set; }
        public List<string> Weapons { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string HeightMetric { get; set; }
        public string WeightMetric { get; set; }
        public List<short> Scores { get; set; }
        public string Trait { get; set; }
        public object Features { get; set; }
        public List<JsonSubRace> SubRaces { get; set; }
    }

    public class JsonSubRace
    {
        public string RegExpSearch { get; set; }
        public string Name { get; set; }
        public string Trait { get; set; }
        public List<string> Dmgres { get; set; }
        public List<short> Scores { get; set; }
    }
    public class JsonSpeed
    {
        public JsonSpeedValue Walk { get; set; }
        public JsonSpeedValue Climb { get; set; }
        public JsonSpeedValue Swim { get; set; }
        public JsonSpeedValue Fly { get; set; }
    }

    public class JsonSpeedValue
    {
        public int Spd { get; set; }
        public int Enc { get; set; }
    }
    public class JsonClass
    {
    }

    public class JsonSubClass
    {

    }
}
