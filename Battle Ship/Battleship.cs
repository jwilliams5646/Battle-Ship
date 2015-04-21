using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Battleship : Ship {
        public static String Type = "Battleship";
        public static int Size = 4;
        public Boolean isHorizontal { get; set; }
        public String Name { get; set; }
        public String LocX { get; set; }
        public int LocY { get; set; }
    }
}
