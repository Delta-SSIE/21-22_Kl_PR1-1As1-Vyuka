using System;

namespace _01_Uvod_06_Kolik_let
{
    class Program
    {
        static void Main(string[] args)
        {
            //zeptat se na jméno a uložit
            Console.Write("Zadej jméno člověka: ");
            string jmeno = Console.ReadLine();

            //zeptat se na rok narození
            Console.Write("Zadej rok narození: ");
            string vstup = Console.ReadLine();

            //převést na vstup číslo a uložit
            int rokNarozeni = int.Parse(vstup);

            //vypočíst věk z roku narození a letošního roku
            int rokNyni = 2021;
            int vek = rokNyni - rokNarozeni;

            //vypsat odpověď
            Console.WriteLine($"{jmeno} je {vek} let starý.");
        }
    }
}
