using System;

namespace _01_Uvod_02_zvetseni_cisla
{
    class Program
    {
        static void Main(string[] args)
        {
            // celé číslo = integer (anglicky)
            //int cisloA = 15;
            //Console.WriteLine(cisloA); //vypíše jako řetězec



            // načti od uživatele číslo
            Console.WriteLine("Zadej celé číslo:");
            string nacteno = Console.ReadLine();

            //převedu na celé číslo
            //int cislo = int.Parse(nacteno);

            //převedu na desetinné číslo
            double desCislo = double.Parse(nacteno);

            // zvětši ho o 1
            //nacteno = nacteno + 1; //takhle nelze - spojí řetězce
            //cislo = cislo + 1;
            //cislo++;
            desCislo = desCislo + 1;

            // vypiš mu ho zpět

            //Console.WriteLine("Po zvětšení vychází " + cislo);
            Console.WriteLine("Po zvětšení vychází " + desCislo);

            
        }
    }
}
