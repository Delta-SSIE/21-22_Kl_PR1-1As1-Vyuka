using System;

namespace _03_While_02_Pocitani
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cislo = 0;

            //while (cislo < 101)
            //{
            //    Console.WriteLine(cislo);
            //    cislo += 10;
            //}

            int cislo = 100;

            while (cislo > -1)
            {
                Console.WriteLine(cislo);
                cislo -= 10;
            }

        }
    }
}
