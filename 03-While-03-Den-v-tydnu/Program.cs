using System;

namespace _03_While_Den_v_tydnu
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true) //nekonečná smyčka
            //{
                int cislo = 0;
                bool poprve = true;

                //while ( !(cislo >= 1 && cislo <= 7) )
                while (cislo < 1 || cislo > 7)
                {
                    if (!poprve)
                    {
                        Console.WriteLine("To není platné číslo");
                    }
                    else
                    {
                        poprve = false;
                    }

                    Console.Write("Zadej číslo dne (1-7): ");
                    cislo = int.Parse(Console.ReadLine());
                }

                string den = "";

                switch (cislo)
                {
                    case 1:
                        den = "pondělí";
                        break;
                    case 2:
                        den = "úterý";
                        break;
                    case 3:
                        den = "středa";
                        break;
                    case 4:
                        den = "čtvrtek";
                        break;
                    case 5:
                        den = "pátek";
                        break;
                    case 6:
                        den = "sobota";
                        break;
                    case 7:
                        den = "neděle";
                        break;
                }

                Console.WriteLine($"Dnes je {den}.");
            //} //konec nekonečné smyčky
        }
    }
}
