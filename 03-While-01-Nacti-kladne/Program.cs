using System;

namespace _03_While_01_Nacti_kladne
{
    class Program
    {
        static void Main(string[] args)
        {
            double cislo = -1;

            while (cislo <= 0)
            {
                Console.Write("Zadej kladné číslo: ");
                string vstup = Console.ReadLine();
                cislo = double.Parse(vstup);
            }

            Console.WriteLine($"Zadal jsi číslo {cislo}.");
        }
    }
}
