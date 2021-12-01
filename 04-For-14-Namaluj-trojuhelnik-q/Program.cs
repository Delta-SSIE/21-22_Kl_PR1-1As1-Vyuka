using System;

namespace _04_For_14_Namaluj_trojuhelnik_q
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak = '#';

            // zeptat se na délku
            Console.Write("Zadej stranu: ");

            // převést na číslo
            int strana = int.Parse(Console.ReadLine());

            // smyčka for - ukončím pro i = délce
            for (int y = 0; y < strana; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write("  ");
                }
                for (int x = y; x < strana; x++)
                {
                    //vypíšu znak
                    Console.Write(znak + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
