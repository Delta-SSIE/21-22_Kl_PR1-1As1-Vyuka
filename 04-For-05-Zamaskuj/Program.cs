using System;

namespace _04_For_05_Zamaskuj
{
    class Program
    {
        static void Main(string[] args)
        {
            /* znaky 1:1 */
            //Random random = new Random();

            //string tajnyRetezec = "Tajna zprava";
            //string nahodnyRetezec = "";

            //for (int i = 0; i < tajnyRetezec.Length; i++)
            //{
            //    int kodZnaku = random.Next('a', 'z' + 1);
            //    char nahodnyZnak = (char)kodZnaku;

            //    nahodnyRetezec += tajnyRetezec[i];
            //    nahodnyRetezec += nahodnyZnak;
            //}

            //Console.WriteLine(nahodnyRetezec);


            /* Můžu volit, kolik znaků */

            //Random random = new Random();

            //string tajnyRetezec = "Tajna zprava";
            //string nahodnyRetezec = "";
            //int vlozeneZnaky = 3;

            //for (int i = 0; i < tajnyRetezec.Length; i++)
            //{
            //    nahodnyRetezec += tajnyRetezec[i];

            //    for (int j = 0; j < vlozeneZnaky; j++) { 
            //        int kodZnaku = random.Next('A', 'z' + 1);
            //        char nahodnyZnak = (char)kodZnaku;
            //        nahodnyRetezec += nahodnyZnak;
            //    }
            //}

            // Console.WriteLine(nahodnyRetezec);

            /* Výběr z množiny znaků */

            Random random = new Random();

            string tajnyRetezec = "Tajna zprava";
            string znakyNaDoplneni = "ABCDEFGHabcdefgh .!?";
            string nahodnyRetezec = "";
            int vlozeneZnaky = 3;

            for (int i = 0; i < tajnyRetezec.Length; i++)
            {
                nahodnyRetezec += tajnyRetezec[i];

                for (int j = 0; j < vlozeneZnaky; j++)
                {
                    int nahodnyIndex = random.Next(0, znakyNaDoplneni.Length); //vyberu číslo, které ukazuje dovnitř řetězce znakyNaDoplneni
                    char nahodnyZnak = znakyNaDoplneni[nahodnyIndex]; //vezmu znak na te nahodne pozici
                    nahodnyRetezec += nahodnyZnak;
                }
            }

            Console.WriteLine(nahodnyRetezec);
        }
    }
}
