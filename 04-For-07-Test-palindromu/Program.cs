using System;

namespace _04_For_07_Test_palindromu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej text: ");
            string text = Console.ReadLine();

            string bezMezer = "";
            for (int i = 0; i < text.Length; i++) //projdu všechny znaky v řetězci
            {
                char znak = text[i];
                if (znak != ' ') //nechám si jen to, co nejsou mezery
                    bezMezer += znak;
            }
            bezMezer = bezMezer.ToLower(); //převedu na malá písmena

            string odzadu = "";
            for (int i = bezMezer.Length - 1; i >= 0; i--) //jdu od posledního písmene dolů
            {
                odzadu += bezMezer[i];
            }

            //Console.WriteLine($"když přečtu \"{text}\" pozpátku, dostanu \"{odzadu}\".");

            if (bezMezer == odzadu)
            {
                Console.WriteLine($"\"{text}\" je palindrom");
            }
            else
            {
                Console.WriteLine($"\"{text}\" není palindrom");
            }
        }
    }
}
