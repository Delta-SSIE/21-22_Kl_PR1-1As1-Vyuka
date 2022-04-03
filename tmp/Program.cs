using System;



namespace test
{
    using System;

    class Program
    {

        public static void Main(string[] args)
        {

            int[,] pokladny = {
            {10, 7, 12, 4, 8},
            {3, 12, 5, 1, 4},
            {8, 5, 6, 7, 1}
        };

            int[,] prijmy = {
            {0, -2, 2, -1, -3},
            {1, -1, 2, -1, -2},
            {-1, 1, -2, -1, 1}
        };

            vypis(BudouciHodnoty(3, pokladny, prijmy));
            Console.ReadKey();
        }

        public static int[,] BudouciHodnoty(int kola, int[,] pokladny, int[,] prijmy)
        {
            int[,] budouciStav = new int[pokladny.GetLength(0), pokladny.GetLength(1)];

            for (int x = 0; x < pokladny.GetLength(1); x++)
            {
                for (int y = 0; y < pokladny.GetLength(0); y++)
                {
                    budouciStav[y, x] = pokladny[y, x] + kola * prijmy[y, x];
                }
            }

            return budouciStav;
        }

        public static void vypis(int[,] pole)
        {
            int length;

            int i = int.MinValue;
            for (int x = 0; x < pole.GetLength(0); x++)
            {
                for (int y = 0; y < pole.GetLength(1); y++)
                {
                    if (pole[x, y] > i)
                        i = pole[x, y];
                }
            }

            length = Convert.ToString(i).Length;


            for (int x = 0; x < pole.GetLength(0); x++)
            {
                for (int y = 0; y < pole.GetLength(1); y++)
                {
                    Console.ForegroundColor = pole[x, y] >= 0 ? ConsoleColor.White : ConsoleColor.Red;
                    Console.Write(pole[x, y].ToString().PadRight(length) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


