using System;

namespace _04_For_19_Kreslim_sachovnici
{
    class Program
    {
        static void Main(string[] args)
        {
            int strana = 8;

            //bool svetla = true;

            //for (int radek = 0; radek < strana; radek++)
            //{
            //    for(int sloupec = 0; sloupec < strana; sloupec++)
            //    {

            //        if (svetla)
            //            Console.BackgroundColor = ConsoleColor.DarkYellow;
            //        else
            //            Console.BackgroundColor = ConsoleColor.Black;
            //        Console.Write(" ");

            //        svetla = !svetla; 
            //    }
            //    Console.WriteLine();
            //    svetla = !svetla;
            //}

            for (int radek = 0; radek < strana; radek++)
            {
                for (int sloupec = 0; sloupec < strana; sloupec++)
                {

                    if ((radek + sloupec) %2 != 0)
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("  ");                    
                }
                Console.WriteLine();

            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
