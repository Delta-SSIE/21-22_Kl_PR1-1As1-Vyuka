using System;

namespace _10_OOP_060_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Kruznice k = new Kruznice(10);
            Console.WriteLine(k.Polomer);

            k.Polomer = 1;
            Console.WriteLine(k.Obvod());

            try
            {
                k.Polomer = -7;

            }
            catch
            {
                Console.WriteLine("Děláš něco špatně");
            }
            Console.WriteLine(k.Polomer);

            if (k.JeMala)
                Console.WriteLine("Kružnice je malá");
            else
                Console.WriteLine("Kružnice je macek");

            
        }
    }
}
