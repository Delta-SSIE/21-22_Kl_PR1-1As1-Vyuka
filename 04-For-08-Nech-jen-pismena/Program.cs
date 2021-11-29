using System;

namespace _04_For_08_Nech_jen_pismena
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Jean-Luc, you should inform no. 1 and then go and see what happened at 8:30PM!";

            //níže přijde váš kód
            //z původní věty by mělo zbýt
            //"JeanLucyoushouldinformnoandthengoandseewhathappenedatPM"

            string prorezano = "";
            for (int i = 0; i < text.Length; i++)
            {
                char znak = text[i];
                //if (znak >= 65 && znak <= 90 || znak >=97 && znak <= 122)
                if (znak >= 'A' && znak <= 'Z' || znak >= 'a' && znak <= 'z')
                {
                    prorezano += text[i];
                }
            }

            Console.WriteLine(prorezano);

        }
    }
}
