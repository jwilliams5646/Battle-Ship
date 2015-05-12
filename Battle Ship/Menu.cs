using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Menu {

        public void DisplayGameIntro() {
            String GAMEINTRO = Environment.NewLine + Environment.NewLine + "Welcome to Battleship" + Environment.NewLine + Environment.NewLine + "Press any key to continue";
            printCenter(GAMEINTRO);
            Console.ReadKey();
            Console.Clear();
        }

        public String PickShipMenu() {
            String result = "";
            String[] choices = { "C", "B", "D", "S" };
            while(!choices.Contains(result)) {
            printCenter(Environment.NewLine + Environment.NewLine + "Pick a Ship" + Environment.NewLine + Environment.NewLine);
            printCenter("C = Carrier");
            printCenter("B = Battleship");
            printCenter("D = Destroyer");
            printCenter("S = Submarine");
            result = Console.ReadLine().ToUpper();
            }
            Console.Clear();
            return result;
        }


        public Choice PickLocation() {
            Choice c = new Choice();
            c.row = pickRow();
            c.column = pickColumn();
            return c;
        }

        public String pickRow() {
            bool inLetters = false;
            String rowInput = "";
            while(!inLetters) {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                printCenter("Pick a row between A and J: ");
                rowInput = Console.ReadLine().ToUpper();
                inLetters = Grid.letters.Contains(rowInput);
            }
            Console.Clear();
            return rowInput;
        }

        public int pickColumn() {
            int result = 0;
            while(result < 1 || result > 10) {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                printCenter("Pick a column: ");
                String columnInput = Console.ReadLine();
                int.TryParse(columnInput, out result);
            }
            Console.Clear();
            return result;
        }

        private static void printCenter(string output) {
            Console.Write(new string(' ', (Console.WindowWidth - output.Length) / 2));
            Console.Write(output);
        }
        private static void printIndent(string output) {
            Console.Write(new string(' ', (Console.WindowWidth - output.Length) / 4));
            Console.Write(output);
        }
    }
}
