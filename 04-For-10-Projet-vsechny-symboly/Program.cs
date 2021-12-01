using System;

namespace _04_For_10_Projet_vsechny_symboly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej kód: ");
            string kod = Console.ReadLine();

            //zde by mela byt kontrola, ze kod je jen ctyrmistne cislo z cislic 1-8

            bool nalezeno = false;
            for (int i = 1; i < 3 && !nalezeno; i++)
            {
                for (int j = 1; j < 3 && !nalezeno; j++)
                {
                    for (int k = 1; k < 3 && !nalezeno; k++)
                    {
                        for (int l = 1; l < 3 && !nalezeno; l++)
                        {
                            string retezec = "" + i + j + k + l;
                            if (retezec == kod) { 
                                Console.WriteLine($"Řešení je {retezec}");
                                nalezeno = true;
                            }
                        }
                    }
                }
                
            }



        }
    }
}
