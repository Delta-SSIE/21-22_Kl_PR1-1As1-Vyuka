using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_050_Konstruktor_kruznice
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
                throw new ArgumentOutOfRangeException();

            _polomer = value;
        }

        //konstruktor - volá se, když tovřím novou, new
        public Kruznice(double polomer)
        {
            //_polomer = polomer; //tak ne  - nehlídám
            SetPolomer(polomer);
        }

        public Kruznice()
        {
            _polomer = 0;
        }

        public double Obvod()
        {
            return 2 * Math.PI * _polomer;
        }
    }
}
