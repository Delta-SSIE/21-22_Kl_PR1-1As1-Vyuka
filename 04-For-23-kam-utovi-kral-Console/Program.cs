using System;

namespace _04_For_23_kam_utovi_kral_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Načíst vstup
            Console.Write("Kde stojí král: ");
            string vstup = Console.ReadLine().ToUpper();

            //parsovat řádek a sloupec
            if (vstup.Length != 2)
            {
                Console.WriteLine("Neplatný vstup");
                return;
            }

            char pozicePismeno = vstup[0]; // sloupec je na 1. pozici
            int figuraSloupec = pozicePismeno - 'A';

            char poziceCislo = vstup[1]; //řádek je na 2. pozici
            int figuraRadek = poziceCislo - '1';

            if (figuraRadek < 0 || figuraRadek > 7 || figuraSloupec < 0 || figuraSloupec > 7)
            {
                Console.WriteLine("Neplatný vstup");
                return;
            }

            //projdu všechna pole okolo krále
            for (int posunX = -1; posunX < 2; posunX++)
            {
                for (int posunY = -1; posunY < 2; posunY++)
                {
                    
                    int poziceRadek = figuraRadek + posunY;
                    int poziceSloupec = figuraSloupec + posunX;

                    if (
                        (posunX == 0 && posunY == 0) //to je přímo pozice krále
                        || poziceRadek < 0
                        || poziceRadek > 7
                        || poziceSloupec < 0
                        || poziceSloupec > 7
                        )
                    {
                        continue; //mimo dovolená pole - přeskočím
                    }
                        Console.WriteLine($"{(char)('A' + poziceSloupec)}{(char)('1'+poziceRadek)}");
                }
            }
        }
    }
}
