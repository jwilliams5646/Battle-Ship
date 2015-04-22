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
    }
}
