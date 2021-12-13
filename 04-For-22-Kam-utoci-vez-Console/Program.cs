using System;

namespace _04_For_22_Kam_utoci_vez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Načíst vstup
            Console.Write("Kde stojí věž: ");
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

            //vypsat všechny na stejném sloupci ... stejné písmeno
            for (int i = 0; i < 8; i++)
            {
                if (i == figuraRadek)
                    continue;

                //Console.WriteLine("" + pozicePismeno + (i + 1));
                Console.WriteLine($"{pozicePismeno}{i + 1}");
            }

            //vypsat všechny na stejné řadě ... stejné číslo
            for (int i = 0; i < 8; i++)
            {
                if (i == figuraSloupec)
                    continue;

                Console.WriteLine($"{(char)('A' + i)}{poziceCislo}");
            }
        }
    }
}
