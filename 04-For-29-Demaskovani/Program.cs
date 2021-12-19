using System;
using System.IO;
using System.Text;

namespace _04_For_29_Demaskovani
{
    class Program
    {
        static void Main(string[] args)
        {
            string cestaVstup = @"vstup.txt";

            if (!File.Exists(cestaVstup))
            {
                Console.WriteLine("File not found");
                return;
            }

            string maskovano = File.ReadAllText(cestaVstup);

            // sem prijde vas kod



            
        }
    }
}
