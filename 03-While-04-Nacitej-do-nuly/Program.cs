using System;

namespace _03_While_04_Nacitej_do_nuly
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cislo = -1; //dám tam cokoli - nepoužije se
            //int suma = 0;

            //while (cislo != 0)
            //{
            //    Console.Write("Zadej číslo, nula ukončí: ");
            //    cislo = int.Parse(Console.ReadLine());
            //    suma += cislo;
            //}

            //Console.WriteLine("Součet je " + suma);

            string vstup;
            int suma = 0;

            do
            {
                Console.Write("Zadej číslo, 'N' ukončí: ");

                vstup = Console.ReadLine();

                if (vstup != "N")
                {
                    int cislo = int.Parse(vstup);
                    suma += cislo;
                }
                
            }
            while (vstup != "N");

            Console.WriteLine("Součet je " + suma);
        }
    }
}
