using System;

namespace _04_For_18_Caesar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej text k zašifrování: ");
            string veta = Console.ReadLine();
            veta = veta.ToUpper();

            Console.WriteLine("Jaký je klíč?");
            int klic = int.Parse(Console.ReadLine());

            string zasifrovano = "";

            for (int i = 0; i < veta.Length; i++)
            {
                char pismeno = veta[i];
                if (pismeno >= 'A' && pismeno <= 'Z')
                {
                    // je to písmeno - šifruju
                    int kodZnaku = pismeno;
                    kodZnaku += klic;
                    
                    if (kodZnaku > 'Z')
                    {
                        kodZnaku -= 26; //délka abecedy
                    }
                    else if(kodZnaku < 'A')
                    {
                        kodZnaku += 26;
                    }

                    zasifrovano += (char)kodZnaku;
                }
                else
                {
                    //není to písmeno - kopíruju
                    zasifrovano += pismeno;
                }
            }

            Console.WriteLine(zasifrovano);
        }
    }
}
