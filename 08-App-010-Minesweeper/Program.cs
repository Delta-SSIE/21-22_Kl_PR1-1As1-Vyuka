using System;

namespace _08_App_010_Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            int vyska = 10;
            int sirka = 10;
            int pocetMin = 12;

            bool[,] mapaMin = VytvorMapu(vyska, sirka, pocetMin);
        }
        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMin)
        {
            Random rnd = new Random();

            bool[,] mapa = new bool[vyska, sirka];
            for (int i = 0; i < pocetMin; i++)
            {
                int x = rnd.Next(sirka);
                int y = rnd.Next(vyska);
                if (mapa[y, x])
                {
                    i--;
                }
                else
                {
                    mapa[y, x] = true;
                }
            }
            return mapa;
        }

        static int PocetSousedu(bool[,] mapa, int sourX, int sourY)
        {
            //zalozime pocitadlo
            int pocet = 0;

            //projdeme x od o jedna mensi do o 1 vetsi
            //int minX = sourX - 1;
            //if (minX < 0)
            //    minX = 0;

            int minX = Math.Max(sourX - 1, 0);
            int maxX = Math.Min(sourX + 1, mapa.GetLength(1) - 1);
            //mapa.GetLength(1) - 1 je největší možná hodnota x, kterou pole obsahuje

            int minY = Math.Max(sourY - 1, 0);
            int maxY = Math.Min(sourY + 1, mapa.GetLength(0) - 1);

            //ke kazdemu x projedeme pro y od o 1 mensi do o 1 vetsi

            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    //kdyz najdu minu, (a nejsem sám na hledané pozici, abych nepočítal sebe) , zvysim pocitadlo
                    if (mapa[y, x] && (x != sourX || y != sourY))
                        pocet++;
                }
            }

            return pocet;
        }

    }
}
