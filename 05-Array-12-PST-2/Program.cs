using System;

namespace _05_Array_12_PST_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000; //počet opakování
            int k = 3; // počet kostek
            int pocetStran = 6;

            int[] poctyHodu = new int[pocetStran * k + 1]; //nulu pak nepoužiju

            Random random = new Random();

            //házím, ukládám
            for (int i = 0; i < n; i++)
            {
                int soucet = 0;
                for (int j = 0; j < k; j++)
                {
                    int padlo = random.Next(1, pocetStran + 1);
                    soucet += padlo;
                }

                poctyHodu[soucet] += 1;
            }

            double[] psti = new double[pocetStran * k + 1];
            for (int i = 0; i < poctyHodu.Length; i++)
            {
                psti[i] = (double)poctyHodu[i] / n;
            }

            Console.WriteLine("Hody:");
            for (int i = k; i < poctyHodu.Length; i++)
            {
                Console.WriteLine($"{i}: {poctyHodu[i]}");
            }

            Console.WriteLine("Pravděpodobnosti:");
            for (int i = k; i < psti.Length; i++)
            {
                Console.WriteLine($"{i}: {psti[i]:0.000}");
            }
        }
    }
}
