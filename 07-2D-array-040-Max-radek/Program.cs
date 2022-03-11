using System;

namespace _07_2D_array_040_Max_radek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] cisla =
            {
                { 1, 3, 5, 7 },
                { 2, 4, 6, 8 },
                {-1, 0, 1, 0 }
            };

            string jmeno = "Karel";
            string dlouhe = jmeno.PadLeft(10, '-');
            Console.WriteLine(dlouhe);

            Console.WriteLine("".PadRight(6, '-'));

            Console.WriteLine(MaxRadek(cisla));
        }

        static int MaxRadek(int[,] tabulka)
        {
            //vytvořím proměnnou pro výsledný index a max součet
            int maxIndex = 0;

            //posčítám první řádek
            int maxSoucet = 0;
            for (int x = 0; x < tabulka.GetLength(1); x++)
            {
                maxSoucet += tabulka[0, x];
            }

            //půjdu po řádcích
            for (int y = 1; y < tabulka.GetLength(0); y++)
            {
                int radkovySoucet = 0;
                //v každém řádku projdu všechny hodnoty a sečtu je
                for (int x = 0; x < tabulka.GetLength(1); x++)
                {
                    radkovySoucet += tabulka[y, x];
                }

                //když je součet větší než zapamatovaný, zapíšu si nový max součet a index
                if (radkovySoucet > maxSoucet)
                {
                    maxSoucet = radkovySoucet;
                    maxIndex = y;
                }
            }
            //vrátím nalezený index
            return maxIndex;

        }
    }
}
