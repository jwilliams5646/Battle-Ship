using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Submarine : Ship {
        public override String Type { get { return "Submarine"; } }
        public override int Size { get { return 3; } }
        public override Boolean isHorizontal { get; set; }
        public override String Name { get; set; }
        public override String LocX { get; set; }
        public override int LocY { get; set; }
        public override int Life { get; set; }
        public Submarine() {
            Life = Size;
        }
    }
}
