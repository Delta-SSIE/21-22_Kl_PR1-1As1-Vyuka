using System;

namespace _02_Podm_04_Znamkovani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik procent získal žák?");
            string vstup = Console.ReadLine();
            double procenta = double.Parse(vstup);

//SKORE stupeň
//<100 % -83 %> 1(výborně)
//(83 % -67 %> 2(chvalitebně)
//(67 % -50 %> 3(dobře)
//(50 % -33 %> 4(dostatečně)
//(33 % -0 %> 5(nedostatečně)

            if (procenta > 100 || procenta < 0)
            {
                Console.WriteLine($"Výsledek ${procenta} neumím vyhodnotit.");
            }
            else
            {
                int znamka;
                string popis;
            
                if (procenta >= 83)
                {
                    znamka = 1;
                    popis = "výborně";
                }
                else if (procenta >= 67)
                {
                    znamka = 2;
                    popis = "chvalitebně";

                }
                else if (procenta >= 50)
                {
                    znamka = 3;
                    popis = "dobře";
                }
                else if (procenta >= 33)
                {
                    znamka = 4;
                    popis = "dostatečně";
                }
                else
                {
                    znamka = 5;
                    popis = "nedostatečně";
                }
                Console.WriteLine($"Za {procenta}% mu náleží známka {znamka} ({popis}). ");
            }

        }
    }
}
