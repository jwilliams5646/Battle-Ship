using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Program {
        static void Main(string[] args) {
            List<Ship> myTestList = new List<Ship>();
            Destroyer destroy = new Destroyer();
            destroy.Name = "D1";
            destroy.LocX = "B";
            destroy.LocY = 2;
            destroy.isHorizontal = true;
            Console.WriteLine("Destroyer " + destroy.Name + " is created");
            myTestList.Add(destroy);

            Carrier carrier = new Carrier();
            carrier.Name = "C1";
            carrier.LocX = "A";
            carrier.LocY = 10;
            carrier.isHorizontal = false;
            Console.WriteLine("Carrier " + carrier.Name + " is created");
            myTestList.Add(carrier);

            Battleship bs = new Battleship();
            bs.Name = "B1";
            bs.LocX = "F";
            bs.LocY = 5;
            bs.isHorizontal = false;
            Console.WriteLine("Battleship " + bs.Name + " is created");
            myTestList.Add(bs);

            Grid grid = new Grid();
            grid.PrintGrid();
            Console.WriteLine(destroy.LocX);
            grid.AddShip(destroy);
        }

    }
}
