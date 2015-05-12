using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Program {
        static void Main(string[] args) {
            Menu menu = new Menu();
            menu.DisplayGameIntro();
            Console.WriteLine(menu.pickRow());
            Player One = new Player();
            Player Two = new Player();

            Console.ReadKey();
        }

    }
}
