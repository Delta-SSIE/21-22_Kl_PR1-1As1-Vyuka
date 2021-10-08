using System;

namespace _02_Podm_03_Retezeni
{
    class Program
    {
        static void Main(string[] args)
        {
            //načetl bych
            int n = int.Parse(Console.ReadLine());

            //if (n == 6)
            //{
            //    Console.WriteLine("Je víkend");
            //}
            //else if (n == 7)
            //{
            //    Console.WriteLine("Je víkend");
            //}
            //else
            //    Console.WriteLine("Není víkend");

            if (n == 6 || n == 7)
            {
                Console.WriteLine("Je víkend");
            }            
            else
                Console.WriteLine("Není víkend");
        }
    }
}
