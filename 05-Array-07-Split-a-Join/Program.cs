using System;

namespace _05_Array_07_Split_a_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            string slovaDohromady = "motýl, brambora, hnůj, okurka, šnek";
            string[] slovaJakoPole = slovaDohromady.Split(", ");

            for (int i = 0; i < slovaJakoPole.Length; i++)
            {
                string slovo = slovaJakoPole[i];
                Console.WriteLine(slovo);
            }

            int[] cisla = { 1, 5, 17, 255, 1023 };
            string spojeno = string.Join("; ", cisla);
            Console.WriteLine(spojeno);
        }
    }
}
