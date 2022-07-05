using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi
{
    class Mudur : Calisan
    {
        private string mevki = "Müdür";
        public string Mevki
        {
            get
            {
                return mevki;
            }
            set
            {
                mevki = value;
            }
        }
    }
}
