using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Noema
{
    class Desk
    {
        public static int MAX_WIDTH { get; internal set; }
        public static int MIN_WIDTH { get; internal set; }
        public static int MAX_DEPTH { get; internal set; }
        public static int MIN_DEPTH { get; internal set; }
        public int ProductionTime { get; internal set; }
        public object CustomerName { get; internal set; }
        public int Depth { get; internal set; }
        public int Width { get; internal set; }
        public int NumberOfDrawers { get; internal set; }
        public Materials SurfaceMaterial { get; internal set; }
        public object Quote { get; internal set; }
    }
}
