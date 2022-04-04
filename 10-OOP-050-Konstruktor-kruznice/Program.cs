using System;

namespace _10_OOP_050_Konstruktor_kruznice
{
    class Program
    {
        static void Main(string[] args)
        {
            Kruznice k = new Kruznice(1);
            Console.WriteLine(k.Obvod());

            Kruznice l = new Kruznice();
            Console.WriteLine(l.Obvod());
        }
    }
}
