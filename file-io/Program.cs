using System;
using System.IO;

namespace file_io
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("data.txt");
            foreach (string line in lines)
                Console.WriteLine(line);

            int height = lines.Length;
            int width = lines[0].Length;

            bool[,] maze = new bool[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    maze[y, x] = lines[y][x] == 'X' ? false : true;
                }
            }

            
        }
    }
}
