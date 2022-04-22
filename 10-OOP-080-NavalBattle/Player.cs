using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_080_NavalBattle
{
    class Player
    {
        private int _width;
        private int _height;
        public int ShipCnt { get; private set; }
        public int Wrecks { get; private set; }
        public TileState[,] Sea { get; private set; }
        public TileState[,] OpponentSea { get; private set; }

        //public bool IsAlive
        //{
        //    get
        //    {
        //        return ShipCnt > Wrecks;
        //    }
        //}
        public bool IsAlive => ShipCnt > Wrecks;

        public Player(int width, int height, int shipCnt)
        {
            _width = width;
            _height = height;
            ShipCnt = shipCnt;

            Wrecks = 0;
            Sea = new TileState[_width, _height];
            OpponentSea = new TileState[_width, _height];
        }

        public void PlaceShips()
        {
            throw new NotImplementedException();
        }
        public Coords FindTarget()
        {
            throw new NotImplementedException();
        }
        public bool HandleShot(Coords target)
        {
            throw new NotImplementedException();
        }
    }
}
