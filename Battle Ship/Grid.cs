using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Grid {

        public Dictionary<String, String[]> TheGrid { get; set; }
        String[] A { get; set; }
        String[] B { get; set; }
        String[] C { get; set; }
        String[] D { get; set; }
        String[] E { get; set; }
        String[] F { get; set; }
        String[] G { get; set; }
        String[] H { get; set; }
        String[] I { get; set; }
        String[] J { get; set; }
        public static String[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

        public Grid() {
            A = new String[10];
            constructArray(A);
            B = new String[10];
            constructArray(B);
            C = new String[10];
            constructArray(C);
            D = new String[10];
            constructArray(D);
            E = new String[10];
            constructArray(E);
            F = new String[10];
            constructArray(F);
            G = new String[10];
            constructArray(G);
            H = new String[10];
            constructArray(H);
            I = new String[10];
            constructArray(I);
            J = new String[10];
            constructArray(J);

            TheGrid = new Dictionary<String, String[]>();
            TheGrid.Add("A", A);
            TheGrid.Add("B", B);
            TheGrid.Add("C", C);
            TheGrid.Add("D", D);
            TheGrid.Add("E", E);
            TheGrid.Add("F", F);
            TheGrid.Add("G", G);
            TheGrid.Add("H", H);
            TheGrid.Add("I", I);
            TheGrid.Add("J", J);
        }

        private static void constructArray(string[] input) {
            for(int x = 0; x < input.Length; x++) {
                input[x] = "*";
            }
        }

        public void PrintGrid() {
            foreach(String keyVals in letters) {
                foreach(String value in TheGrid[keyVals]) {
                    Console.Write(value);
                    Console.Write(" ");
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }


        public void AddDestroyer(Destroyer destroy, int size) {
            Console.ReadKey();
            if(isOutOfBounds(destroy, size)) {
                Console.WriteLine("Your ship is too long to place here");
                return;
            }
        }

        private bool isOutOfBounds(Destroyer destroy, int size) {
            String key = destroy.LocX;
            int index = destroy.LocY;
            int indexOfKey = Array.IndexOf(letters, key);
            Boolean outOfBounds = false;
            Console.WriteLine(key);
            Console.WriteLine(indexOfKey);
            if(destroy.isHorizontal) {
                if(indexOfKey + size > letters.Count() - 1) {
                    outOfBounds = true;
                }
            }

            if(!destroy.isHorizontal) {
                if(index + size > 10) {
                    outOfBounds = true;
                }
            }
            return outOfBounds;
        }
    }
}
