using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSphere
{
    public class Coords
    {
        public double? x { get; set; }
        public double? y { get; set; }
        public double? z { get; set; }
    }

    public class StarSystem
    {
        public double? distance { get; set; }
        public int? bodyCount { get; set; }
        public string name { get; set; }
        public Coords coords { get; set; }
        public bool? coordsLocked { get; set; }
    }

    public class StarSystems
    {
        public List<StarSystem> Systems { get; set; }
    }

    public class StarSystemCoords
    {
        public string name { get; set; }
        public Coords coords { get; set; }
        public bool? coordsLocked { get; set; }
    }
}
