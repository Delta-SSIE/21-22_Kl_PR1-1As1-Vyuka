using System;

namespace _03_While_10_Prumerny_hod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik má kostka stěn: ");
            
            int pocetSten;
            while (!int.TryParse(Console.ReadLine(), out pocetSten) || pocetSten < 1) //dokud zadává nesmysle nebo je počet menší než 1
            {
                Console.Write("To není platné číslo, zkus to znovu: ");
            }

            Console.Write("Kolikrát si mám hodit: ");

            int pocetHodu;
            while (!int.TryParse(Console.ReadLine(), out pocetHodu) || pocetHodu < 1) //dokud zadává nesmysle nebo je počet menší než 1
            {
                Console.Write("To není platné číslo, zkus to znovu: ");
            }


            //Genrátor náh. čísel
            Random rnd = new Random();

            int opakovani = 0;
            int soucetHodu = 0;

            while (opakovani < pocetHodu)
            {
                int tentoHod = rnd.Next(1, pocetSten + 1);
                soucetHodu += tentoHod;
                opakovani++;
            }

            double prumer = (double)soucetHodu / pocetHodu; //musím na int koukat jako na double, jinak bude dělení celočíselné

            Console.WriteLine($"Průměrně jsem na {pocetSten}-stěnné kostce hodil {prumer}.");
        }
    }
}
