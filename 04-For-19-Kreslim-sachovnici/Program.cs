using System;

namespace _04_For_19_Kreslim_sachovnici
{
    class Program
    {
        static void Main(string[] args)
        {
            int strana = 8;

            bool svetla = true;

            Console.Write("  ");
            for (int i = 0; i < strana; i++)
            {
                Console.Write((char)('A' + i) + " ");
            }

            Console.WriteLine();

            for (int radek = strana; radek > 0; radek--)
            {
                Console.Write(radek + " ");

                for (int sloupec = 0; sloupec < strana; sloupec++)
                {

                    if (svetla)
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("  ");

                    svetla = !svetla;
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" " + radek);
                Console.WriteLine();
                svetla = !svetla;
            }
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            for (int i = 0; i < strana; i++)
            {
                Console.Write((char)('A' + i) + " ");
            }

            //for (int radek = 0; radek < strana; radek++)
            //{
            //    for (int sloupec = 0; sloupec < strana; sloupec++)
            //    {

            //        if ((radek + sloupec) %2 != 0)
            //            Console.BackgroundColor = ConsoleColor.DarkYellow;
            //        else
            //            Console.BackgroundColor = ConsoleColor.Black;
            //        Console.Write("  ");                    
            //    }
            //    Console.WriteLine();

            //}


        }
    }
}
