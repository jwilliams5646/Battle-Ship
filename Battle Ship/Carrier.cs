using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Carrier : Ship {
        public static String Type = "Carrier";
        public static int Size = 6;
        public Boolean isHorizontal { get; set; }
        public String Name { get; set; }
        public String LocX { get; set; }
        public int LocY { get; set; }
    }
}
