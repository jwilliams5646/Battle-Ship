using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Menu {

        public void GameMenu() {
            printCenter("Welcome to Battleship");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            printCenter("Press any key to continue");
            Console.ReadKey();
        }

        

        private static void printCenter(string output) {
            Console.Write(new string(' ', (Console.WindowWidth - output.Length) / 2));
            Console.WriteLine(output);
        }
        private static void printIndent(string output) {
            Console.Write(new string(' ', (Console.WindowWidth - output.Length) / 4));
            Console.WriteLine(output);
        }

        internal String PickShipMenu() {
            printIndent("Pick a ship");
            printCenter("C = Carrier");
            printCenter("B = Battleship");
            printCenter("D = Destroyer");
            printCenter("S = Submarine");
            return Console.ReadLine();
        }
    }
}
