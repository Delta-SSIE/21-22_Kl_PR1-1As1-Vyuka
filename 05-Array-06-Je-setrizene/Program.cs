using System;

namespace _05_Array_06_Je_setrizene
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] cisla = { -5, 4.3, 2.7, 6.41, 12 }; //není
            //double[] cisla = { -5, 2.7, 4.3, 6.41, 12 }; //je
            double[] cisla = { -5, 2.7, 2.7, 4.3, 6.41, 12 }; //je

            bool jeSetrizene = true; //dokud nenajdu chybu, předpokládám, 
                                     //že je pole setřízené

            for (int i = 0; i < cisla.Length - 1; i++)
            {
                double cisloTed = cisla[i];
                double cisloDalsi = cisla[i + 1];
                if (cisloDalsi < cisloTed)
                {
                    jeSetrizene = false;
                    break; //nemusím dál hledat - není setřízeno
                }
            }

            //if (jeSetrizene)
            //    Console.WriteLine("Pole je setřízené.");
            //else
            //    Console.WriteLine("Pole není setřízené.");

            Console.WriteLine($"Pole {(jeSetrizene ? "je" : "není")} setřízené.");
        }
    }
}
