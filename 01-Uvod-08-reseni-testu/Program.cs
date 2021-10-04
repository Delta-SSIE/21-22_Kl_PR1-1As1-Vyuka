using System;

namespace _01_Uvod_08_reseni_testu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej první dopravní prostředek, kterým chceš cestovat:");
            string dp1 = Console.ReadLine();

            Console.WriteLine("Zadej druhý dopravní prostředek, kterým chceš cestovat:");
            string dp2 = Console.ReadLine();

            Console.WriteLine($"Napiš jak daleko chceš cestovat dopravním prostředkem {dp1}:");
            string vstup1 = Console.ReadLine();
            double vzdalenost1 = double.Parse(vstup1);

            Console.WriteLine($"Napiš jak daleko chceš cestovat dopravním prostředkem {dp2}:");
            string vstup2 = Console.ReadLine();
            double vzdalenost2 = double.Parse(vstup2);

            double celkem = vzdalenost1 + vzdalenost2;

            Console.WriteLine($"Celková cesta dopravními prostředky {dp1} a {dp2} bude dlouhá {celkem} km.");
        }
    }
}
