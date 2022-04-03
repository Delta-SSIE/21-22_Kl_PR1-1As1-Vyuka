using System;

namespace _10_OOP_030_GetSetMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            Kruznice k = new Kruznice();
            k.SetPolomer(5);
            Console.WriteLine(k.Obvod());

            try 
            { 
                k.SetPolomer(-1);
            }
            catch
            {
                Console.WriteLine("CHyba nastavení poloměru");
            }
        }
    }
}
