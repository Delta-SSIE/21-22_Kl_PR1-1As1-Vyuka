using System;

namespace _06_Methods_02_Navratova_hodnota
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(Zvys(3));

            //int cislo = 5;
            //int vyssi = Zvys(cislo);
            //Console.WriteLine(vyssi);

            Console.WriteLine(VyssiSude(4));
            Console.WriteLine(VyssiSude(5));

            double i = 1.3;
            double j = -3.4;
            double suma = Secti(i, j);
            Console.WriteLine(suma);
        }

        //syntaxe: static datovy_typ_navratu NazevMetody (typ_parametru nazev_parametru, ...)
        static int Zvys(int cislo)
        {
            return cislo + 1;
        }

        static int VyssiSude (int cislo)
        {
            //když je sudé
            if (cislo % 2 == 0)
                return cislo + 2;

            else
                return cislo + 1;


            Console.WriteLine("Sem se nechodí");
        }

        static double Secti (double a, double b)
        {
            return a + b;
        }
    }
}
