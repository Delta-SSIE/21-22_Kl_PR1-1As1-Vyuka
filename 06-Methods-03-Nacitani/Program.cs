using System;

namespace _06_Methods_03_Nacitani
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok = NactiInt("Zadej rok narození:");
            int mesic = NactiInt("Zadej rok narození:", "To se mi nelíbí");
        }

        static int NactiInt(string vyzva, string chyboveHlaseni = "To není celé číslo, zkus to znovu.")
        {
            Console.WriteLine(vyzva);

            int cislo;
            
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine(chyboveHlaseni);
            }
            return cislo;
        }
    }
}
