using System;

namespace _04_For_27_Je_prvocislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");

            int cislo = int.Parse(Console.ReadLine());
            int hranice = (int)Math.Sqrt(cislo);

            bool jePrvocislo = true;

            // vyzkoušíme dělení všemi čísly mezi 2 a cislo
            for (int delitel = 2; delitel <= hranice; delitel++)
            {
                //je dělitelené?
                if (cislo % delitel == 0)
                {
                    jePrvocislo = false;
                    break;
                }
            }

            //odpoví - je / není prvočíslo
            Console.WriteLine($"{cislo} {(jePrvocislo ? "je" : "není")} prvočíslo.");
        }
    }
}
