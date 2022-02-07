using System;

namespace _06_Methods_01_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pozdrav();

            PozdravNekoho("Karel");
            PozdravNekoho("Eliška");

            string[] lidi = { "Adam", "Božena", "Cyril", "Dana" };
            for (int i = 0; i < lidi.Length; i++)
            {
                PozdravNekoho(lidi[i]);
            }
        }

        //podprogram - subrutina, procedura/funkce, metoda - pojmenovaný kus kódu
        static void Pozdrav()
        {
            Console.WriteLine("Nazdar!");
        }

        static void PozdravNekoho(string jmeno)
        {
            Console.WriteLine($"Ať žije {jmeno}!");
        }
    }
}
