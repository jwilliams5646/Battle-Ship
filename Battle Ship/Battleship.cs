using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Battleship : Ship {
        public override String Type { get { return "Battleship"; } }
        public override int Size { get { return 4; } }
        public override Boolean isHorizontal { get; set; }
        public override String Name { get; set; }
        public override String LocX { get; set; }
        public override int LocY { get; set; }
    }
}
