using System;

namespace _05_Array_10_HIstogram_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = { 100, 300, 200, 400, 700, 1200, 400 };
            //int delkaRadky = 80;
            int delkaRadky = Console.BufferWidth - 1;

            int zacatecniZnaky = 3;

            // zjistit největší
            int nejvetsi = hodnoty[0];
            for (int i = 0; i < hodnoty.Length; i++)
            {
                if (nejvetsi < hodnoty[i])
                {
                    nejvetsi = hodnoty[i];
                }
            }


            // zjistit měřítko
            double meritko = (double)(delkaRadky - zacatecniZnaky)/ nejvetsi;

            //vypsat jako předchozí (ale násobit měřítkem)
            for (int i = 0; i < hodnoty.Length; i++)
            {
                double pocet = hodnoty[i] * meritko;

                Console.Write($"{i}: ");

                for (int j = 0; j < pocet; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
