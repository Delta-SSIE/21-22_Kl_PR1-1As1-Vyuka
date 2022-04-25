using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_080_NavalBattle
{
    class SeaDisplay
    {
        int _left;
        int _top;

        public ConsoleColor CursorColor { get; set; } = ConsoleColor.Red;

        public SeaDisplay(int left, int top)
        {
            _left = left;
            _top = top;
        }
        public void RenderSea(TileState[,] sea, Coords cursorLocation = null)
        {
            Console.SetCursorPosition(_left, _top);

            Console.Write('╔');
            Console.Write("".PadRight(sea.GetLength(0), '═'));
            Console.Write('╗');

            for (int y = 0; y < sea.GetLength(1); y++)
            {
                Console.SetCursorPosition(_left, _top + y + 1);
                Console.Write('║');
                for (int x = 0; x < sea.GetLength(0); x++)
                {
                    if (cursorLocation != null && cursorLocation.X == x && cursorLocation.Y == y)
                    {
                        Console.BackgroundColor = CursorColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    switch (sea[x, y])
                    {
                        case TileState.Empty:
                            Console.Write(' ');
                            break;
                        case TileState.Ship:
                            Console.Write('█');
                            break;
                        case TileState.Missed:
                            Console.Write('.');
                            break;
                        case TileState.Hit:
                            Console.Write('#');
                            break;
                    }
                    Console.ResetColor();                    
                }
                Console.Write('║');
            }

            Console.SetCursorPosition(_left, _top + sea.GetLength(1) + 1);

            Console.Write('╚');
            Console.Write("".PadRight(sea.GetLength(0), '═'));
            Console.Write('╝');
        }
        public Coords SelectCoordinates(TileState[,] sea, Coords start)
        {
            Coords current = new Coords(start.X, start.Y);
            while (true)
            {
                RenderSea(sea, current);
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        return current;

                    case ConsoleKey.UpArrow:
                        if (current.Y > 0)
                            current.Y--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (current.Y < sea.GetLength(1) - 1)
                            current.Y++;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (current.X > 0)
                            current.X--;
                        break;

                    case ConsoleKey.RightArrow:
                        if (current.X < sea.GetLength(0) - 1)
                            current.X++;
                        break;
                }
            }
        }
    }
}
