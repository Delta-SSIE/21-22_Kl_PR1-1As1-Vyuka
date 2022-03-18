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

            bool[,] mapa = VytvorMapu(sirka, vyska);

            while (true)
            {
                Vykresli(mapa);
                mapa = PristiMapa(mapa);
                //chvilicku pockej
                System.Threading.Thread.Sleep(pauza); //kolik ms ma vlakno spat
            }
        }
        static void Vykresli(bool[,] mapa)
        {

        }
        static bool[,] VytvorMapu(int sirka, int vyska)
        {

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
    }
}
