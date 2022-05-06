using System;
using System.Collections.Generic;

namespace _11_Collections_04_Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> morse = new Dictionary<char, string>();
            morse['a'] = ".-";
            morse['b'] = "-...";
            morse['c'] = "-.-.";
            morse['d'] = "-..";
            morse['e'] = ".";
            morse['f'] = "..-.";
            morse['g'] = "--.";
            morse['h'] = "....";
            morse['i'] = "..";
            morse['j'] = ".---";
            morse['k'] = "-.-";
            morse['l'] = ".-..";
            morse['m'] = "--";
            morse['n'] = "-.";
            morse['o'] = "---";
            morse['p'] = ".--.";
            morse['q'] = "--.-";
            morse['r'] = ".-.";
            morse['s'] = "...";
            morse['t'] = "-";
            morse['u'] = "..-";
            morse['v'] = "...-";
            morse['w'] = ".--";
            morse['x'] = "-..-";
            morse['y'] = "-.--";
            morse['z'] = "--..";
            morse[' '] = "";

            Console.WriteLine("Co chceš zašifrovat?");
            string text = Console.ReadLine();

        }
    }
}
