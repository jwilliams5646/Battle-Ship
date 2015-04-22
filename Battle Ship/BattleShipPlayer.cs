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

        public BattleShipPlayer() {
            HUD = new Grid();
            ShipYard = new Grid();
            listShips = new List<Ship>();
        }



        internal void setShipYardGrid() {
            //Ship gs = PickShip();

        }

        private Ship PickShip() {
            //
            return null;
        }
    }
}
