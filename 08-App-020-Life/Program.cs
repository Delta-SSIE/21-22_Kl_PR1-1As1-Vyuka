using System;

namespace _08_App_020_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int sirka = 20;  
            int vyska = 20;
            int pauza = 300;

            //bool[,] mapa = VytvorMapu(sirka, vyska);            
            bool[,] mapa = EditujMapu(sirka, vyska);
            bool[,] staraMapa = new bool[vyska, sirka];
            Console.Clear();
            Console.CursorVisible = false;

            while (true)
            {
                Vykresli(staraMapa, mapa);
                staraMapa = mapa;
                mapa = PristiMapa(mapa);
                //chvilicku pockej
                System.Threading.Thread.Sleep(pauza); //kolik ms ma vlakno spat
            }
        }
        static void VykresliEditor(bool[,] mapa, int poziceX, int poziceY)
        {
            Console.Clear();
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    if (x == poziceX && y == poziceY)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write(mapa[y,x] ? "#" : "-");

                    if (x == poziceX && y == poziceY)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                }
                Console.WriteLine();
            }
        }
        static void Vykresli(bool[,] staraMapa, bool[,] novaMapa)
        {
            for (int y = 0; y < staraMapa.GetLength(0); y++)
            {
                for (int x = 0; x < staraMapa.GetLength(1); x++)
                {
                    if (novaMapa[y, x] != staraMapa[y, x])
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(novaMapa[y, x] ? '#' : ' ');
                    }
                        
                }                
            }
        }
        static bool[,] VytvorMapu(int sirka, int vyska)
        {
            bool[,] mapa = new bool[vyska, sirka];

            mapa[2, 2] = true;
            mapa[2, 3] = true;
            mapa[2, 4] = true;

            return mapa;
        }
        static bool BudeBunkaZiva(bool jeZiva, int pocetSousedu)
        {
            if (jeZiva) {
                if (pocetSousedu == 2 || pocetSousedu == 3)
                    return true;
                else
                    return false;
            } 
            else
            {
                if (pocetSousedu == 3)
                    return true;
                else
                    return false;
            }

            //Každá živá buňka s méně než dvěma živými sousedy zemře.
            //Každá živá buňka se dvěma nebo třemi živými sousedy zůstává žít.
            //Každá živá buňka s více než třemi živými sousedy zemře.
            //Každá mrtvá buňka s právě třemi živými sousedy oživne.
        }
        static int PocetSousedu(bool[,] mapa, int poziceX, int poziceY)
        {
            int pocet = 0;

            for (int posunX = -1; posunX <= 1; posunX++)
            {
                for (int posunY = -1; posunY <= 1; posunY++)
                {
                    if (posunX == 0 && posunY == 0)
                        continue;

                    //řeším, abych nevypadl z mapy - beru pozici na druhé straně
                    int zkoumaneX = poziceX + posunX;
                    if (zkoumaneX < 0)
                        zkoumaneX = mapa.GetLength(1) - 1;
                    else if (zkoumaneX == mapa.GetLength(1))
                        zkoumaneX = 0;

                    //řeším, abych nevypadl z mapy - beru pozici na druhé straně
                    int zkoumaneY = poziceY + posunY;
                    if (zkoumaneY < 0)
                        zkoumaneY = mapa.GetLength(0) - 1;
                    else if (zkoumaneY == mapa.GetLength(0))
                        zkoumaneY = 0;

                    if (mapa[zkoumaneY, zkoumaneX])
                        pocet++;
                }
            }

            return pocet;
        }
        static bool[,] PristiMapa(bool[,] mapa)
        {
            bool[,] pristi = new bool[mapa.GetLength(0), mapa.GetLength(1)];
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    int pocetSousedu = PocetSousedu(mapa, x, y);
                    bool jeTedZiva = mapa[y, x];
                    pristi[y, x] = BudeBunkaZiva(jeTedZiva, pocetSousedu);
                }
            }
            return pristi;
        }

        static bool[,] EditujMapu(int sirka, int vyska)
        {
            bool[,] mapa = new bool[vyska, sirka];

            int poziceX = sirka / 2;
            int poziceY = vyska / 2;

            while (true)
            {
                VykresliEditor(mapa, poziceX, poziceY);
                //čti vstup
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        poziceY--;
                        if (poziceY < 0)
                            poziceY = vyska - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        poziceY++;
                        if (poziceY == vyska)
                            poziceY = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        poziceX--;
                        if (poziceX < 0)
                            poziceX = sirka - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        poziceX++;
                        if (poziceX == sirka)
                            poziceX = 0;
                        break;
                    case ConsoleKey.Spacebar:
                        mapa[poziceY, poziceX] = !mapa[poziceY, poziceX];
                        break;
                    case ConsoleKey.Enter:
                        return mapa;
                }                
            }            
        }
    }
}
