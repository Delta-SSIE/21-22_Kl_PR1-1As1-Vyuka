using System;

namespace _01_Uvod_04_Uprava
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej délku strany čtverce: ");

            string zadano = Console.ReadLine();
            double strana = double.Parse(zadano);

            double obsah = strana * strana;

            //Console.WriteLine("Obsah čtverce o straně " + strana + " je " + obsah + ".");
            Console.WriteLine($"Obsah čtverce o straně {strana} je {obsah}.");
        }
    }
}
