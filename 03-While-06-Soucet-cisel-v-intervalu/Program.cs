using System;

namespace _03_While_06_Soucet_cisel_v_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kde začít: ");
            int dolniMez = int.Parse(Console.ReadLine());

            Console.Write("Kde skončit: ");
            int horniMez = int.Parse(Console.ReadLine());

            int soucet = 0;
            int pozice = dolniMez;

            while (pozice <= horniMez)
            {
                soucet += pozice;
                pozice++;
            }

            Console.WriteLine($"Součet všechn čísel od {dolniMez} do {horniMez} je {soucet}.");
        }
    }
}
