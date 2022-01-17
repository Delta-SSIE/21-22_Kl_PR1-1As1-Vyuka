using System;

namespace _05_Array_02_Soucet_hodnot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { 1, 4, 9, 16, 25, 36 };

            int soucet = 0;

            for (int i = 0; i < cisla.Length; i++)
            {
                soucet += cisla[i];
            }

            Console.WriteLine("Součet všech prvků v poli je {0}.", soucet);
        }
    }
}
