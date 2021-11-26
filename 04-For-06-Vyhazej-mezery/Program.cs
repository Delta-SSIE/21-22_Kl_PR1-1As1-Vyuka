using System;
using System.Linq;

namespace _04_For_06_Vyhazej_mezery
{
    class Program
    {
        static void Main(string[] args)
        {
            string veta = "To je ale krásná věta";
            string bezMezer = "";


            //projít celý řetězec
            for (int i = 0; i < veta.Length; i++)
            {
                char znak = veta[i];
                if (znak != ' ') //když není znak mezera, schovám si ho
                    bezMezer += znak;
            }
            
            Console.WriteLine(bezMezer);

            Console.WriteLine(new string(veta.ToArray().Where(x => x !=' ').ToArray()));

        }
    }
}
