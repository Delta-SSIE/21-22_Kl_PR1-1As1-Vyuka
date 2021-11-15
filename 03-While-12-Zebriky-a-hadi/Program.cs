using System;

namespace _03_While_12_Zebriky_a_hadi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int poloha = 1;
            int kolo = 0;

            int zebrikDelitel = 11;
            int zebrikPosun = 10;

            int hadDelitel = 13;
            int hadPosun = -12;

            Console.WriteLine("Začínám na poli 1.");

            //dokud není na konci
            while (poloha < 100) {
                kolo++;

                //hod si kostkou
                int hod = rnd.Next(1, 7);

                //pricti hod k poloze
                int pristiPoloha = poloha + hod;
                
                if (pristiPoloha <= 100)
                {
                    poloha += hod;
                    Console.WriteLine($"{kolo}. kolo: Hodil jsem {hod}, posouvám se na pole {poloha}.");
                }
                else
                {
                    //hodil jsme moc, nezměním hodnotu polohy
                    Console.WriteLine($"{kolo}. kolo: Hodil jsem {hod}, vypadl bych ven, musím čekat.");
                }

                //jsem na žebříku
                if (poloha % zebrikDelitel == 0)
                {
                    poloha += zebrikPosun;
                    Console.WriteLine($"+ jsem na žebříku, posouvám se o {zebrikPosun} na {poloha}.");
                }
                else if (poloha % hadDelitel == 0) //jsem u hada
                {
                    poloha += hadPosun;
                    Console.WriteLine($"+ jsem na hadovi, posouvám se o {hadPosun} na {poloha}.");
                }
                                
            }

            Console.WriteLine($"Jsem v cíli! Došel jsem v {kolo}. kole");
        }
    }
}
