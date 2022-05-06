using System;
using System.Collections.Generic;

namespace _11_Collections_03_Dictionary_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> slovnik = new Dictionary<string, string>();

            slovnik.Add("hello", "ahoj");
            slovnik.Add("day", "den");
            slovnik.Add("night", "noc");

            Console.WriteLine(slovnik["hello"]);

            slovnik["breakfast"] =  "snídaně";

            Console.WriteLine(slovnik["breakfast"]);

            slovnik["hello"] = "nazdar";
            //slovnik.Add("hello", "nazdar");

            Console.WriteLine(slovnik["hello"]);

            if (slovnik.TryAdd("hello", "nazdar"))
            {
                Console.WriteLine("Přidal jsem");
            }
            else
            {
                Console.WriteLine("Nelze přidat, obsazeno");
            }

            if (slovnik.TryGetValue("dinner", out string preklad))
            {
                Console.WriteLine($"Překlad je {preklad}.");
            }
            else
            {
                Console.WriteLine("Hodnota nenalezena");
            }
            //Console.WriteLine(slovnik["dinner"]);

            foreach (KeyValuePair<string, string> item in slovnik)
            {
                Console.WriteLine($"{item.Key} se překládá jako {item.Value}.");
            }
            

        }
    }
}
