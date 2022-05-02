using System;
using System.Diagnostics;
using System.Text;

namespace slow_string_building
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int n = 1000000;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            //for (int i = 0; i < n; i++)
            //{
            //    str += 'A';
            //}
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append('A');
            }
            sw.Stop();

            string result = sb.ToString();

            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
