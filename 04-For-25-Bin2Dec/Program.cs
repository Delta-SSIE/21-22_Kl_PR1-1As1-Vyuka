using System;

namespace _04_For_25_Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = "10110100";
            int vysledek = 0;

            //začni s hodnotou 1
            int hodnota = 1;

            //jdi odzadu
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                //když je v řetězci 1, přičti hodnotu
                if (bin[i] == '1')
                    vysledek += hodnota;

                //zdvojnásob hodnotu
                hodnota *= 2;
            }

            Console.WriteLine(vysledek);
            
        }
    }
}
