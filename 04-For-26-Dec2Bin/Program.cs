using System;

namespace _04_For_26_Dec2Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 199;
            string bin = "";

            //děl 2 tak dlouho, dokud je co
            do
            {
                // poznamenej si vždy zbytek (napiš ho před předchozí zbytky)
                int zbytek = dec % 2;
                bin = zbytek + bin; //skládá číslo a řetězec

                dec /= 2;
            } 
            while (dec > 0);

            Console.WriteLine(bin);
        }
    }
}
