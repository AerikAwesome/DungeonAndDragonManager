using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DungeonAndDragonManager.Models
{
    public class Speed
    {
        public SpeedValue Walk { get; set; }
        public SpeedValue Fly { get; set; }
        public SpeedValue Swim { get; set; }
        public SpeedValue Climb { get; set; }
    }

    public class SpeedValue
    {
        public int Normal { get; set; }
        public int Encumbered { get; set; }
    }
}
