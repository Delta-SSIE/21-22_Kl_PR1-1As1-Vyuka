using System;

namespace _05_Array_03_Dlouhe_retezce
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocetSlov = 5;
            int minDelka = 6;

            //načítání
            string[] slova = new string[pocetSlov];

            for (int i = 0; i < slova.Length; i++)
            {
                Console.Write("Zadej slovo: ");
                slova[i] = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0; i < slova.Length; i++)
            {
                if (slova[i].Length >= minDelka)
                    Console.WriteLine(slova[i]);
            }
        }
    }
}
