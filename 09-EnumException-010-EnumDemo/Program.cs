using System;

namespace _09_EnumException_010_EnumDemo
{
    enum Obdobi : byte { Jaro = 1, Leto, Podzim, Zima };
    class Program
    {
        static void Main(string[] args)
        {
            Obdobi chladne = Obdobi.Jaro;
            Console.WriteLine(chladne);

            chladne++;
            Console.WriteLine(chladne);

            Obdobi horke = (Obdobi)1;
            Console.WriteLine(horke);

            Obdobi divne = (Obdobi)255;
            Console.WriteLine(divne);

        }
    }
}
