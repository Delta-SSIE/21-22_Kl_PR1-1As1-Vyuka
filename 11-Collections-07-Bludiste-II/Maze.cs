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
        private Location _start;
        private Location _exit;

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
                            _maze[x, y] = int.MaxValue; //start
                            _start = new Location(x, y);
                            break;

                        case 'E':
                            _maze[x, y] = int.MaxValue; //cil
                            _exit = new Location(x, y);
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
                    if (x == _start.X && y == _start.Y)
                    {
                        Console.Write("SS ");
                        continue;
                    }
                    
                    if (x == _exit.X && y == _exit.Y)
                    {
                        Console.Write("EE ");
                        continue;
                    }

                    switch (_maze[x, y])
                    {
                        case -1:
                            Console.Write("XX ");
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
            //na začátku dej 0 na start
            _maze[_start.X, _start.Y] = 0;
            //dej si na frontu "uzlů k projití" začátek
            Queue<Location> nextSteps = new Queue<Location>();
            //Stack<Location> nextSteps = new Stack<Location>();
            nextSteps.Enqueue(_start); //dává na konec fronty
            //nextSteps.Push(_start); //dává do zásobníku

            //dokud je co procházet
            while (nextSteps.Count > 0) 
            {
                //vezmi první položku seznamu k projití
                Location current = nextSteps.Dequeue(); //odebírá ze začátku fronty
                //Location current = nextSteps.Pop(); //odebírá ze začátku fronty

                int nextVal = ValueAt(current) + 1;
                // dej do všech jejích sousedů o 1 víc
                Location[] neighbors = Neighbors(current);
                foreach (Location neighbor in neighbors)
                {
                    if (ValueAt(neighbor) <= nextVal)
                        continue;

                    _maze[neighbor.X, neighbor.Y] = nextVal;
                    nextSteps.Enqueue(neighbor);
                    //nextSteps.Push(neighbor);
                    if (neighbor.X == _exit.X && neighbor.Y == _exit.Y)
                    {
                        //jsem v cíli
                        nextSteps.Clear();
                    }
                    System.Threading.Thread.Sleep(250);
                    Display();
                }

            }
        }
        private Location[] Neighbors(Location location)
        {
            //chci jen ty sousedy, které má cenu projít

            //podívám se na aktuální hodnotu
            int currentStep = ValueAt(location);
            List<Location> neighbors = new List<Location>();

            //vezmu sousedy,když mají číslo vyšší, než aktuální, přidám na seznam
            Location neighbor = new Location(location.X, location.Y - 1);          
            if (ValueAt(neighbor) > currentStep)
                neighbors.Add(neighbor);

            neighbor = new Location(location.X - 1, location.Y);
            if (ValueAt(neighbor) > currentStep)
                neighbors.Add(neighbor);

            neighbor = new Location(location.X + 1, location.Y);
            if (ValueAt(neighbor) > currentStep)
                neighbors.Add(neighbor);

            neighbor = new Location(location.X, location.Y + 1);
            if (ValueAt(neighbor) > currentStep)
                neighbors.Add(neighbor);

            //vrátím seznam
            return neighbors.ToArray();
        }
        private int ValueAt(Location location)
        {
            if (
                location.X < 0 
                || location.X > _maze.GetLength(0) - 1 
                || location.Y < 0
                || location.Y > _maze.GetLength(1) - 1
            )
            {
                return -1;
            }
            return _maze[location.X, location.Y];
        }

    }
}
