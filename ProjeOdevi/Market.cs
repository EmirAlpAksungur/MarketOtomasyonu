using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi
{
    class Market
    {
        private string girisKodu;
        private string marketAd;
        private string marketAdres;

        public string GirisKodu
        {
            get
            {
                return girisKodu;
            }
            set
            {
                girisKodu = value;
            }
        }
        public string MarketAd
        {
            get
            {
                return marketAd;
            }
            set
            {
                marketAd = value;
            }
        }
        public string MarketAdres
        {
            get
            {
                return marketAdres;
            }
            set
            {
                marketAdres = value;
            }
        }
      
        
    }
}
