using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Program {
        static void Main(string[] args) {
            Menu menu = new Menu();
            menu.GameMenu();
            BattleShipPlayer One = new BattleShipPlayer();
            One.setShipYardGrid();
            BattleShipPlayer Two = new BattleShipPlayer();
            List<Ship> myTestList = new List<Ship>();
            Grid grid = new Grid();

            Destroyer destroy = new Destroyer();
            destroy.Name = "D";
            destroy.LocX = "B";
            destroy.LocY = 2;
            destroy.isHorizontal = true;
            Console.WriteLine("Destroyer " + destroy.Name + " is created");
            grid.AddShip(destroy);
            grid.PrintGrid();

            Carrier carrier = new Carrier();
            carrier.Name = "C";
            carrier.LocX = "D";
            carrier.LocY = 7;
            carrier.isHorizontal = true;
            Console.WriteLine("Carrier " + carrier.Name + " is created");
            grid.AddShip(carrier);
            grid.PrintGrid();

            Battleship bs = new Battleship();
            bs.Name = "B";
            bs.LocX = "F";
            bs.LocY = 5;
            bs.isHorizontal = false;
            Console.WriteLine("Battleship " + bs.Name + " is created");
            grid.AddShip(bs);
            grid.PrintGrid();

            Submarine s = new Submarine();
            s.Name = "S";
            s.LocX = "J";
            s.LocY = 1;
            bs.isHorizontal = true;
            Console.WriteLine("Submarine " + s.Name + " is created");
            grid.AddShip(s);
            grid.PrintGrid();

            Console.ReadKey();
        }

    }
}
