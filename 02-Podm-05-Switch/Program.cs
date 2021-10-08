using System;

namespace _02_Podm_05_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo dne");
            string vstup = Console.ReadLine();
            int den = int.Parse(vstup);

            string slovo;

            switch (den)
            {
                case 1:
                    slovo = "pondělí";
                    break;

                case 2:
                    slovo = "úterý";
                    break;

                //…

                case 7:
                    slovo = "neděle";
                    break;

                default:
                    slovo = "neznámý den";
                    break;
            }

            Console.WriteLine($"Dnes je {slovo}.");
        }
    }
}
