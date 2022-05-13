using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Collections_07_Bludiste_II
{
    struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }
}
