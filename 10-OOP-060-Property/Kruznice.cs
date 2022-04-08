using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_060_Property
{
    class Kruznice
    {
        public string Barva { get; private set; } //automatická vlastnost

        private double _polomer;

        public double Polomer
        {
            get
            {
                return _polomer;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _polomer = value;
            }
        }
        public bool JeMala
        {
            get
            {
                if (_polomer < 5)
                    return true;
                else
                    return false;
            }
            //get => _polomer < 5;

        }
        //public bool JeMala => _polomer < 5;

        //konstruktor - volá se, když tovřím novou, new
        public Kruznice(double polomer)
        {
            //_polomer = polomer; //tak ne  - nehlídám
            Polomer = polomer;
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
