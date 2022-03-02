using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towerdefense
{

    public class WaveStructure
    {
        public int waveId { get; set; }
        public Bloons bloons { get; set; }
    }

    public class Bloons
    {
        public int red { get; set; }
        public int blue { get; set; }
        public int green { get; set; }
        public int yellow { get; set; }
        public int pink { get; set; }
        public int black { get; set; }
        public int lightBlue { get; set; }
        public int zebra { get; set; }
        public int rainbow { get; set; }
        public int keramik { get; set; }

    }
}
