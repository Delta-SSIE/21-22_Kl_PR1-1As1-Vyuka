using System;

namespace _04_For_20_Sachovnice_s_pozicí
{
    class Program
    {
        static void Main(string[] args)
        {
            int strana = 8;

            // kontrola vstupu
            Console.WriteLine("Zadej pozici: ");
            string vstup = Console.ReadLine().ToUpper();

            //délka
            if (vstup.Length != 2)
            {
                Console.WriteLine("Špatný vstup");
                return;
            }
            
            // rozmezí znaků
            char zadSloupec = vstup[0];
            char zadRadek = vstup[1];
            if (zadSloupec < 'A' || zadSloupec > 'H' || zadRadek < '1' || zadRadek > '8')
            {
                Console.WriteLine("Špatný vstup");
                return;
            }

            //int oznRadek = int.Parse(zadRadek.ToString());
            int oznRadek = zadRadek - '0'; //dělá totéž jinak
            int oznSloupec = zadSloupec - 'A';

            //má být pole zvětlé nebo tmavé?
            bool svetla = true;

            //horní řada popisek
            Console.Write("  ");
            for (int i = 0; i < strana; i++)
            {
                Console.Write((char)('A' + i) + " ");
            }
            Console.WriteLine();

            //projedu všechny řádky
            for (int radek = strana; radek > 0; radek--)
            {
                //vypíšu číslo řádku jako popisek
                Console.Write(radek + " ");

                //projedu všechny sloupce
                for (int sloupec = 0; sloupec < strana; sloupec++)
                {
                    //když je to označená pozice
                    if (radek == oznRadek && sloupec == oznSloupec)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    } else if (svetla) { //světlé pole
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    } else { //tmavé pole
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write("  ");

                    // šachovnice neustále přehazuje světlá a tmavá pole
                    svetla = !svetla;
                }

                // na konci řádku resetuju barvy kvůli popiskům
                Console.BackgroundColor = ConsoleColor.Black;

                //vypíšu popisky
                Console.Write(" " + radek);
                Console.WriteLine();
                svetla = !svetla;
            }

            //dolní řada popisek
            Console.Write("  ");
            for (int i = 0; i < strana; i++)
            {
                Console.Write((char)('A' + i) + " ");
            }
        }
    }
}
