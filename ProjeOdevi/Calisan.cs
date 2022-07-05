using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi
{
    class Calisan
    {
        private string kod;
        private string ad;
        private string soyad;
        private string tc;
        private string telefon;
        private string adres;
        private string saglikDuru;
        private string cinsiyet;
        private int haftalikIzin = 1;
        private int yillikIzin = 14;
        private int maas;
        private string sube;
        private string tarih;

        public string Kod
        {
            get
            {
                return kod;
            }
            set
            {
                kod = value;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string TC
        {
            get
            {
                return tc;
            }
            set
            {
                tc = value;
            }
        }
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }
        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }
        public int HaftalikIzin
        {
            get
            {
                return haftalikIzin;
            }
            set
            {
                haftalikIzin = value;
            }
        }
        public int YillikIzin
        {
            get
            {
                return yillikIzin;
            }
            set
            {
                yillikIzin = value;
            }

        }
        public string SaglikDuru
        {
            get
            {
                return saglikDuru;
            }
            set
            {
                saglikDuru = value;
            }
        }
        public string Cinsiyet
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
        public int Maas
        {
            get
            {
                return maas;
            }
            set
            {
                maas = value;
            }
        }
        public string Sube
        {
            get
            {
                return sube;
            }
            set
            {
                sube = value;
            }
        }
        public string Tarih
        {
            get
            {
                return tarih;
            }
            set
            {
                tarih = value;
            }
        }
    }
}
