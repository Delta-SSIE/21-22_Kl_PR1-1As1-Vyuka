using System;

namespace _05_Array_11_PST_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocetStran = 12;
            int n = 1000000; //pocet opakovaní
            int[] poctyHodu = new int[pocetStran + 1]; //nulu pak nepoužiju

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int padlo = random.Next(1, pocetStran+1);
                poctyHodu[padlo] += 1;
            }

            double[] psti = new double[pocetStran+1];
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
