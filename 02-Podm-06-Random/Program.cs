using System;

namespace _02_Podm_06_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            // Když potřebujeme v počítači náhodné číslo, použijeme tento postup:
            // (Prozatím si jej jenom zapamatujte, detaily si vysvětlíme později)

            // 1. vytvořím si generátor náhodných čísel takto:
            Random random = new Random();

            // Generátor potřebuju do celé aplikace jen jeden, nikdy by se vám
            // neměly objevit dva příkazy new Random() v jednom programu

            // A teď budu prosit generátor o "další" náhodné číslo. 
            // Musím mu dát dva parametry - spodní hranici a horní hranici

            int nahodne = random.Next(1, 5);
            Console.WriteLine(nahodne);
            // takhle vytvořím náhodné číslo mezi 1 a 4
            // dolní hranice 1 mezi hodnotami být může
            // horní hranice je první číslo, které tam být nemůže

            // Hodnotu samozřejmě mžu použít dál, třeba takto:
            string smer;
            if (nahodne == 0)
                smer = "na sever";
            else if (nahodne == 1)
                smer = "na jih";
            else if (nahodne == 2)
                smer = "na východ";
            else
                smer = "na západ";

            Console.WriteLine($"Jdu na {smer}.");


            Console.WriteLine();


            /* Hod mincí */

            // Podobně bych mohl udělat hod mincí.
            // Mince má dvě strany, proto použiju dvě hodnoty
            // nejjednodušší je 0 a 1
            int hod = random.Next(0, 2); //znovu dolní mez včetně, horní o 1 víc, než dovolené maximum
            
            if (hod == 0)
                Console.WriteLine("Padla panna.");
            else
                Console.WriteLine("Padl orel.");

            Console.WriteLine();

            /* Pozor */
            int cislo = random.Next(0, 1);
            Console.WriteLine(cislo); //tohle nikdy nevypíše nic jiného než nulu! Proč?
        }
    }
}
