using System;

namespace _04_For_02_Jsou_vsechna_licha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik čísel se bude testovat: ");
            //int opakovani;
            //while(!int.TryParse(Console.ReadLine(), out opakovani))
            //{
            //    Console.WriteLine("To není celé číslo, zkus to znovu: ");
            //}
            int opakovani = int.Parse(Console.ReadLine());

            bool VsechnaJsouLicha = true;

            for (int i = 0; i < opakovani; i++)
            {
                Console.Write("Zadej další číslo: ");
                int cislo = int.Parse(Console.ReadLine());

                if (cislo % 2 == 0)
                {
                    VsechnaJsouLicha = false;
                    break;
                }                    
            }


            if (VsechnaJsouLicha)
                Console.WriteLine("Všechna zadaná čísla byla lichá.");
            else
                Console.WriteLine("Vyskytlo se sudé číslo.");

        }
    }
}
