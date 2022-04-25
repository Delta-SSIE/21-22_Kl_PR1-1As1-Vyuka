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

        private static Random _random = new Random();

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
            int placed = 0;

            //dokud není umístěno vše
            while (placed < ShipCnt) 
            {
                //vymysli si pozici
                int x = _random.Next(_width);
                int y = _random.Next(_height);

                //a pokud tam ještě loď není, umísti
                if (Sea[x,y] != TileState.Ship)
                {
                    Sea[x, y] = TileState.Ship;
                    placed++;
                }
            }
        }
        public Coords FindTarget()
        {
            //hledám v protivníkově moři, dokud nenajdu místo, kam jsem nestřílel
            Coords target = null;

            do
            {
                int x = _random.Next(_width);
                int y = _random.Next(_height);
                if (OpponentSea[x,y] == TileState.Empty)
                {
                    target = new Coords(x, y);
                }
            }
            while (target == null);

            return target;
        }
        public bool HandleShot(Coords target)
        {
            TileState state = Sea[target.X, target.Y];

            switch (state)
            {
                case TileState.Empty:
                    Sea[target.X, target.Y] = TileState.Missed;
                    return false;
                    
                case TileState.Ship:
                    Sea[target.X, target.Y] = TileState.Hit;
                    Wrecks++;
                    return true;

                case TileState.Missed:
                    return false;
                    
                case TileState.Hit:
                    return false;
            }
            return false;

        }

        public void MarkResult(Coords target, bool hit)
        {
            if (OpponentSea[target.X, target.Y] != TileState.Empty)
            {
                return;
            }

            OpponentSea[target.X, target.Y] = hit ? TileState.Hit : TileState.Missed;

            //if (hit)
            //{
            //    OpponentSea[target.X, target.Y] = TileState.Hit;
            //}
            //else
            //{
            //    OpponentSea[target.X, target.Y] = TileState.Missed;
            //}
        }
    }
}
