using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Menu {

        String GameMenu = Environment.NewLine + Environment.NewLine + "Welcome to Battleship" + Environment.NewLine + Environment.NewLine + "Press any key to continue";
        String PickShip = Environment.NewLine + Environment.NewLine + "Pick a Ship" + Environment.NewLine + Environment.NewLine;

        public void DisplayGameMenu() {
            printCenter(GameMenu);
            Console.ReadKey();
            Console.Clear();
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
            printCenter(PickShip);
            printCenter("C = Carrier");
            printCenter("B = Battleship");
            printCenter("D = Destroyer");
            printCenter("S = Submarine");
            return Console.ReadLine();
            Console.Clear();
        }


        internal Choice PickLocation() {
            Choice c = new Choice();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            printCenter("Pick a row: ");
            c.row = Console.ReadLine();
            printCenter("Pick a column: ");
            String columnInput = Console.ReadLine();
            int column;
            int.TryParse(columnInput, column);
            c.column = int.TryParse(column);


            return c;
        }
    }
}
