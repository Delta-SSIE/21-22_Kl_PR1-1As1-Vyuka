using System;

namespace _01_Uvod_07_Kolik_lidi_uveze_vytah
{
    class Program
    {
        static void Main(string[] args)
        {
            string vstup;

            //zeptám se na nosnost a uložím jako číslo
            Console.WriteLine("Kolik je nosnost výtahu? ");
            vstup = Console.ReadLine();
            int nosnost = int.Parse(vstup);

            //zeptám se na váhu člověka a uložím jako číslo
            Console.WriteLine("Kolik váží člověk? ");
            vstup = Console.ReadLine();
            int hmotnostOsoby = int.Parse(vstup);

            //vypočítám, kolik lidí
            int pocetOsob = nosnost / hmotnostOsoby;
            
            //vypíšu
            Console.WriteLine($"Výtah o nosnosti {nosnost} uveze {pocetOsob} lidí o hmotnosti {hmotnostOsoby}.");
        }
    }
}
