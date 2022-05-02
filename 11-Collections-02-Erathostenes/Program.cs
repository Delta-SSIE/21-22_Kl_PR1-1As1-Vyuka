using System;
using System.Collections.Generic;
using System.IO;

namespace _11_Collections_02_Erathostenes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine( string.Join(',', Primes(1000)) );

            int[] primes = Primes(10000000);
            int chunk = 10000;

            int n = 0;
            int maxLimit = chunk;

            using (StreamWriter sw = new StreamWriter("primes.txt"))
            {

                for (int i = 0; i < primes.Length; i++)
                {
                    if (primes[i] > maxLimit)
                    {
                        sw.WriteLine(n);
                        n = 0;
                        maxLimit += chunk;
                    }
                    else
                        n++;
                }
            }
        }

        static int[] Primes (int max)
        {
            List<int> primes = new List<int>();

            bool[] numbers = new bool[max + 1];
            numbers[0] = false;
            numbers[1] = false;
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = true; //podezřelé jako prvočísla
            }

            //int maxDivisor = (int)Math.Sqrt(numbers.Length);
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == false) //už vím že není prvočíslo
                    continue;

                primes.Add(i);
                //teď vím, že je prvočíslo
                for (int j = 2 * i; j < numbers.Length; j+=i)
                {
                    numbers[j] = false;//označím násobky jako neprvočísla
                }
            }

            return primes.ToArray();
        }
    }
}
