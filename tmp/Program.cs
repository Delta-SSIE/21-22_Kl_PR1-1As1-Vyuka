using System;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jak velky chces obrazek?");

            int n = int.Parse(Console.ReadLine());



            while (n <= 0)

            {

                if (n <= 0)

                {

                    Console.WriteLine("Neplatny udaj");

                }

                Console.WriteLine("Jak velky chces obrazek?");

                n = int.Parse(Console.ReadLine());

            }



            string text = "" + n;

            string text1 = "";

            int j;

            for (int i = 1; i < n; i++)

            {

                string cislo = "";

                cislo += n;

                text = "";

                text1 = "";



                for (j = 0; j < i; j++)

                {

                    text += cislo;

                }

                text += cislo;

                Console.WriteLine(text);

                for (int l = 0; l < n; l++)

                {

                    {

                        for (int k = j; k > 0; k--)

                        {

                            text1 += cislo;

                        }



                        Console.WriteLine(text1);

                    }

                }





            }

        }
    }
}
