using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_Array_14_Rozdeleni_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 7, -11, 0, 12, 4, -5, -5, -6, 2 };


            //vytvořit dvě pod-pole - ale jak velká?
            // musím projít a spočítat
            int kladna = 0;
            int zaporna = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > 0)
                    kladna++;
                else if (pole[i] < 0)
                    zaporna++;
            }

            //teď už vim, můžu vytvořit menší pole
            int[] kladnePrvky = new int[kladna];
            int[] zapornePrvky = new int[zaporna];

            int poziceKladne = 0;
            int poziceZaporne = 0;

            //projdu podruhé a roztřídím
            for (int i = 0; i < pole.Length; i++)
            {
                int prvek = pole[i];

                if (prvek > 0)
                {
                    kladnePrvky[poziceKladne] = prvek;
                    poziceKladne++;
                }
                else if (prvek < 0)
                {
                    zapornePrvky[poziceZaporne] = prvek;
                    poziceZaporne++;
                }
            }

            //vypíšu
            Console.WriteLine(string.Join(",", kladnePrvky));
            Console.WriteLine(string.Join(",", zapornePrvky));


            //jinak - s pomocí listu
            List<int> kladneList = new List<int>();
            List<int> zaporneList = new List<int>();

            for (int i = 0; i < pole.Length; i++)
            {
                int prvek = pole[i];

                if (prvek > 0)
                {
                    kladneList.Add(prvek);
                }
                else if (prvek < 0)
                {
                    zaporneList.Add(prvek);
                }
            }

            Console.WriteLine(string.Join(",", kladneList));
            Console.WriteLine(string.Join(",", zaporneList));


            //ještě jinak - LINQ
            int[] kladneLinq = pole.Where(x => x > 0).ToArray();
            int[] zaporneLinq = pole.Where(x => x < 0).ToArray();
            Console.WriteLine(string.Join(",", kladneLinq));
            Console.WriteLine(string.Join(",", zaporneLinq));

        }
    }
}
