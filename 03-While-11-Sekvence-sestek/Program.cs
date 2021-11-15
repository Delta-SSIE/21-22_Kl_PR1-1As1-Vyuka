using System;

namespace _03_While_11_Sekvence_sestek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolikrát mám hodit kostkou: ");

            int pocetHodu;
            while (!int.TryParse(Console.ReadLine(), out pocetHodu) || pocetHodu < 1) //dokud zadává nesmysle nebo je počet menší než 1
            {
                Console.Write("To není platné číslo, zkus to znovu: ");
            }

            int delkaTed = 0;
            int maxDelka = 0;

            Random rnd = new Random();

            int opakovani = 0;
            while (opakovani < pocetHodu)
            {
                int tentoHod = rnd.Next(1, 7);

                if (tentoHod == 6)
                { 
                    delkaTed++; //série je o 1 delší - připíšu si 1 k počítadlu
                }
                else
                {
                    if (delkaTed > maxDelka) //minulá serie byla delší než nejdelší zaznamenaná
                        maxDelka = delkaTed;

                    delkaTed = 0; //resetuju počítadlo délky
                }

                opakovani++;
            }

            if (delkaTed > maxDelka) //pro případ, kdyby nejdelší série běžela až do konce
                maxDelka = delkaTed;

            Console.WriteLine($"Nejdelší sekvence šestek měla délku {maxDelka}.");
        }
    }
}
