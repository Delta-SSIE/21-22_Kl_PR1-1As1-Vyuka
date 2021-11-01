using System;

namespace _03_While_05_Kdy_ta_setka_padne
{
    class Program
    {
        static void Main(string[] args)
        {
            //generator RND
            Random rnd = new Random();

            int opakovani = 10000000;
            int i = 0;

            int max = 0;
            int soucet = 0;

            while (i < opakovani)
            {

                //udělám si počítadlo na hody
                int hody = 0;

                // proměnná, abych ji mohl použít v podmínce while
                int cislo;

                do
                {
                    //generuju náhodná čísla
                    cislo = rnd.Next(1, 7);

                    //zvýším počítadlo
                    hody++;
                }
                while (cislo != 6);
                //dokud to není 6

                soucet += hody;

                if (hody > max)
                    max = hody;

                //Console.WriteLine($"Potřeboval jsem {hody} pokusů.");

                i++;
            }

            double prumer = (double)soucet / opakovani;

            Console.WriteLine($"Průměrně čekám {prumer:0.00} krát, nejdéle {max} krát.");
        }
    }
}
