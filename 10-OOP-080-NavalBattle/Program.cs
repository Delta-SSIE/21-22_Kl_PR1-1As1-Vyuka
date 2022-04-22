using System;

namespace _10_OOP_080_NavalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 10;
            const int height = 10;
            const int shipCnt = 20;

            Player activePlayer;
            Player passivePlayer;

            //vytvoř hráče
            Player player = new Player(width, height, shipCnt);
            //vytvoř počítače
            Player computer = new Player(width, height, shipCnt);

            //vytvoř displaye
            SeaDisplay playerDisp = new SeaDisplay(1, 3);
            SeaDisplay computerDisp = new SeaDisplay(1 + width + 4, 3);

            //hráč si umístí lodi
            player.PlaceShips();
            //počítač umístí lodi
            computer.PlaceShips();

            //vyber, kdo je na tahu
            activePlayer = player;
            passivePlayer = computer;

            //dokud není konec
            while (player.IsAlive && computer.IsAlive) 
            {
                // hráč na tahu střílí
                Coords target = activePlayer.FindTarget();

                // druhý vyhodnotí střelu
                bool hit = passivePlayer.HandleShot(target);

                // vykreslím stav
                if (activePlayer == player)
                {
                    computerDisp.RenderSea(player.OpponentSea);
                }
                else
                {
                    playerDisp.RenderSea(player.Sea);
                }

                if (!hit) 
                { 
                    //změním hráče na tahu
                    Player tmp = activePlayer;
                    activePlayer = passivePlayer;
                    passivePlayer = tmp;
                }
            }
            //vypiš výsledek
        }
    }
}
