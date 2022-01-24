using System;

namespace _05_Array_09_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] hodnoty = { 1, 3, 2, 4, 7, 12, 4 };
            
            for (int i = 0; i < hodnoty.Length; i++)
            {
                int pocet = hodnoty[i];

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
