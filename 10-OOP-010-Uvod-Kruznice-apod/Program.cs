using System;

namespace _10_OOP_010_Uvod_Kruznice_apod
{
    class Program
    {
        static void Main(string[] args)
        {
            Kruznice k = new Kruznice();
            k.Polomer = 1;
            Console.WriteLine(k.Obvod());


            Kruznice l = new Kruznice();
            l.Polomer = 10;

            Console.WriteLine(  l.Obvod() );

            Kruznice m = new Kruznice();
            //m = 10; tohle nepůjde

            //Console.CursorVisible = true;

        }
    }
}
