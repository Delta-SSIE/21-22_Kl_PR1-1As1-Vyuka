using System;

namespace _05_Array_05_Karty
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vysky = new string[]
            {
                "sedma",
                "osma",
                "devítka",
                "desítka",
                "spodek",
                "svršek",
                "král",
                "eso"
            };

            string[] barvy = new string[]
            {
                "srdce",
                "kule",
                "žaludy",
                "listy"
            };

            string[] karty = new string[vysky.Length * barvy.Length];

            //int poradi = 0;

            for (int i = 0; i < vysky.Length; i++)
            {
                for (int j = 0; j < barvy.Length; j++)
                {
                    string vyska = vysky[i];
                    string barva = barvy[j];
                    
                    karty[barvy.Length * i + j] = barva + " - " + vyska;

                    //karty[poradi] = barva + " - " + vyska;
                    //poradi++;
                }
            }

            //for (int i = 0; i < karty.Length; i++)
            //{
            //    Console.WriteLine(karty[i]);
            //}

            Random rnd = new Random();
            int nahodneCislo = rnd.Next(karty.Length); // náhodné číslo v rozsahu do 32, 
                                                // tedy indexy pole

            Console.WriteLine(karty[nahodneCislo]);
        }
    }
}
