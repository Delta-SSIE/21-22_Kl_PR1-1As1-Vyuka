using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Collections_01_List_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zaklad = new string[] { "chleba", "mléko", "salám" };

            List<string> seznam = new List<string>(zaklad);
            seznam.Add("vejce");
            seznam.Add("máslo");
            seznam.Add("rohlíky");
            seznam.Add("jablka");
            seznam.Add("rýže");
            seznam.Add("salát");
            seznam.Add("rajčata");
            seznam.Add("ryby");

            foreach (string vec in seznam)
            {
                Console.WriteLine(vec);
            }

            Console.WriteLine();

            seznam.Remove("máslo");
            foreach (string vec in seznam)
            {
                Console.WriteLine(vec);
            }

            //List<string> vyber = new List<string>();

            //foreach (string vec in seznam)
            //{
            //    if (vec[0] == 'r')
            //        vyber.Add(vec);
            //}

            string[] vyber = Filtruj(seznam.ToArray(), 'v');
            
            //string[] vyber = seznam
            //                    .Where(vec => vec[0] == 'r')
            //                    .ToArray();

            Console.WriteLine();
            foreach (string vec in vyber)
            {
                Console.WriteLine(vec);
            }
        }

        static string[] Filtruj (string[] seznam, char prvni)
        {
            List<string> vyber = new List<string>();

            foreach (string vec in seznam)
            {
                if (vec[0] == prvni)
                    vyber.Add(vec);
            }

            return vyber.ToArray();
        }
    }
}
