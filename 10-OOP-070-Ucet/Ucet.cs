using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_070_Ucet
{
    class Ucet
    {
        private double _zustatek;
        public double Zustatek
        {
            get
            {
                return _zustatek;
            }
        }
        public void Uloz(double ulozka)
        {
            if (ulozka < 0)
                throw new ArgumentOutOfRangeException();

            _zustatek += ulozka;
        }
        /// <summary>
        /// Vybere z účtu
        /// </summary>
        /// <param name="kolik">Částka k uložení</param>
        /// <returns>true, pokud byl zůstatek dostatečný, jinak false</returns>
        public bool Vyber(double kolik)
        {
            if (kolik <= _zustatek)
            {
                _zustatek -= kolik;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Urokuj(double urokovaMira)
        {
            //double urok = _zustatek / 100 * urokovaMira;
            //_zustatek += urok;
            _zustatek *= 1 + urokovaMira / 100;
        }
    }
}
