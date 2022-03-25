using System;

namespace _09_EnumExceptions_030_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadej číslo");
            //string vstup = Console.ReadLine();
            //try
            //{
            //    int cislo = int.Parse(vstup);
            //    Console.WriteLine(cislo);
            //}
            //catch
            //{
            //    Console.WriteLine("Číslo nemá platný formát");
            //}
            //finally
            //{
            //    //toto by se vykonalo vždy
            //}

            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double d = SafeDivision(a, b);
                Console.WriteLine(d);
            }
            catch (FormatException)
            {
                Console.WriteLine("nebylo zadáno platné číslo");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("nulou se nedělí");
            }
            catch //všechny ostatní typy
            {
                Console.WriteLine("Došlo k neočekávané chybě");
            }
        }

        public static double SafeDivision (double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }
    }
}
