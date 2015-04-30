using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class Player {
        public Grid HUD { get; set; }
        public Grid ShipYard { get; set; }
        public List<Ship> listShips { get; set; }
        public Ship gs { get; set; }
        public static String[] types = { "B", "C", "D", "S" };
        public static String[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

        public Player() {
            HUD = new Grid();
            ShipYard = new Grid();
            listShips = new List<Ship>();
        }



        internal void setShipYardGrid() {
            while(listShips.Count() < 5) {
                gs = PickShipType();
                do {
                    PickShipLocation();
                }
                while(!ShipYard.AddShip(gs));
                gs = null;
            }
        }

        private void PickShipLocation() {
            Menu m = new Menu();
            bool isSet = false;
            Choice choice = null;
            while(!isSet) {
                choice = m.PickLocation();
                if(letters.Contains(choice.row)) {
                    isSet = true;
                } else {
                    isSet = false;
                }
                if(choice.column > 0 && choice.column < 11) {
                    isSet = true;
                } else {
                    isSet = false;
                }
            }
            gs.LocX = choice.row;
            gs.LocY = choice.column;
        }

        private Ship PickShipType() {
            Menu m = new Menu();
            String type = null;
            do {
                type = m.PickShipMenu().ToUpper();
                Console.Clear();
            }
            while(!types.Contains(type));
            Ship gs = null;
            switch(type) {
                case "C":
                gs = new Carrier();
                break;
                case "B":
                gs = new Battleship();
                break;
                case "D":
                gs = new Destroyer();
                break;
                case "S":
                gs = new Submarine();
                break;
            }
            return gs;
        }
    }
}
