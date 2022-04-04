using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_040_Pes_II
{
    class Pes
    {
        private string Jmeno;
        private int Nohy;
        public bool JeOckovany;

        public void SetNohy(int pocet)
        {
            if (pocet < 0 || pocet > 4)
                throw new ArgumentOutOfRangeException();

            Nohy = pocet;
        }

        public int GetNohy()
        {
            return Nohy;
        }

        public string GetJmeno()
        {
            return Jmeno;
        }
        public void SetJmeno(string jmeno)
        {
            if (jmeno.Contains(' '))
            {
                throw new ArgumentException("Jméno psa nesmí obsahovat mezeru");
            }

            Jmeno = jmeno;
        }

        public string PredstavSe()
        {
            return $"Já jsem pes, jmenuju se {Jmeno}, mám {Nohy} nohy a {(JeOckovany ? "jsem" : "nejsem")} očkovaný.";
        }
    }
}
