using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_030_GetSetMetody
{
    class Kruznice
    {
        private double _polomer;
        public double GetPolomer()
        {
            return _polomer;
        }
        public void SetPolomer(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Poloměr nesmí být záporný");
            }
            this._polomer = value;
        }


        public double Obvod()
        {
            return 2 * Math.PI * _polomer;
        }
    }
}
