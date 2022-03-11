using System;

namespace _07_2D_array_06_Pocet_sousedu
{
    class Program
    {
        public static void Main(string[] args)
        {

            bool[,] mapa =
            {
            { true,  true,  false, false },
            { false, false, true,  true },
            { false, false, false, true },
            { false, false, true,  true },
        };

            Console.WriteLine(PocetSousedu(mapa, 0, 0)); //mělo by vypsat 1 - levý horní roh sousedí jen s jednou minou
            Console.WriteLine(PocetSousedu(mapa, 0, 3)); //mělo by vypsat 0 - levý dolní roh s žádnou minou nesousedí
            Console.WriteLine(PocetSousedu(mapa, 2, 2)); //mělo by vypsat 5

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
                    if (mapa[y, x] && (x != sourX || y != sourY) )
                        pocet++;
                }
            }

            return pocet;
        }
    }
}
