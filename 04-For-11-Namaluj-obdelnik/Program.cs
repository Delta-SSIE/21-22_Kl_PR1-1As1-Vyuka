using System;

namespace _04_For_11_Namaluj_obdelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak = '#';

            // zeptat se na délku
            Console.Write("Zadej délku: ");

            // převést na číslo
            int sirka = int.Parse(Console.ReadLine());


            // zeptat se na výšku
            Console.Write("Zadej výšku: ");

            // převést na číslo
            int vyska = int.Parse(Console.ReadLine());


            // smyčka for - ukončím pro i = délce
            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < sirka; x++)
                {
                    //vypíšu znak
                    Console.Write(znak + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
