using System;

namespace _01_Uvod_05_Cisla_a_format
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine($"Pí je {pi} .");

            double zaokrouhleno = Math.Round(pi, 3); //zaokrouhli na tři místa
            Console.WriteLine($"Zaokrouhleno je to {zaokrouhleno} .");

            //formátovaný výpis
            Console.WriteLine($"Lze zobrazit s formátováním jako {pi:0.00000}");
        }
    }
}
