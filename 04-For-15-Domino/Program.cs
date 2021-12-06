using System;

namespace _04_For_15_Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i <= j; i++)
                {
                    Console.Write($"{i}|{j}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
