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
            destroy.LocX ="B";
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

            String[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            String[] A = new String[10];
            constructArray(A);
            String[] B = new String[10];
            constructArray(B);
            String[] C = new String[10];
            constructArray(C);
            String[] D = new S 
            String[] F = new String[10];
            constructArray(F);
            String[] G = new String[10];
            constructArray(G);
            String[] H = new String[10];
            constructArray(H);
            String[] I = new String[10];
            constructArray(I);
            String[] J = new String[10];
            constructArray(J);

            Dictionary<String,String[]> Grid = new Dictionary<String,String[]>();
            Grid.Add("A", A);
            Grid.Add("B", B);
            Grid.Add("C", C);
            Grid.Add("D", D);
            Grid.Add("E", E);
            Grid.Add("F", F);
            Grid.Add("G", G);
            Grid.Add("H", H);
            Grid.Add("I",I);
            Grid.Add("J", J);
            Console.WriteLine(Grid.Keys.ToString());
            Console.WriteLine(Grid.Keys.ToString());
            Console.WriteLine(Grid.Keys.ToString());
            Console.WriteLine(Grid.Keys.ToString());
            Console.ReadKey();
        }

        private static void constructArray(string[] input) {
            for(int x = 0; x < input.Length; x++) {
                input[x] = "*";
            }
        }

    }
}
