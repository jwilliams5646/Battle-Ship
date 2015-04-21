using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Ship {
        public virtual String Type { get { return "Ship"; } }
        public virtual int Size { get { return 0; } }
        public virtual Boolean isHorizontal { get; set; }
        public virtual String Name { get; set; }
        public virtual String LocX { get; set; }
        public virtual int LocY { get; set; }
        public virtual int Life { get; set; }        
    }
}
