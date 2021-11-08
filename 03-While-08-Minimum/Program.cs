using System;

namespace _03_While_08_Minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            // chceme najít minimum z 5 vložených čísel

            //int pocet = 5; //počet průchodů
            //int i = 0; //pokolikáté

            //int maximum = int.MinValue;            

            //while (i < pocet) 
            //{
            //    Console.Write($"Zadej {i}. číslo: ");

            //    int cislo = int.Parse(Console.ReadLine());
            //    if (cislo > maximum)
            //        maximum = cislo;

            //    i++;
            //}

            //Console.WriteLine($"Maximum bylo {maximum}.");


            /* ukončení N */

            //int i = 0; //pokolikáté
            //int maximum = int.MinValue;

            //string vstup = "";

            //while (vstup.ToUpper() != "N")
            //{
            //    Console.Write($"Zadej {i}. číslo: ");

            //    vstup = Console.ReadLine();

            //    if (int.TryParse(vstup, out int cislo)) 
            //    { 
            //        if (cislo > maximum)
            //            maximum = cislo;

            //        i++;
            //    }
            //    else if (vstup.ToUpper() != "N")
            //    {
            //        Console.WriteLine("To není platný vstup");
            //    }

            //}

            //Console.WriteLine($"Maximum bylo {maximum}.");


            /* jiné ukončení */

            int i = 0; //pokolikáté
            int maximum = int.MinValue;

            string vstup = "";

            while (true)
            {
                Console.Write($"Zadej {i}. číslo: ");

                vstup = Console.ReadLine(); //načtu

                if (vstup.ToUpper() == "N") //ukončení při příkazu N
                    break;

                if (int.TryParse(vstup, out int cislo)) //zkusím převést
                {
                    if (cislo > maximum) //když lze převést, můžu aktualizovat maximum
                        maximum = cislo;

                    i++;
                }
                else
                {
                    Console.WriteLine("To není platný vstup"); //když nelze převést, varuju
                }

            }

            Console.WriteLine($"Maximum bylo {maximum}.");

        }

    }
}
