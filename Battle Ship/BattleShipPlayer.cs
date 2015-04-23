using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship {
    class BattleShipPlayer {
        public Grid HUD { get; set; }
        public Grid ShipYard { get; set; }
        public List<Ship> listShips { get; set; }
        public Dictionary<String, int> moves { get; set; }

        public BattleShipPlayer() {
            HUD = new Grid();
            ShipYard = new Grid();
            listShips = new List<Ship>();
        }



        internal void setShipYardGrid() {
            //Ship gs = PickShip();

        }

        private Ship PickShip() {
            Menu menu = new Menu();
            Ship gs = PickShipType();
            //Choice choice = menu.ShipOptions();
            return null;
        }

        private Ship PickShipType() {
            Menu m = new Menu();
            bool isShipType = false;
            while(!isShipType) {
                String type = m.PickShipMenu();
                switch(type) {
                    case "C":
                    return new Carrier();
                    isShipType = true;
                    break;
                    case "B":
                    return new Battleship();
                    isShipType = true;
                    break;
                    case "D":
                    return new Destroyer();
                    isShipType = true;
                    break;
                    case "S":
                    return new Submarine();
                    isShipType = true;
                    break;
                }
            }
        }
    }
}
