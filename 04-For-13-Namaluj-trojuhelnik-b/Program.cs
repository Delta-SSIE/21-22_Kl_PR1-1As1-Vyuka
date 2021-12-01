using System;

namespace _04_For_13_Namaluj_trojuhelnik_b
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
                for (int x = 0; x <= y; x++)
                {
                    //vypíšu znak
                    Console.Write(znak + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
