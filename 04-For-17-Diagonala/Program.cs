using System;

namespace _04_For_17_Diagonala
{
    class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;

            for (int radek = 0; radek < strana; radek++)
            {
                for (int sloupec = 0; sloupec < radek; sloupec++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }

            for (int radek = 0; radek < strana; radek++)
            {
                int pocetMezer = strana - radek - 1;
                for (int sloupec = 0; sloupec < pocetMezer; sloupec++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }
        }
    }
}
