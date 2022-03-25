using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_010_Uvod_Kruznice_apod
{
    class Kruznice
    {
        public double Polomer;

        public double Obvod()
        {
            return 2 * Math.PI * Polomer;
        }
    }
}
