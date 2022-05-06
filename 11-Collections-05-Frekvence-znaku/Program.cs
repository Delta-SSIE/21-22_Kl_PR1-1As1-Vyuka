using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Collections_05_Frekvence_znaku
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"babicka.txt");
            string[] slova  = text.Split(' ');

            Dictionary<string, int> frekvence = new Dictionary<string, int>();
            foreach (string slovo in slova)
            {
                string skutecneSlovo = slovo;
                while (skutecneSlovo.Length > 0 && ",.!? ".Contains(skutecneSlovo[skutecneSlovo.Length - 1]))
                {
                    skutecneSlovo = skutecneSlovo.Substring(0, skutecneSlovo.Length - 1);
                }
                if (skutecneSlovo.Length == 0)
                    continue;

                if (frekvence.ContainsKey(skutecneSlovo))
                    frekvence[skutecneSlovo]++;
                else
                    frekvence[skutecneSlovo] = 1;
            }

            frekvence = new Dictionary<string, int>(frekvence.OrderByDescending(x => x.Value));
            int pocetSlov = slova.Length;

            foreach (var item in frekvence)
            {
                Console.WriteLine($"{item.Key}: {item.Value} ({(((double)item.Value) / pocetSlov)})");
            }
        }
    }
}
