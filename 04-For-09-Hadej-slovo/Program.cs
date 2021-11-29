using System;

namespace _04_For_09_Hadej_slovo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hádej slovo";

            Console.WriteLine("Zadej slovo, které bude někdo hádat");
            string tajemstvi = Console.ReadLine().ToUpper();

            Console.Clear();


            //udělám stejně dlouhý řetězec z pomlček
            string uhodnuto = "";
            for (int i = 0; i < tajemstvi.Length; i++)
            {
                uhodnuto += "-";
            }

            Console.WriteLine("Hádej po písmenkách slovo");
            Console.WriteLine($"Stav: {uhodnuto}");

            int kolo = 0;
            while (tajemstvi != uhodnuto)
            {
                kolo++;
                //načtení jednoho znaku
                Console.Write("Zadej znak: ");
                string vstup = Console.ReadLine();
                if (vstup.Length != 1)
                {
                    Console.WriteLine("Špatný vstup");
                    continue;
                }
                vstup = vstup.ToUpper();
                char pismeno = vstup[0];

                // char pismeno = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToUpper());
                // jiny zapis nacteni znaku

                //procházwení a kopírování
                string noveUhodnuto = "";
                //projdu řetězec
                for (int i = 0; i < tajemstvi.Length; i++)
                {
                    if (tajemstvi[i] == pismeno) //když najdu písmenko, uložím si ho do nového
                        noveUhodnuto += pismeno;
                    else //jinak si překopíruju z toho, co už mám uhodnuto
                        noveUhodnuto += uhodnuto[i];
                }

                //vyhodnocení
                if (noveUhodnuto == uhodnuto)
                    Console.WriteLine($"Písmeno {pismeno} nic nového nepřidalo.");
                else
                    Console.WriteLine($"Hurá, {pismeno} tam je!");
                
                uhodnuto = noveUhodnuto;

                Console.WriteLine($"Stav: {uhodnuto}");

            }

            Console.WriteLine($"Gratuluji, dohrál jsi v {kolo}. kole");
        }
    }
}
