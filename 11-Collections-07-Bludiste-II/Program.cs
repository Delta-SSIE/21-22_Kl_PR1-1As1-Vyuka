using System;

namespace _11_Collections_07_Bludiste_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            maze.ReadFile("maze.txt");
            //maze.ReadFile("maze2.txt");
            maze.Display();
            maze.Solve();
        }
    }
}
