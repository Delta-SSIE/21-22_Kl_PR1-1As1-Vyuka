using System;

namespace _05_Array_12_PST_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000; //počet opakování
            int k = 2; // počet kostek
            int pocetStran = 6;

            int[] poctyHodu = new int[pocetStran + 1]; //nulu pak nepoužiju

            Random random = new Random();

            //házím, ukládám
            for (int i = 0; i < n; i++)
            {
                int padlo = random.Next(1, pocetStran + 1);
                poctyHodu[padlo] += 1;
            }

            double[] psti = new double[pocetStran + 1];
            for (int i = 0; i < poctyHodu.Length; i++)
            {
                psti[i] = (double)poctyHodu[i] / n;
            }

            Console.WriteLine("Hody:");
            for (int i = 1; i < poctyHodu.Length; i++)
            {
                Console.WriteLine($"{i}: {poctyHodu[i]}");
            }

            Console.WriteLine("Pravděpodobnosti:");
            for (int i = 1; i < psti.Length; i++)
            {
                Console.WriteLine($"{i}: {psti[i]:0.000}");
            }
        }
    }
}
