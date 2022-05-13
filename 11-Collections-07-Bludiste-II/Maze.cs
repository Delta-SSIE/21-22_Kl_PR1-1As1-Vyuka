using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11_Collections_07_Bludiste_II
{
    class Maze
    {
        private int[,] _maze;

        public void ReadFile(string filename)
        {
            //soubor typu txt

            //soubor musi mit na 1. radku vysku bludiste,
            // na 2. radku sirku bludiste
            //pak znaky X (prekazka), mezera (volno), S (start), E (exit)

            StreamReader sr = new StreamReader(filename);
            string heightStr = sr.ReadLine();
            int height = int.Parse(heightStr);

            string widthStr = sr.ReadLine();
            int width = int.Parse(widthStr);

            _maze = new int[width, height];
            for (int y = 0; y < height; y++)
            {
                string row = sr.ReadLine();
                for (int x = 0; x < width; x++)
                {
                    switch (row[x])
                    {
                        case 'X':
                            _maze[x, y] = -1; //bariera
                            break;

                        case ' ':
                            _maze[x, y] = int.MaxValue; //volno
                            break;

                        case 'S':
                            _maze[x, y] = 0; //start
                            break;

                        case 'E':
                            _maze[x, y] = -2; //cil
                            break;

                        default:
                            break;
                    }
                }
            }
        }
        public void Display()
        {
            Console.Clear();
            for (int y = 0; y < _maze.GetLength(1); y++)
            {
                for (int x = 0; x < _maze.GetLength(0); x++)
                {
                    switch (_maze[x, y])
                    {
                        case 0:
                            Console.Write("SS ");
                            break;
                        case -1:
                            Console.Write("XX ");
                            break;
                        case -2:
                            Console.Write("EE ");
                            break;
                        case int.MaxValue:
                            Console.Write("   ");
                            break;

                        default:
                            Console.Write($"{_maze[x, y]:00} ");

                            break;
                    }
                }
                Console.WriteLine(); ;
            }
        }
        public void Solve()
        {
            throw new NotImplementedException();
        }

    }
}
