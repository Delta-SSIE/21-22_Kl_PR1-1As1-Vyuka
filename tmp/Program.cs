using System;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int karta = 100;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("platíš kolik?");
                int platba = Convert.ToInt32(Console.ReadLine());

                if (platba < 5)
                {
                    platba = 5;
                }

                karta = karta - platba;


                if (karta <= 0)
                {
                    Console.WriteLine("na karte uz ti nezbylo nic");
                    break;
                }
                else if (karta < platba)
                {
                    Console.WriteLine("nemas na platbu dostatek kreditu");
                    break;
                }

                //tohle mi z nejakyho duvodu nefunguje, jsem chtel udelat to ze kdyz mi bude zbyvat 20 kreditu a budu chtit platit 30 tak to rekne ze nemam dost kreditu na to

                else
                {
                    Console.WriteLine("stale na karte zbyva: {0} kreditu", karta);
                }
            }
        }
    }
}
