using System;

namespace _05_Array_13_PST_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1000000; //počet opakování
            int k = 8; // počet kostek
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

            //Console.WriteLine("Hody:");
            //for (int i = k; i < poctyHodu.Length; i++)
            //{
            //    Console.WriteLine($"{i}: {poctyHodu[i]}");
            //}

            //Console.WriteLine("Pravděpodobnosti:");
            //for (int i = k; i < psti.Length; i++)
            //{
            //    Console.WriteLine($"{i}: {psti[i]:0.000}");
            //}



            //int[] poctyHodu = { 100, 300, 200, 400, 700, 1200, 400 };
            //int delkaRadky = 80;
            int delkaRadky = Console.BufferWidth - 1;

            int zacatecniZnaky = 3;

            // zjistit největší
            int nejvetsi = poctyHodu[0];
            for (int i = 0; i < poctyHodu.Length; i++)
            {
                if (nejvetsi < poctyHodu[i])
                {
                    nejvetsi = poctyHodu[i];
                }
            }


            // zjistit měřítko
            double meritko = (double)(delkaRadky - zacatecniZnaky) / nejvetsi;

            //vypsat jako předchozí (ale násobit měřítkem)
            for (int i = k; i < poctyHodu.Length; i++)
            {
                double pocet = poctyHodu[i] * meritko;

                Console.Write($"{i:00}: ");

                for (int j = 0; j < pocet; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
