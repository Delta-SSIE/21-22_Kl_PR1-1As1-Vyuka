using System;

namespace _04_For_24_opakovani
{
    class Program
    {
        static void Main(string[] args)
        {
            //int strana = 6;

            //for (int y = 0 ; y < strana; y++)
            //{
            //    for (int x = 0; x < y + 1; x++)
            //    {
            //        Console.Write('X');
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();


            //for (int y = 0; y < strana; y++)
            //{
            //    for (int x = 0; x < strana - y; x++)
            //    {
            //        Console.Write('X');
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //for (int y = 0; y < strana; y++)
            //{
            //    for (int x = 0; x < y; x++)
            //    {
            //        Console.Write(' ');
            //    }

            //    for (int x = y; x < strana; x++)
            //    {
            //        Console.Write('X');
            //    }

            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //for (int y = 0; y < strana; y++)
            //{
            //    for (int x = 0; x < y + 1; x++)
            //    {
            //        Console.Write('X');
            //    }

            //    for (int x = y; x < strana - 1; x++)
            //    {
            //        Console.Write(' ');
            //    }

            //    Console.WriteLine();
            //}

            int polomer = 7;
            int strana = 2 * polomer + 1;

            int stredX = polomer;
            int stredY = polomer;

            for (int x = 0; x < strana; x++)
            {
                for (int y = 0; y < strana; y++)
                {
                    int dx = x - stredX;
                    int dy = y - stredY;
                    double vzdalenost = Math.Sqrt(dx * dx + dy * dy);

                    if (vzdalenost <= polomer)
                        Console.Write('X');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
