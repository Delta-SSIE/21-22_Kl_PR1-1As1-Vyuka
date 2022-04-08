using System;

namespace _10_OOP_070_Ucet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet beznyUcet = new Ucet();
            beznyUcet.Uloz(1500);
            Console.WriteLine($"Stav účtu je {beznyUcet.Zustatek}.");

            beznyUcet.Uloz(500);
            Console.WriteLine($"Stav účtu je {beznyUcet.Zustatek}.");

            double castka = 700;

            for (int i = 0; i < 3; i++)
            {
                if (beznyUcet.Vyber(castka))
                {
                    Console.WriteLine($"Vybral jsem {castka}, stav účtu je {beznyUcet.Zustatek}.");
                }
                else
                {
                    Console.WriteLine($"Na účtu není dost k výběru {castka}");
                }
            }

            Ucet sporeni = new Ucet();
            sporeni.Uloz(100);
            double urokovaMira = 3;

            int roky = 0;
            while (sporeni.Zustatek < 200)
            {
                roky++;
                sporeni.Urokuj(urokovaMira);
            }

            Console.WriteLine(roky);

            //trochu protismylsne - banka ulozi do nas
            Ucet hypoteka = new Ucet();
            hypoteka.Uloz(5000000);
            urokovaMira = 4.5;
            double rocniSplatka = 300000;

            roky = 0;
            while (true)
            {
                hypoteka.Urokuj(urokovaMira);
                roky++;
                if (!hypoteka.Vyber(rocniSplatka))
                {
                    double zaplaceno = (roky - 1) * rocniSplatka + hypoteka.Zustatek;
                    Console.WriteLine($"Spláceno {roky} let, v poslední zaplatíme už jen {hypoteka.Zustatek}, celkem zaplaceno {zaplaceno}.");
                    
                    break;
                }
            }

        }
    }
}
