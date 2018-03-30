using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonAndDragonManager.ImportFiles
{
    public class JsonBackground
    {
        public string Name { get; set; }
        public string RegExpSearch { get; set; }
        public string Source { get; set; }
        public List<string> SkillChoices { get; set; }
        public int SkillNumber { get; set; }
        public int Gold { get; set; }
        public List<JsonEquipment> Equipment { get; set; }
        public List<JsonFeature> Features { get; set; }
        public List<string> Trait { get; set; }
        public List<string> Ideal { get; set; }
        public List<string> Bond { get; set; }
        public List<string> Flaw { get; set; }
        public JsonExtraChoice ExtraChoice { get; set; }
        public JsonToolProficiencies ToolProfs { get; set; }
        public JsonLanguageProficiency LanguageProfs { get; set; }
        public string Lifestyle { get; set; }
    }

    public class JsonEquipment
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Weight { get; set; } 
    }

    public class JsonFeature
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class JsonExtraChoice
    {
        public string Name { get; set; }
        public List<string> Choices { get; set; }
    }

    public class JsonToolProficiencies
    {
        public List<JsonToolProficiency> Primary { get; set; }
        public List<JsonToolProficiency> Secondary { get; set; }
    }

    public class JsonToolProficiency
    {
        public string Name { get; set; }
        public string Ability { get; set; }
        public int NumChoices { get; set; }
    }

    public class JsonLanguageProficiency
    {
        public List<string> Languages { get; set; }
        public int AdditionalChoices { get; set; }
    }

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
