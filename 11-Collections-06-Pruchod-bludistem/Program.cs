using System;
using System.IO;

namespace _11_Collections_06_Pruchod_bludistem
{
    class Program
    {
        static void Main(string[] args)
        {
            string soubor = "maze.txt";
            int[,] bludiste;
            //nacist bludiste z disku
            try 
            { 
                bludiste = CtiBludiste(soubor);
            } 
            catch
            {
                Console.WriteLine("Neplatný zápis bludiště");
                return;
            }

            //na svoji pozici dej cislo 0

            bool nalezeno = false;
            int kdeJsem = 0;

            //dokud nejsem v cili a je kam jit, 
            while (!nalezeno) 
            {
                //jdi tam, 
                for (int x = 0; x < bludiste.GetLength(0); x++)
                {
                    for (int y = 0; y < bludiste.GetLength(1); y++)
                    {
                        if (bludiste[x,y] == kdeJsem)
                        {
                            //uprav vsechna sousedni nenavstivena mista na "ja + 1"
                            for (int dx = -1; dx < 2; dx++)
                            {
                                for (int dy = -1; dy < 2; dy++)
                                {
                                    if (dx * dy != 0)
                                        continue;
                                        
                                    int kamX = x + dx;
                                    int kamY = y + dy;
                                    
                                    if (kamX < 0 || kamY < 0 || kamX >= bludiste.GetLength(0) || kamY >= bludiste.GetLength(1))
                                        continue;

                                    if (bludiste[kamX, kamY] > kdeJsem)
                                        bludiste[kamX, kamY] = kdeJsem + 1;
                                    else if (bludiste[kamX, kamY] == -2)
                                        nalezeno = true;
                                }
                            }
                        }
                    }
                }

                kdeJsem++;
                UkazBludiste(bludiste);
                System.Threading.Thread.Sleep(1000);
                //kdyz trefis cil, skonci

            }
            //pokud nejsi v cili, nejde to
        }

        static int[,] CtiBludiste(string soubor)
        {
            //soubor typu txt

            //soubor musi mit na 1. radku vysku bludiste,
            // na 2. radku sirku bludiste
            //pak znaky X (prekazka), mezera (volno), S (start), E (exit)

            StreamReader sr = new StreamReader(soubor);
            string vyskaStr = sr.ReadLine();
            int vyska = int.Parse(vyskaStr);

            string sirkaStr = sr.ReadLine();
            int sirka = int.Parse(sirkaStr);

            int[,] bludiste = new int[sirka, vyska];
            for (int y = 0; y < vyska; y++)
            {
                string radek = sr.ReadLine();
                for (int x = 0; x < sirka; x++)
                {
                    switch (radek[x])
                    {
                        case 'X':
                            bludiste[x, y] = -1; //bariera
                            break;

                        case ' ':
                            bludiste[x, y] = int.MaxValue ; //volno
                            break;

                        case 'S':
                            bludiste[x, y] = 0; //start
                            break;

                        case 'E':
                            bludiste[x, y] = -2; //cil
                            break;

                        default:
                            break;
                    }
                }
            }

            return bludiste;
        }

        static void UkazBludiste(int[,] bludiste) 
        {
            Console.Clear();
            for (int y = 0; y < bludiste.GetLength(1); y++)
            {
                for (int x = 0; x < bludiste.GetLength(0); x++)
                {
                    switch (bludiste[x,y])
                    {
                        case 0:
                            Console.Write("SS ");
                            break;
                        case -1:
                            Console.Write("XX ");
                            break;
                        case -2:
                            Console.Write("EE ");
                            break;
                        case int.MaxValue:
                            Console.Write("   ");
                            break;


                        default:
                            Console.Write($"{bludiste[x, y]:00} "); 

                            break;
                    }
                }
                Console.WriteLine(); ;
            }
        }

    }
}
