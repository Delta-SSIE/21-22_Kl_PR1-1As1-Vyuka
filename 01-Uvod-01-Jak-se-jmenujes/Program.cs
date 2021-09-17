using System;

namespace _01_Uvod_01_Jak_se_jmenujes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tento řádek vypíše No nazdar
            // Console.WriteLine("No nazdar");

            /* Více-
              řádkový
              konimentář
             */

            //deklarace proměnné jmeno ("Bude se používat")
            //string jmeno;

            //inicializace proměnné jmeno ("Dám do ní poprvé hodnotu")
            //jmeno = "Karel";


            //deklarace a inicializace současně
            //string jmeno = "Vít";

            string jmeno;

            Console.Write("Jak se jmenuješ: "); //vyzvu uživatele, aby zadal jméno
            jmeno = Console.ReadLine(); //čeká na enter a vrátí do proměnné hodnotu z klávesnice

            Console.WriteLine("Ať žije " + jmeno + "!");
        }        
    }
}
