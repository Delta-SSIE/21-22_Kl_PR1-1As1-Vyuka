using System;

namespace _05_Array_04_Teploty
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] teploty = { 13.7, 14.2, 14.3, 14.8, 15.2, 16.0, 16.3, 17.1 };

            int hodiny = 5;
            int minuty = 30;

            Console.WriteLine($" Čas  | Teplota");
            Console.WriteLine( "-------------");

            for (int i = 0; i < teploty.Length; i++)
            {

                Console.WriteLine($"{hodiny:00}:{minuty:00} | {teploty[i]:0.0}");
                minuty += 30;

                if(minuty >= 60)
                {
                    minuty -= 60;
                    hodiny++;
                }
            }
        }
    }
}
