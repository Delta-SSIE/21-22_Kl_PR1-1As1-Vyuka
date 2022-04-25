using System;

namespace _10_OOP_080_NavalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player p = new Player(10, 10, 20);
            //p.PlaceShips();
            //SeaDisplay playerDisp = new SeaDisplay(1, 3);
            //playerDisp.CursorColor = ConsoleColor.Green;

            //SeaDisplay computerDisp = new SeaDisplay(1 + 10 + 4, 3);
            //playerDisp.RenderSea(p.Sea, new Coords(3,5));
            //computerDisp.RenderSea(p.Sea);

            //playerDisp.SelectCoordinates(p.Sea, new Coords(5, 5));

            Game();
        }

        static void Game()
        {
            const int width = 4;
            const int height = 4;
            const int shipCnt = 6;
            const int sleep = 200;

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

            playerDisp.RenderSea(player.Sea);
            computerDisp.RenderSea(player.OpponentSea);

            //dokud není konec
            while (player.IsAlive && computer.IsAlive) 
            {
                System.Threading.Thread.Sleep(sleep);
                // hráč na tahu střílí
                Coords target;
                if (activePlayer == player)
                {
                    target = computerDisp.SelectCoordinates(player.OpponentSea, new Coords(width / 2, height / 2));
                }
                else
                { 
                    target = activePlayer.FindTarget();
                }

                // druhý vyhodnotí střelu
                bool hit = passivePlayer.HandleShot(target);
                
                //první si poznamená
                activePlayer.MarkResult(target, hit);

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
