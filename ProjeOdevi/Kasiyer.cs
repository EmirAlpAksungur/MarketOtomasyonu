using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi
{
    class Kasiyer : Calisan
    {
        private string mevki = "Kasiyer";
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
