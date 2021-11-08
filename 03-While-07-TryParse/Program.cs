using System;

namespace _03_While_07_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Napiš číslo: ");
            //string vstup = Console.ReadLine();

            //int cislo; //deklaruje proměnnou - při praví pro ni paměť
            //if (int.TryParse(vstup, out cislo)) //zkusí parsovat, výsledek vloží do cislo
            //    //vrátí true/false zda se povedlo
            //{ 
            //    Console.WriteLine($"Zapsal jsi {cislo}.");
            //}
            //else
            //{
            //    Console.WriteLine("To není číslo, troubo!");
            //}


            //int cislo; //deklaruje proměnnou - při praví pro ni paměť
            //string vstup;

            //do
            //{
            //    Console.WriteLine("Napiš číslo: ");
            //    vstup = Console.ReadLine();
            //}
            //while (!int.TryParse(vstup, out cislo));

            //Console.WriteLine($"Zapsal jsi {cislo}.");




            int cislo; //deklaruje proměnnou - při praví pro ni paměť
            bool success = true;

            do
            {
                if (!success)
                    Console.WriteLine("To není číslo!");

                Console.WriteLine("Napiš číslo: ");

                success = int.TryParse(Console.ReadLine(), out cislo);
            }
            while (!success);

            Console.WriteLine($"Zapsal jsi {cislo}.");



            //int cislo; //deklaruje proměnnou - při praví pro ni paměť
            //Console.WriteLine("Napiš číslo: ");

            //while ( !int.TryParse( Console.ReadLine(), out cislo) )
            //{
            //    Console.WriteLine("Řekl jsem číslo! Zadej číslo: ");                
            //};

            //Console.WriteLine($"Zapsal jsi {cislo}.");

        }
    }
}
