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
            Player One = new Player();
            One.setShipYardGrid();
            Player Two = new Player();

            Console.ReadKey();
        }

    }
}
