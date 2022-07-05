using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi
{
    class MudurYRD : Calisan
    {
        private string mevki = "MüdürYardımcısı";
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
