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


        public void AddShip(Ship gs) {
            Console.ReadKey();
            String key = gs.LocX;
            int index = gs.LocY;
            int size = gs.Size;
            bool isHorizontal = gs.isHorizontal;
            Console.WriteLine(gs.Size + gs.Name);
            if(isOutOfBounds(key, index, size, isHorizontal)) {
                Console.WriteLine("Your " + gs.Name + " is too long to place here");
                return;
            }
            if(isAlreadyUsed(key, index, size, isHorizontal)) {
                Console.WriteLine("Your " + gs.Name + " can't be placed on top of another ship");
                return;
            }
        }

        private bool isOutOfBounds(String key, int index, int size, bool isHorizontal) {
            Boolean outOfBounds = false;
            if(isHorizontal) {
                int indexOfKey = Array.IndexOf(letters, key);
                if(indexOfKey + size > letters.Count() - 1) {
                    outOfBounds = true;
                }
            }
            if(!isHorizontal) {
                if(index + size > 10) {
                    outOfBounds = true;
                }
            }
            return outOfBounds;
        }

        private bool isAlreadyUsed(string key, int index, int size, bool isHorizontal) {
            Boolean alreadyUsed = false;
            if(isHorizontal) {
                int indexOfKey = Array.IndexOf(letters, key);
                for(int x = indexOfKey; x < indexOfKey + size; x++) {
                    if(!TheGrid[letters[x]].ElementAt(index).Equals("*")) {
                        alreadyUsed = true;
                    }
                }
            }
            if(!isHorizontal) {
                for(int x = index; x < index + size; x++) {
                    if(!TheGrid[key].ElementAt(x).Equals("*")) {
                        alreadyUsed = true;
                    }
                }
            }
            return alreadyUsed;
        }
    }
}
