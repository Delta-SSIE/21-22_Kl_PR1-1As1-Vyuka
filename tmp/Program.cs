using System;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();



            int soucet = 0;



            int pocethodu = 0;



            do

            {

                int randomNumber = rd.Next(0, 10);



                soucet += randomNumber;



                if (randomNumber == 1)

                {

                    Console.WriteLine(1);

                }



                pocethodu++;



            } while (!(soucet >= 200));



            Console.WriteLine("K překonání nebo dosáhnutí hodnoty 200 jsem potřeboval {0} hodů.", pocethodu);
        }
    }
}
