using System;

namespace _08_App_010_Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            int vyska = 10;
            int sirka = 10;
            int pocetMin = 12;

            bool[,] mapaMin = VytvorMapu(vyska, sirka, pocetMin);
            int[,] mapaSousedu = Sousede(mapaMin);

            // nové pole - všude budou 0
            // 0 : neodkryto
            // 1 : odkryto
            // 2 : označená mina
            // 3 : odpálená mina
            int[,] stavMapy = new int[vyska, sirka];

            int poziceX = sirka / 2;
            int poziceY = vyska / 2;

            bool jeKonec = false;
            bool vyhral = false;

            while (!jeKonec)
            {
                Vykresli(mapaSousedu, stavMapy, poziceX, poziceY);
                
                int akce = NactiVstup();
                switch (akce)
                {
                    case 0: //nahoru
                        if (poziceY > 0)
                            poziceY--;
                        else
                            poziceY = vyska - 1;
                        break;

                    case 1: //doprava
                        if (poziceX < sirka - 1)
                            poziceX++;
                        else
                            poziceX = 0;
                        break;

                    case 2: //dolu
                        if (poziceY < vyska - 1)
                            poziceY++;
                        else
                            poziceY = 0;
                        break;

                    case 3: //vlevo
                        if (poziceX > 0)
                            poziceX--;
                        else
                            poziceX = sirka - 1;
                        break;

                    case 4: //označ/odznač
                        if (stavMapy[poziceY, poziceX] == 2) //je tam označeno
                            stavMapy[poziceY, poziceX] = 0; //zruším označení
                        else if (stavMapy[poziceY, poziceX] == 0) //není odkryto
                            stavMapy[poziceY, poziceX] = 2; //nastavím "označeno"
                        //jinak nic nedělám

                        //potom zkontroluju vítězství
                        vyhral = JeVitezstvi(mapaMin, stavMapy);
                        if (vyhral)
                            jeKonec = true;
                        break;

                    case 5: //odkryj
                        if (stavMapy[poziceY, poziceX] != 0) //pokud už je odkryto
                            break; //nedělej nic a skonči

                        if (mapaMin[poziceY, poziceX] == true) // je tam mina
                        {
                            stavMapy[poziceY, poziceX] = 3;
                            vyhral = false;
                            jeKonec = true;
                        }
                        else //jinak
                        {
                            stavMapy[poziceY, poziceX] = 1; //odkryj v tomto bodě mapu
                        }

                        break;
                }
                Console.Clear();

            }

            Vykresli(mapaSousedu, stavMapy, poziceX, poziceY);
            //mohl bych překopírovat do stavu mapy všechny neodkryté miny

            if (vyhral)
                Console.WriteLine("Gratuluji");
            else
                Console.WriteLine("Game over");


           

        }
        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMin)
        {
            Random rnd = new Random();

            bool[,] mapa = new bool[vyska, sirka];
            for (int i = 0; i < pocetMin; i++)
            {
                int x = rnd.Next(sirka);
                int y = rnd.Next(vyska);
                if (mapa[y, x])
                {
                    i--;
                }
                else
                {
                    mapa[y, x] = true;
                }
            }
            return mapa;
        }

        static int PocetSousedu(bool[,] mapa, int sourX, int sourY)
        {
            //zalozime pocitadlo
            int pocet = 0;

            //projdeme x od o jedna mensi do o 1 vetsi
            //int minX = sourX - 1;
            //if (minX < 0)
            //    minX = 0;

            int minX = Math.Max(sourX - 1, 0);
            int maxX = Math.Min(sourX + 1, mapa.GetLength(1) - 1);
            //mapa.GetLength(1) - 1 je největší možná hodnota x, kterou pole obsahuje

            int minY = Math.Max(sourY - 1, 0);
            int maxY = Math.Min(sourY + 1, mapa.GetLength(0) - 1);

            //ke kazdemu x projedeme pro y od o 1 mensi do o 1 vetsi

            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    //kdyz najdu minu, (a nejsem sám na hledané pozici, abych nepočítal sebe) , zvysim pocitadlo
                    if (mapa[y, x] && (x != sourX || y != sourY))
                        pocet++;
                }
            }

            return pocet;
        }

        static int[,] Sousede(bool[, ] mapa)
        {
            int[,] mapaSousedu = new int[mapa.GetLength(0), mapa.GetLength(1)];
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    mapaSousedu[y, x] = PocetSousedu(mapa, x, y);
                }
            }
            return mapaSousedu;
        }

        static void Vykresli(int[,] sousede, int[,] stavMapy, int poziceX, int poziceY)
        {
            for (int y = 0; y < sousede.GetLength(0); y++)
            {
                for (int x = 0; x < sousede.GetLength(1); x++)
                {
                    int stavPole = stavMapy[y, x];

                    if (y == poziceY && x == poziceX)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    switch (stavPole)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            if (sousede[y, x] != 0)
                                Console.Write(sousede[y, x]);
                            else
                                Console.Write(" ");
                            break;
                        case 2:
                            Console.Write("P");
                            break;
                        case 3:
                            Console.Write("*");
                            break;
                    }
                    if (y == poziceY && x == poziceX)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.WriteLine();
            }
        }

        // 0 - nahoru
        // 1 - vpravo
        // 2 - dolu
        // 3 - vlevo
        // 4 - oznac
        // 5 - odkryj
        public static int NactiVstup()
        {
            while (true) 
            { 
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                    return 0;

                if (keyInfo.Key == ConsoleKey.RightArrow)
                    return 1;

                if (keyInfo.Key == ConsoleKey.DownArrow)
                    return 2;

                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    return 3;

                if (keyInfo.Key == ConsoleKey.Enter)
                    return 4;

                if (keyInfo.Key == ConsoleKey.Spacebar)
                    return 5;
            }
        }

        /// <summary>
        /// Vrací true když jsou označeny všechny miny a žádná navíc
        /// </summary>
        /// <param name="mapaMin"></param>
        /// <param name="stavMapy"></param>
        /// <returns></returns>
        public static bool JeVitezstvi(bool[,] mapaMin, int[,] stavMapy)
        {
            //projdu všechna pole
            for (int y = 0; y < mapaMin.GetLength(0); y++)
            {
                for (int x = 0; x < mapaMin.GetLength(1); x++)
                {
                    if (mapaMin[y, x] == true && stavMapy[y, x] != 2)
                        return false; //existuje neoznačená mina

                    if (mapaMin[y, x] == false && stavMapy[y, x] == 2)
                        return false; //je označena "ne-mina"
                }
            }

            return true;
        }
    }
}
