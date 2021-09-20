using System;

namespace _01_Uvod_04_Char_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 znak = character
            char pismenko = ':';
            char nacteno = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine("Stiskl jsi " + nacteno);

            //Console.WriteLine("Stiskni libovolnou klávesu pro ukončení.");
            //Console.ReadKey();

        }
    }
}
