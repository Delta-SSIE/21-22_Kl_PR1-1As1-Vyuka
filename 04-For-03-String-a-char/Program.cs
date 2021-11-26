using System;

namespace _04_For_03_String_a_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string veta = "Ahoj, jak to jde?";
            //Console.WriteLine(veta[0]); //první - tedy nultý - znak
            Console.WriteLine("řetězec má délku " + veta.Length + " znaků.");

            int posledniIndex = veta.Length - 1;

            Console.WriteLine("Poslední znak má index " + posledniIndex + " a je to \"" + veta[posledniIndex] + "\"");

            for (int i = 0; i < veta.Length; i++)
            {
                Console.WriteLine(veta[i]);
            }

            Console.WriteLine("A teď odzadu");

            for (int i = posledniIndex; i >= 0; i--)
            {
                Console.Write(veta[i]);
            }
        }
    }
}
