using System;

namespace _07_2D_array_05_mapa_s_rameckem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] mapa = VytvorMapu(6, 8, 10);
            //VykresliPole(mapa, '#', ' '); // odkomentujte pro krok 1
            VykresliPole(mapa, 2, 5, '#', ' '); // odkomentujte pro krok 2   
        }
        static void VykresliPole(bool[,] mapa, int markX, int markY, char znakTrue, char znakFalse)
        {
            Console.WriteLine("╔".PadRight(mapa.GetLength(1) + 1, '═')+ "╗");
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                Console.Write("║");
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    if (x == markX && y == markY)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    
                    if (mapa[y, x])
                        Console.Write(znakTrue);
                    else
                        Console.Write(znakFalse);
                    
                    if (x == markX && y == markY)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.WriteLine("║");
            }
            Console.WriteLine("╚".PadRight(mapa.GetLength(1) + 1, '═') + "╝");

        }
        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMinci)
        {
            Random rnd = new Random();

            bool[,] mapa = new bool[vyska, sirka];
            for (int i = 0; i < pocetMinci; i++)
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
    }
}
