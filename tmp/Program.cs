using System;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int soucet = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Zadej cislo: ");
            //    int cislo = int.Parse(Console.ReadLine());
            //    if (cislo %2 == 0)
            //        soucet += cislo;
            //}

            //Console.WriteLine(soucet);

            //int soucet = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    int cislo;
            //    do
            //    {
            //        Console.Write("Zadej cislo: ");
            //        cislo = int.Parse(Console.ReadLine());

            //    } while (cislo % 2 == 1);

            //    soucet += cislo;
            //}

            //Console.WriteLine(soucet);


            int soucet = 0;
            int sude = 0;
            while (sude < 10)
            {
                Console.Write("Zadej cislo: ");
                int cislo = int.Parse(Console.ReadLine());
                if (cislo % 2 == 0)
                {
                    soucet += cislo;
                    sude++;
                }                    
            }
        }
    }
}
