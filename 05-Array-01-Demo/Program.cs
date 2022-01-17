using System;

namespace _05_Array_01_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] jmena = new string[5];

            //jmena[0] = "Karel";
            //jmena[1] = "Milan";
            //jmena[2] = "Josef";
            //jmena[3] = "Gertruda";
            //jmena[4] = "Lída";

            //for (int i = 0; i < jmena.Length; i++)
            //{
            //    Console.WriteLine("Na večeři přijde i " + jmena[i]);
            //}

            //Console.WriteLine(string.Join(", ", jmena));

            int pocet = 5;

            string[] jmena = new string[pocet];

            for (int i = 0; i < jmena.Length; i++)
            {
                Console.Write("Zadej jméno: ");
                jmena[i] = Console.ReadLine();
            }

            for (int i = 0; i < jmena.Length; i++)
            {
                Console.WriteLine("Na večeři přijde i " + jmena[i]);
            }

            //inicializace seznamem
            int[] cisla = new int[] { 1, 5, 12 };
            string[] kamaradi = new string[]
            {
                "Petra",
                "Pavel",
                "Richard"
            };

        }
    }
}
