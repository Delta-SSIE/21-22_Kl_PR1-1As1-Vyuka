using System;

namespace _02_Podm_01_Vetveni
{
    class Program
    {
        static void Main(string[] args)
        {
            //načtu číslo
            Console.Write("Zadej číslo: ");
            string vstup = Console.ReadLine();
            double cislo = double.Parse(vstup);

            //// když je číslo větší než 10
            //if (cislo > 10) //kulaté závorky nutné
            //{
            //    Console.WriteLine("Čislo je velké.");
            //}
            //else //v opačném případě
            //{
            //    Console.WriteLine("Čislo je malé.");
            //}

            // když je číslo větší než 100
            if (cislo > 100) 
            {
                Console.WriteLine("Čislo je fakt velké.");
            }
            else if (cislo == 42)
            {
                Console.WriteLine("Číslo je dokonalé.");
            }
            else if (cislo > 10) //kulaté závorky nutné
            {
                Console.WriteLine("Čislo je velké.");
            }
            else //v opačném případě
            {
                Console.WriteLine("Čislo je malé.");
            }


        }
    }
}
