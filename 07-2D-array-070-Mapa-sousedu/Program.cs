using System;

namespace _07_2D_array_070_Mapa_sousedu
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa1 =
            {
                { true,  true,  false, false },
                { false, false, true,  true },
                { false, false, false, true },
                { false, false, true,  true },
            };



            Vypis2DPole(Sousede(mapa1));
            Console.WriteLine();

            bool[,] mapa2 =
            {
                { true,  true,  false, false, true },
                { false, false, true,  true,  false },
                { false, false, false, true,  false },
            };

            Vypis2DPole(Sousede(mapa2));
        }

        static int[,] Sousede(bool[,] mapa)
        {
            // vytvořit pole o stejných rozměrech jako mapa
            int[,] sousede = new int[mapa.GetLength(0), mapa.GetLength(1)];

            //projdu všechna pole mapy
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    sousede[y, x] = PocetSousedu(mapa, x, y);
                }
            }

            return sousede;
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

        public static void Vypis2DPole(int[,] pole)
        {
            //do kódu této metody nezasahujte - nebo si můžete doplnit rámečky jako v jedné z předešlých úloh
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
