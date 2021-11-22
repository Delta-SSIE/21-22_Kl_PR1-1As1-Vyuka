using System;

namespace _03_While_13_Break_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (true)
            {
                a++;
                Console.WriteLine(a);
                if (a >= 10)
                    break;
            }
        }
    }
}
