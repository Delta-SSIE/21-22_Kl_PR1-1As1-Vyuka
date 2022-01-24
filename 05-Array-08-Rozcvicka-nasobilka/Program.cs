using System;

namespace _05_Array_08_Rozcvicka_nasobilka
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo;

            Console.Write("Zadej celé číslo: ");
            while (!int.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("To není celé číslo, zkus to znovu: ");
            }

            int[] nasobilka = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nasobilka[i] = cislo * (i+1);
            }

            for (int i = nasobilka.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nasobilka[i]);
            }
        }

    }
}
