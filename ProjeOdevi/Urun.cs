using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi
{
    class Urun
    {
        private int urunKodu;
        private string urunAdı;
        private string adet;
        private string satisFiyati;
        private string alinanToptanciAdi;
        public int[] alinanMarketNo = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        private int marketNoAl;
        private int markettenSil;
        private int denetle;
        private string sonIndirimTarihi;

        public int UrunKodu
        {
            get
            {
                return urunKodu;
            }
            set
            {
                urunKodu = value;
            }
        }
        public int MarketNoAl
        {
            get
            {
                return marketNoAl;
            }
            set
            {
                marketNoAl = value;
                alinanMarketNo[marketNoAl] = marketNoAl;

            }
        }
        public int MarkettenSil
        {
            get
            {
                return markettenSil;
            }
            set
            {
                markettenSil = value;
                alinanMarketNo[markettenSil] = -1;

            }
        }
        public int Denetle
        {
            get
            {
                return denetle;
            }
            set
            {
                int gecici = value;
                denetle=alinanMarketNo[gecici];

            }
        }



        public string UrunAdı
        {
            get
            {
                return urunAdı;
            }
            set
            {
                urunAdı = value;
            }
        }
        public string Adet
        {
            get
            {
                return adet;
            }
            set
            {
                adet = value;
            }
        }
        public string SatisFiyati
        {
            get
            {
                return satisFiyati;
            }
            set
            {
                satisFiyati = value;
            }
        }
        public string AlinanToptanciAdi
        {
            get
            {
                return alinanToptanciAdi;
            }
            set
            {
                alinanToptanciAdi = value;
            }
        }
        public string SonIndirimTarihi
        {
            get
            {
                return sonIndirimTarihi;
            }
            set
            {
                sonIndirimTarihi = value;
            }
        }
       
    }
}
