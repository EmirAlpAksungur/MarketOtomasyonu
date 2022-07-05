using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }
        
        private void iseAlimTemizle_Click(object sender, EventArgs e)
        {
            iseAlimClear();
        }
        public void iseAlimClear()
        {
            adtxt.Text = "";
            soyadtxt.Text = "";
            tctxt.Text = "";
            telefontxt.Text = "";
            calisabilir.Checked = false;
            calisamaz.Checked = false;
            erkek.Checked = false;
            kadin.Checked = false;
            mudur.Checked = false;
            mudurYardimcisi.Checked = false;
            kasiyer.Checked = false;
            adrestxt.Text = "";
            maastxt.Text = "";
        }

        private void maastxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        Mudur[] calisanMudur = new Mudur[100];
        MudurYRD[] calisanMudurYRD = new MudurYRD[100];
        Kasiyer[] calisanKasiyer = new Kasiyer[100];
        int calisanMudurNoSay = 0;
        int calisanMudurYRDNoSay = 0;
        int calisanKasiyerNoSay = 0;

        private void clsnEkle_Click(object sender, EventArgs e)
        {

            if (adtxt.Text == "")
            {
                MessageBox.Show("Ad kısmını boş bırakamazsınız.");
                return;
            }
            if (soyadtxt.Text == "")
            {
                MessageBox.Show("Soyad kısmını boş bırakamazsınız.");
                return;
            }
            if (tctxt.Text == "")
            {
                MessageBox.Show("TC kısmını boş bırakamazsınız.");
                return;
            }
            if (adrestxt.Text == "")
            {
                MessageBox.Show("Adres kısmını boş bırakamazsınız.");
                return;
            }
            if (calisabilir.Checked == false && calisamaz.Checked == false)
            {
                MessageBox.Show("Sağlık durumunu seçmek zorunludur.");
                return;
            }
            if (calisamaz.Checked == true)
            {
                MessageBox.Show("Sağlık durumunu çalışmaya müsait değil.");
                return;
            }
            if (clsnSubesiSec.CheckedItems.Count>1)
            {
                MessageBox.Show("1den fazla şube seçemezsiniz");
                return;
            }

            
            if (mudur.Checked == true)
            {
                
                calisanMudur[calisanMudurNoSay] = new Mudur();
                calisanMudur[calisanMudurNoSay].Kod = calisanMudurNoSay.ToString();
                calisanMudur[calisanMudurNoSay].Ad = adtxt.Text;
                calisanMudur[calisanMudurNoSay].Soyad = soyadtxt.Text;
                calisanMudur[calisanMudurNoSay].TC = tctxt.Text;
                calisanMudur[calisanMudurNoSay].Telefon = telefontxt.Text;
                calisanMudur[calisanMudurNoSay].Maas = int.Parse(maastxt.Text);
                calisanMudur[calisanMudurNoSay].SaglikDuru = (calisabilir.Checked == true) ? "Çalışabilir" : "Çalışamaz";
                calisanMudur[calisanMudurNoSay].Cinsiyet = (erkek.Checked == true) ? "erkek" : "kadin";
                calisanMudur[calisanMudurNoSay].Adres = adrestxt.Text;
                foreach (object a in clsnSubesiSec.CheckedItems)
                {
                    calisanMudur[calisanMudurNoSay].Sube = a.ToString();
                }
                calisanMudur[calisanMudurNoSay].Tarih = DateTime.Now.ToString();
                calisanMudurNoSay++;
                clsnGüncelle();
                int gecici=0;
                foreach (object a in clsnSubesiSec.Items)
                {
                    
                    if(calisanMudur[calisanMudurNoSay-1].Sube==a.ToString())
                    {
                        listMrktCalisan[gecici].Text += calisanMudur[calisanMudurNoSay-1].Ad+" " + calisanMudur[calisanMudurNoSay-1].Soyad+",";
                        return;
                    }
                    gecici++;
                }


               
            }
            else if (mudurYardimcisi.Checked == true)
            {
                calisanMudurYRD[calisanMudurYRDNoSay] = new MudurYRD();
                calisanMudurYRD[calisanMudurYRDNoSay].Kod = calisanMudurYRDNoSay.ToString();
                calisanMudurYRD[calisanMudurYRDNoSay].Ad = adtxt.Text;
                calisanMudurYRD[calisanMudurYRDNoSay].Soyad = soyadtxt.Text;
                calisanMudurYRD[calisanMudurYRDNoSay].TC = tctxt.Text;
                calisanMudurYRD[calisanMudurYRDNoSay].Telefon = telefontxt.Text;
                calisanMudurYRD[calisanMudurYRDNoSay].Maas = int.Parse(maastxt.Text);
                calisanMudurYRD[calisanMudurYRDNoSay].Adres = adrestxt.Text;
                calisanMudurYRD[calisanMudurYRDNoSay].SaglikDuru = (calisabilir.Checked == true) ? "Çalışabilir" : "Çalışamaz";
                calisanMudurYRD[calisanMudurYRDNoSay].Cinsiyet = (erkek.Checked == true) ? "erkek" : "kadin";
                foreach (object a in clsnSubesiSec.CheckedItems)
                {
                    calisanMudurYRD[calisanMudurYRDNoSay].Sube = a.ToString();
                }
                int gecici = 0;
                calisanMudurYRD[calisanMudurYRDNoSay].Tarih = DateTime.Now.ToString();
                calisanMudurYRDNoSay++;
                clsnGüncelle();
                foreach (object a in clsnSubesiSec.Items)
                {

                    if (calisanMudurYRD[calisanMudurYRDNoSay-1].Sube == a.ToString())
                    {
                        listMrktCalisan[gecici].Text += calisanMudurYRD[calisanMudurYRDNoSay-1].Ad + " " + calisanMudurYRD[calisanMudurYRDNoSay-1].Soyad+",";
                        return;
                    }
                    gecici++;
                }
                
            }
            else if (kasiyer.Checked == true)
            {
                calisanKasiyer[calisanKasiyerNoSay] = new Kasiyer();
                calisanKasiyer[calisanKasiyerNoSay].Kod = calisanKasiyerNoSay.ToString();
                calisanKasiyer[calisanKasiyerNoSay].Ad = adtxt.Text;
                calisanKasiyer[calisanKasiyerNoSay].Soyad = soyadtxt.Text;
                calisanKasiyer[calisanKasiyerNoSay].TC = tctxt.Text;
                calisanKasiyer[calisanKasiyerNoSay].Telefon = telefontxt.Text;
                calisanKasiyer[calisanKasiyerNoSay].Maas = int.Parse(maastxt.Text);
                calisanKasiyer[calisanKasiyerNoSay].Adres = adrestxt.Text;
                calisanKasiyer[calisanKasiyerNoSay].SaglikDuru = (calisabilir.Checked == true) ? "Çalışabilir" : "Çalışamaz";
                calisanKasiyer[calisanKasiyerNoSay].Cinsiyet = (erkek.Checked == true) ? "erkek" : "kadin";
                foreach (object a in clsnSubesiSec.CheckedItems)
                {
                    calisanKasiyer[calisanKasiyerNoSay].Sube = a.ToString();
                }
                calisanKasiyer[calisanKasiyerNoSay].Tarih = DateTime.Now.ToString();
                calisanKasiyerNoSay++;
                clsnGüncelle();
                int gecici = 0;
                foreach (object a in clsnSubesiSec.Items)
                {
                    
                    if (calisanKasiyer[calisanKasiyerNoSay-1].Sube == a.ToString())
                    {
                        listMrktCalisan[gecici].Text += calisanKasiyer[calisanKasiyerNoSay-1].Ad + " " + calisanKasiyer[calisanKasiyerNoSay-1].Soyad+",";
                        return;
                    }
                    gecici++;
                }
               
            }
            else
            {
                MessageBox.Show("Mevki seçmelisiniz.");
                return;
            }
            iseAlimClear();
        }

        private void calisanBilgiGuncelle_Click(object sender, EventArgs e)
        {
            clsnGüncelle();
        }
        public void clsnGüncelle()
        {
            calisanBilgi.Items.Clear();
            for(int k = 0; k < calisanMudurNoSay; k++)
            {
                calisanBilgi.Items.Add("Kod:" + calisanMudur[k].Kod);
                calisanBilgi.Items.Add("Ad:" + calisanMudur[k].Ad);
                calisanBilgi.Items.Add("Soyad:" + calisanMudur[k].Soyad);
                calisanBilgi.Items.Add("Tc:" + calisanMudur[k].TC);
                calisanBilgi.Items.Add("Telefon:" + calisanMudur[k].Telefon);
                calisanBilgi.Items.Add("Maas:" + calisanMudur[k].Maas.ToString());
                calisanBilgi.Items.Add("Mevki:" + calisanMudur[k].Mevki);
                calisanBilgi.Items.Add("Adres:" + calisanMudur[k].Adres);
                calisanBilgi.Items.Add("Saglik Durum:" + calisanMudur[k].SaglikDuru);
                calisanBilgi.Items.Add("Cinsiyet" + calisanMudur[k].Cinsiyet);
                calisanBilgi.Items.Add("CalisilanSubeNo" + calisanMudur[k].Sube);
                calisanBilgi.Items.Add("İse Alım Tarihi:" + calisanMudur[k].Tarih);
                calisanBilgi.Items.Add("Kalan Haftalık İzin:" + calisanMudur[k].HaftalikIzin.ToString());
                calisanBilgi.Items.Add("Kalan Yıllık İzin:" + calisanMudur[k].YillikIzin.ToString());
                calisanBilgi.Items.Add("----------------------------------");
            }
            for(int k = 0; k < calisanMudurYRDNoSay; k++)
            {
                calisanBilgi.Items.Add("Kod:" + calisanMudurYRD[k].Kod);
                calisanBilgi.Items.Add("Ad:" + calisanMudurYRD[k].Ad);
                calisanBilgi.Items.Add("Soyad:" + calisanMudurYRD[k].Soyad);
                calisanBilgi.Items.Add("Tc:" + calisanMudurYRD[k].TC);
                calisanBilgi.Items.Add("Telefon:" + calisanMudurYRD[k].Telefon);
                calisanBilgi.Items.Add("Maas:" + calisanMudurYRD[k].Maas.ToString());
                calisanBilgi.Items.Add("Mevki:" + calisanMudurYRD[k].Mevki);
                calisanBilgi.Items.Add("Adres:" + calisanMudurYRD[k].Adres);
                calisanBilgi.Items.Add("Saglik Durum:" + calisanMudurYRD[k].SaglikDuru);
                calisanBilgi.Items.Add("Cinsiyet" + calisanMudurYRD[k].Cinsiyet);
                calisanBilgi.Items.Add("CalisilanSubeNo" + calisanMudurYRD[k].Sube);
                calisanBilgi.Items.Add("İse Alım Tarihi:" + calisanMudurYRD[k].Tarih);
                calisanBilgi.Items.Add("Kalan Haftalık İzin:" + calisanMudurYRD[k].HaftalikIzin.ToString());
                calisanBilgi.Items.Add("Kalan Yıllık İzin:" + calisanMudurYRD[k].YillikIzin.ToString());
                calisanBilgi.Items.Add("----------------------------------");
            }
            for (int k = 0; k < calisanKasiyerNoSay; k++)
            {
                calisanBilgi.Items.Add("Kod:" + calisanKasiyer[k].Kod);
                calisanBilgi.Items.Add("Ad:" + calisanKasiyer[k].Ad);
                calisanBilgi.Items.Add("Soyad:" + calisanKasiyer[k].Soyad);
                calisanBilgi.Items.Add("Tc:" + calisanKasiyer[k].TC);
                calisanBilgi.Items.Add("Telefon:" + calisanKasiyer[k].Telefon);
                calisanBilgi.Items.Add("Maas:" + calisanKasiyer[k].Maas.ToString());
                calisanBilgi.Items.Add("Mevki:" + calisanKasiyer[k].Mevki);
                calisanBilgi.Items.Add("Adres:" + calisanKasiyer[k].Adres);
                calisanBilgi.Items.Add("Saglik Durum:" + calisanKasiyer[k].SaglikDuru);
                calisanBilgi.Items.Add("Cinsiyet" + calisanKasiyer[k].Cinsiyet);
                calisanBilgi.Items.Add("CalisilanSubeNo" + calisanKasiyer[k].Sube);
                calisanBilgi.Items.Add("İse Alım Tarihi:" + calisanKasiyer[k].Tarih);
                calisanBilgi.Items.Add("Kalan Haftalık İzin:" + calisanKasiyer[k].HaftalikIzin.ToString());
                calisanBilgi.Items.Add("Kalan Yıllık İzin:" + calisanKasiyer[k].YillikIzin.ToString());
                calisanBilgi.Items.Add("----------------------------------");
            }
        }

        private void clsnGetir_Click(object sender, EventArgs e)
        {

            if (clsnBilgiMudur.Checked == true)
            {            
                for (int k = 0; k < calisanMudurNoSay; k++)
                {
                    if (calisanMudur[k].Kod == clsnKod.Text)
                    {
                        clsnBilgiGnclPanel.Show();
                        clsnIsim.Text = calisanMudur[k].Ad;
                        clsnTelefon.Text = calisanMudur[k].Telefon;
                        clsnMaas.Text = calisanMudur[k].Maas.ToString();
                        clsnHaftalikIzin.Text = calisanMudur[k].HaftalikIzin.ToString();
                        clsnYillikIzin.Text = calisanMudur[k].YillikIzin.ToString();
                        if (calisanMudur[k].SaglikDuru == "Çalışabilir")
                        {
                            clsnCalisabilir.Checked = true;
                        }
                        else
                        {
                            clsnCalisamaz.Checked = true;
                        }
                        clsnMudur.Checked = true;
                        clsnAdres.Text = calisanMudur[k].Adres;
                        for (int i=0;i<marketSay ; i++)
                        {
                            if (calisanMudur[k].Sube == bilgiGuncelleSube.Items[i].ToString())
                            {
                                bilgiGuncelleSube.SetItemChecked(i,true);
                            }
                        }
                        
                    }
                }
            }
            else if (clsnBilgiMudurYRD.Checked == true)
            {
                for (int k = 0; k < calisanMudurYRDNoSay; k++)
                {
                    if (calisanMudurYRD[k].Kod == clsnKod.Text)
                    {
                        clsnBilgiGnclPanel.Show();
                        clsnIsim.Text = calisanMudurYRD[k].Ad;
                        clsnTelefon.Text = calisanMudurYRD[k].Telefon;
                        clsnMaas.Text = calisanMudurYRD[k].Maas.ToString();
                        clsnHaftalikIzin.Text = calisanMudurYRD[k].HaftalikIzin.ToString();
                        clsnYillikIzin.Text = calisanMudurYRD[k].YillikIzin.ToString();
                        if (calisanMudurYRD[k].SaglikDuru == "Çalışabilir")
                        {
                            clsnCalisabilir.Checked = true;
                        }
                        else
                        {
                            clsnCalisamaz.Checked = true;
                        }
                        clsnMudurYrd.Checked = true;
                        clsnAdres.Text = calisanMudurYRD[k].Adres;
                        for (int i = 0; i < marketSay; i++)
                        {
                            if (calisanMudurYRD[k].Sube == bilgiGuncelleSube.Items[i].ToString())
                            {
                                bilgiGuncelleSube.SetItemChecked(i, true);
                            }
                        }

                    }
                }
            }
            else if (clsnBilgiKasiyer.Checked == true)
            {
                for (int k = 0; k < calisanKasiyerNoSay; k++)
                {
                    if (calisanKasiyer[k].Kod == clsnKod.Text)
                    {
                        clsnBilgiGnclPanel.Show();
                        clsnIsim.Text = calisanKasiyer[k].Ad;
                        clsnTelefon.Text = calisanKasiyer[k].Telefon;
                        clsnMaas.Text = calisanKasiyer[k].Maas.ToString();
                        clsnHaftalikIzin.Text = calisanKasiyer[k].HaftalikIzin.ToString();
                        clsnYillikIzin.Text = calisanKasiyer[k].YillikIzin.ToString();
                        if (calisanKasiyer[k].SaglikDuru == "Çalışabilir")
                        {
                            clsnCalisabilir.Checked = true;
                        }
                        else
                        {
                            clsnCalisamaz.Checked = true;
                        }
                        clsnKasiyer.Checked = true;
                        clsnAdres.Text = calisanKasiyer[k].Adres;
                        for (int i = 0; i < marketSay; i++)
                        {
                            if (calisanKasiyer[k].Sube == bilgiGuncelleSube.Items[i].ToString())
                            {
                                bilgiGuncelleSube.SetItemChecked(i, true);
                            }
                        }

                    }
                }
            }
        }

        private void clsnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            
            if (bilgiGuncelleSube.CheckedItems.Count>1)
            {
                MessageBox.Show("Tek 1 şube seçmelisiniz.");
                return;
            }
            if (clsnBilgiMudur.Checked == true)
            {
                
                for (int k = 0; k < calisanMudurNoSay; k++)
                {
                   
                    if (calisanMudur[k].Kod == clsnKod.Text)
                    {
                        if (calisanMudur[k].Maas > int.Parse(clsnMaas.Text))
                        {
                            MessageBox.Show("Maaşı Düşüremezsiniz.");
                            return;
                        }
                        clsnBilgiGnclPanel.Hide();
                        calisanMudur[k].Telefon = clsnTelefon.Text;
                        calisanMudur[k].Maas = int.Parse(clsnMaas.Text);
                        calisanMudur[k].HaftalikIzin = int.Parse(clsnHaftalikIzin.Text);
                        calisanMudur[k].YillikIzin = int.Parse(clsnYillikIzin.Text);
                        if (clsnCalisabilir.Checked == true)
                        {
                            calisanMudur[k].SaglikDuru = "Çalışabilir";
                        }
                        else
                        {
                            calisanMudur[k].SaglikDuru = "Çalışamaz";
                        }
                        if (clsnMudur.Checked == true)
                        {
                            calisanMudur[k].Mevki = "Müdür";
                        }
                        else if(clsnMudurYrd.Checked == true)
                        {
                            calisanMudur[k].Mevki = "MüdürYardımcısı";
                        }
                        else if (clsnKasiyer.Checked == true)
                        {
                            calisanMudur[k].Mevki = "Kasiyer";
                        }
                        calisanMudur[k].Adres = clsnAdres.Text;
                        foreach (object a in bilgiGuncelleSube.CheckedItems)
                        {
                            calisanMudur[k].Sube = a.ToString();
                        }
                        
                        clsnGüncelle();
                    }
                }
            }
            else if (clsnBilgiMudurYRD.Checked == true)
            {
                for (int k = 0; k < calisanMudurYRDNoSay; k++)
                {
                    
                    if (calisanMudurYRD[k].Kod == clsnKod.Text)
                    {
                        if (calisanMudurYRD[k].Maas > int.Parse(clsnMaas.Text))
                        {
                            MessageBox.Show("Maaşı Düşüremezsiniz.");
                            return;
                        }
                        clsnBilgiGnclPanel.Hide();
                        calisanMudurYRD[k].Telefon = clsnTelefon.Text;
                        calisanMudurYRD[k].Maas = int.Parse(clsnMaas.Text);
                        calisanMudurYRD[k].HaftalikIzin = int.Parse(clsnHaftalikIzin.Text);
                        calisanMudurYRD[k].YillikIzin = int.Parse(clsnYillikIzin.Text);
                        if (clsnCalisabilir.Checked == true)
                        {
                            calisanMudurYRD[k].SaglikDuru = "Çalışabilir";
                        }
                        else
                        {
                            calisanMudurYRD[k].SaglikDuru = "Çalışamaz";
                        }
                        if (clsnMudur.Checked == true)
                        {
                            calisanMudurYRD[k].Mevki = "Müdür";
                        }
                        else if (clsnMudurYrd.Checked == true)
                        {
                            calisanMudurYRD[k].Mevki = "MüdürYardımcısı";
                        }
                        else if (clsnKasiyer.Checked == true)
                        {
                            calisanMudurYRD[k].Mevki = "Kasiyer";
                        }
                        calisanMudurYRD[k].Adres = clsnAdres.Text;
                        foreach (object a in bilgiGuncelleSube.CheckedItems)
                        {
                            calisanMudurYRD[k].Sube = a.ToString();
                        }
                        
                        clsnGüncelle();
                    }
                }
            }
            else if (clsnBilgiKasiyer.Checked == true)
            {
                for (int k = 0; k < calisanKasiyerNoSay; k++)
                {
                    if (calisanKasiyer[k].Kod == clsnKod.Text)
                    {
                        if (calisanKasiyer[k].Maas > int.Parse(clsnMaas.Text))
                        {
                            MessageBox.Show("Maaşı Düşüremezsiniz.");
                            return;
                        }
                        clsnBilgiGnclPanel.Hide();
                        calisanKasiyer[k].Telefon = clsnTelefon.Text;
                        calisanKasiyer[k].Maas = int.Parse(clsnMaas.Text);
                        calisanKasiyer[k].HaftalikIzin = int.Parse(clsnHaftalikIzin.Text);
                        calisanKasiyer[k].YillikIzin = int.Parse(clsnYillikIzin.Text);
                        if (clsnCalisabilir.Checked == true)
                        {
                            calisanKasiyer[k].SaglikDuru = "Çalışabilir";
                        }
                        else
                        {
                            calisanKasiyer[k].SaglikDuru = "Çalışamaz";
                        }
                        if (clsnMudur.Checked == true)
                        {
                            calisanKasiyer[k].Mevki = "Müdür";
                        }
                        else if (clsnMudurYrd.Checked == true)
                        {
                            calisanKasiyer[k].Mevki = "MüdürYardımcısı";
                        }
                        else if (clsnKasiyer.Checked == true)
                        {
                            calisanKasiyer[k].Mevki = "Kasiyer";
                        }
                        calisanKasiyer[k].Adres = clsnAdres.Text;
                        foreach (object a in bilgiGuncelleSube.CheckedItems)
                        {
                            calisanKasiyer[k].Sube = a.ToString();
                        }
                        clsnGüncelle();
                    }
                }
            }
        }
        Market[] market = new Market[20];
        ListBox[] listTemizlik = new ListBox[20];
        ListBox[] listGida = new ListBox[20];
        ListBox[] listKampanya = new ListBox[20];
        Label[] listMrktCalisan = new Label[20];
        int marketSay = 0;
        
        private void marketEkle_Click(object sender, EventArgs e)
        {
            
            if (marketAdtxt.Text=="")
            {
                MessageBox.Show("Market Adını Boş Bırakamazsınız");
                return;
            }
            if (marketAdrestxt.Text == "")
            {
                MessageBox.Show("Market Adını Boş Bırakamazsınız");
                return;
            }

            market[marketSay] = new Market();
            market[marketSay].GirisKodu = marketSay.ToString();
            market[marketSay].MarketAd = marketAdtxt.Text;
            market[marketSay].MarketAdres = marketAdrestxt.Text;
            marketSec.Items.Add(market[marketSay].MarketAd);
            clsnSubesiSec.Items.Add(market[marketSay].MarketAd);
            bilgiGuncelleSube.Items.Add(market[marketSay].MarketAd);
            indirimMarketList.Items.Add(market[marketSay].MarketAd);
            Panel yeniMarket = new Panel();

            if (marketSay % 2 == 0)
            {
                yeniMarket.Location = new Point(10, 840 + ((marketSay / 2) * 195));
            }
            if (marketSay % 2 == 1)
            {
                yeniMarket.Location = new Point(769, 840 + (((marketSay - 1) / 2) * 195));
            }
            yeniMarket.Size = new Size(748, 195);
            yeniMarket.BackColor = Color.FromArgb(44, 62, 80);
            this.Controls.Add(yeniMarket);
            Label yeniLabel = new Label();
            yeniLabel.Text = "Market Adı:" + market[marketSay].MarketAd + "\nMarket Adresi:" + market[marketSay].MarketAdres + "\nMarket No:" + marketSay.ToString();
            yeniLabel.Location = new Point(10, 10);
            yeniLabel.ForeColor = Color.White;
            yeniLabel.Width = 790;
            yeniLabel.Height = 40;
            yeniMarket.Controls.Add(yeniLabel);
            Label mrktCalisanEkle = new Label();
            listMrktCalisan[marketSay] = mrktCalisanEkle;
            mrktCalisanEkle.Text = "Çalışanlar:";
            mrktCalisanEkle.Location = new Point(10, 50);
            mrktCalisanEkle.ForeColor = Color.White;
            mrktCalisanEkle.Width = 790;
            mrktCalisanEkle.Height = 20;
            yeniMarket.Controls.Add(mrktCalisanEkle);

            ListBox temizlikListBox = new ListBox();
            listTemizlik[marketSay] = temizlikListBox;
            temizlikListBox.Width = 220;
            temizlikListBox.Height = 110;
            temizlikListBox.Location = new Point(10, 70);
            yeniMarket.Controls.Add(temizlikListBox);


            ListBox gidaListBox = new ListBox();
            listGida[marketSay] = gidaListBox;
            gidaListBox.Width = 220;
            gidaListBox.Height = 110;
            gidaListBox.Location = new Point(240, 70);
            yeniMarket.Controls.Add(gidaListBox);

            ListBox kampanyaListBox = new ListBox();
            listKampanya[marketSay] = kampanyaListBox;
            kampanyaListBox.Width = 220;
            kampanyaListBox.Height = 110;
            kampanyaListBox.Location = new Point(470, 70);
            yeniMarket.Controls.Add(kampanyaListBox);
            marketSay++;
        }

        private void maasaGoreSirala_Click(object sender, EventArgs e)
        {
            calisanBilgi.Items.Clear();
            int[] geciciDizi = new int[calisanKasiyerNoSay+calisanMudurNoSay+calisanMudurYRDNoSay];
            int geciciDiziSayi=0;
            int gecici = 0;
            for (int k = 0 ; k < calisanKasiyerNoSay; k++)
            {
                geciciDizi[geciciDiziSayi] = calisanKasiyer[k].Maas;
                geciciDiziSayi++;
            }
            for(int k= geciciDiziSayi; k< calisanKasiyerNoSay+ calisanMudurNoSay; k++)
            {
                geciciDizi[k] = calisanMudur[gecici].Maas;
                geciciDiziSayi++;
                gecici++;
            }
            gecici = 0;
            for (int k = geciciDiziSayi; k < calisanKasiyerNoSay + calisanMudurNoSay + calisanMudurYRDNoSay; k++)
            {
                geciciDizi[geciciDiziSayi] = calisanMudur[gecici].Maas;
                gecici++;
            }
            for (int k=0;k< geciciDiziSayi; k++)
            {
                for (int i=k+1;i< geciciDiziSayi; i++)
                {
                    if (geciciDizi[k] < geciciDizi[i])
                    {
                        gecici = geciciDizi[i];
                        geciciDizi[i] = geciciDizi[k];
                        geciciDizi[k] = gecici;           
                    }
                }
            }
            for (int i=0;i<geciciDiziSayi;i++)
            {
                for (int k=0;k< calisanKasiyerNoSay; k++)
                {
                    if(geciciDizi[i]== calisanKasiyer[k].Maas)
                    {
                        calisanBilgi.Items.Add("Kod:" + calisanKasiyer[k].Kod);
                        calisanBilgi.Items.Add("Ad:" + calisanKasiyer[k].Ad);
                        calisanBilgi.Items.Add("Soyad:" + calisanKasiyer[k].Soyad);
                        calisanBilgi.Items.Add("Tc:" + calisanKasiyer[k].TC);
                        calisanBilgi.Items.Add("Telefon:" + calisanKasiyer[k].Telefon);
                        calisanBilgi.Items.Add("Maas:" + calisanKasiyer[k].Maas.ToString());
                        calisanBilgi.Items.Add("Mevki:" + calisanKasiyer[k].Mevki);
                        calisanBilgi.Items.Add("Adres:" + calisanKasiyer[k].Adres);
                        calisanBilgi.Items.Add("Saglik Durum:" + calisanKasiyer[k].SaglikDuru);
                        calisanBilgi.Items.Add("Cinsiyet" + calisanKasiyer[k].Cinsiyet);
                        calisanBilgi.Items.Add("CalisilanSubeNo" + calisanKasiyer[k].Sube);
                        calisanBilgi.Items.Add("İse Alım Tarihi:" + calisanKasiyer[k].Tarih);
                        calisanBilgi.Items.Add("Kalan Haftalık İzin:" + calisanKasiyer[k].HaftalikIzin.ToString());
                        calisanBilgi.Items.Add("Kalan Yıllık İzin:" + calisanKasiyer[k].YillikIzin.ToString());
                        calisanBilgi.Items.Add("----------------------------------");
                    }
                }
                for (int k = 0; k < calisanMudurNoSay; k++)
                {
                    if (geciciDizi[i] == calisanMudur[k].Maas)
                    {
                        calisanBilgi.Items.Add("Kod:" + calisanMudur[k].Kod);
                        calisanBilgi.Items.Add("Ad:" + calisanMudur[k].Ad);
                        calisanBilgi.Items.Add("Soyad:" + calisanMudur[k].Soyad);
                        calisanBilgi.Items.Add("Tc:" + calisanMudur[k].TC);
                        calisanBilgi.Items.Add("Telefon:" + calisanMudur[k].Telefon);
                        calisanBilgi.Items.Add("Maas:" + calisanMudur[k].Maas.ToString());
                        calisanBilgi.Items.Add("Mevki:" + calisanMudur[k].Mevki);
                        calisanBilgi.Items.Add("Adres:" + calisanMudur[k].Adres);
                        calisanBilgi.Items.Add("Saglik Durum:" + calisanMudur[k].SaglikDuru);
                        calisanBilgi.Items.Add("Cinsiyet" + calisanMudur[k].Cinsiyet);
                        calisanBilgi.Items.Add("CalisilanSubeNo" + calisanMudur[k].Sube);
                        calisanBilgi.Items.Add("İse Alım Tarihi:" + calisanMudur[k].Tarih);
                        calisanBilgi.Items.Add("Kalan Haftalık İzin:" + calisanMudur[k].HaftalikIzin.ToString());
                        calisanBilgi.Items.Add("Kalan Yıllık İzin:" + calisanMudur[k].YillikIzin.ToString());
                        calisanBilgi.Items.Add("----------------------------------");
                    }
                }
                for (int k = 0; k < calisanMudurYRDNoSay; k++)
                {
                    if (geciciDizi[i] == calisanMudurYRD[k].Maas)
                    {
                        calisanBilgi.Items.Add("Kod:" + calisanMudurYRD[k].Kod);
                        calisanBilgi.Items.Add("Ad:" + calisanMudurYRD[k].Ad);
                        calisanBilgi.Items.Add("Soyad:" + calisanMudurYRD[k].Soyad);
                        calisanBilgi.Items.Add("Tc:" + calisanMudurYRD[k].TC);
                        calisanBilgi.Items.Add("Telefon:" + calisanMudurYRD[k].Telefon);
                        calisanBilgi.Items.Add("Maas:" + calisanMudurYRD[k].Maas.ToString());
                        calisanBilgi.Items.Add("Mevki:" + calisanMudurYRD[k].Mevki);
                        calisanBilgi.Items.Add("Adres:" + calisanMudurYRD[k].Adres);
                        calisanBilgi.Items.Add("Saglik Durum:" + calisanMudurYRD[k].SaglikDuru);
                        calisanBilgi.Items.Add("Cinsiyet" + calisanMudurYRD[k].Cinsiyet);
                        calisanBilgi.Items.Add("CalisilanSubeNo" + calisanMudurYRD[k].Sube);
                        calisanBilgi.Items.Add("İse Alım Tarihi:" + calisanMudurYRD[k].Tarih);
                        calisanBilgi.Items.Add("Kalan Haftalık İzin:" + calisanMudurYRD[k].HaftalikIzin.ToString());
                        calisanBilgi.Items.Add("Kalan Yıllık İzin:" + calisanMudurYRD[k].YillikIzin.ToString());
                        calisanBilgi.Items.Add("----------------------------------");
                    }
                }
            }

        }
        Urun[] urun = new Urun[1000];
        int urunSay=0;
        private void urunAl_Click(object sender, EventArgs e)
        {
            
            if (uruntxt.Text=="")
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz.");
                return;
            }
            if (urunAdettxt.Text == "")
            {
                MessageBox.Show("Ürün Adet Kısmı Boş Bırakılamaz.");
                return;

            }
            urun[urunSay] = new Urun();
            urun[urunSay].UrunKodu = urunSay;
            urun[urunSay].UrunAdı = uruntxt.Text;
            urun[urunSay].Adet = urunAdettxt.Text;
            urun[urunSay].SatisFiyati = urunSatistxt.Text;
            
            for (int k = 0; k < marketSec.Items.Count; k++)
            {
                if (marketSec.GetItemChecked(k))
                {
                    urun[urunSay].MarketNoAl = k;
                }
            }
            if (temizlikToptanci.Checked == true)
            {
                urun[urunSay].AlinanToptanciAdi = "Temizlik Ürünü Toptancısı";
            }
            else if(gidaToptanci.Checked == true)
            {
                urun[urunSay].AlinanToptanciAdi = "Gıda Ürünü Toptancısı";
            }
            else if (kampanyaToptanci.Checked == true)
            {
                urun[urunSay].AlinanToptanciAdi = "Kampanya Ürünü Toptancısı";
            }
            else
            {
                MessageBox.Show("Toptancı Seçmek Zorunlu");
            }
            urun[urunSay].SonIndirimTarihi = "Daha önce bir indirim yapılmadı";
            for(int k = 0; k < marketSec.Items.Count; k++)
            {
                if (marketSec.GetItemChecked(k))
                {
                    if (urun[urunSay].AlinanToptanciAdi== "Temizlik Ürünü Toptancısı")
                    {
                        listTemizlik[k].Items.Add("Urun Kodu:" + urun[urunSay].UrunKodu);
                        listTemizlik[k].Items.Add("Urun Adı:" + urun[urunSay].UrunAdı);
                        listTemizlik[k].Items.Add("Urun Adedi:" + urun[urunSay].Adet);
                        listTemizlik[k].Items.Add("Urun Satis Fiyati:" + urun[urunSay].SatisFiyati);
                        listTemizlik[k].Items.Add("Urun Son indirim Tarihi:" + urun[urunSay].SonIndirimTarihi);
                        listTemizlik[k].Items.Add("----------------------------------------");

                    }
                    else if (urun[urunSay].AlinanToptanciAdi == "Gıda Ürünü Toptancısı")
                    {
                        listGida[k].Items.Add("Urun Kodu:" + urun[urunSay].UrunKodu);
                        listGida[k].Items.Add("Urun Adı:" + urun[urunSay].UrunAdı);
                        listGida[k].Items.Add("Urun Adedi:" + urun[urunSay].Adet);
                        listGida[k].Items.Add("Urun Satis Fiyati:" + urun[urunSay].SatisFiyati);
                        listGida[k].Items.Add("Urun Son indirim Tarihi:" + urun[urunSay].SonIndirimTarihi);
                        listGida[k].Items.Add("----------------------------------------");
                     
                    }
                    else
                    {
                        listKampanya[k].Items.Add("Urun Kodu:" + urun[urunSay].UrunKodu);
                        listKampanya[k].Items.Add("Urun Adı:" + urun[urunSay].UrunAdı);
                        listKampanya[k].Items.Add("Urun Adedi:" + urun[urunSay].Adet);
                        listKampanya[k].Items.Add("Urun Satis Fiyati:" + urun[urunSay].SatisFiyati);
                        listKampanya[k].Items.Add("Urun Son indirim Tarihi:" + urun[urunSay].SonIndirimTarihi);
                        listKampanya[k].Items.Add("----------------------------------------");
                    }
                }
            }
            urunSay++;



        }

        public void KodileIndirimYap_Click(object sender, EventArgs e)
        {
            
            
            float gecici;
            gecici = ((float.Parse(urun[int.Parse(urunKodutxt.Text)].SatisFiyati)) / 100) * float.Parse(indirimMiktarıtxt.Text);
            urun[urunSay] = new Urun();
            urun[urunSay].SatisFiyati = (float.Parse(urun[int.Parse(urunKodutxt.Text)].SatisFiyati) - gecici).ToString();
            urun[urunSay].UrunKodu = urunSay;
            urun[urunSay].UrunAdı = urun[int.Parse(urunKodutxt.Text)].UrunAdı;
            urun[urunSay].Adet = urun[int.Parse(urunKodutxt.Text)].Adet;
            urun[urunSay].SonIndirimTarihi= DateTime.Now.ToString();

            for (int k = 0; k < indirimMarketList.Items.Count; k++)
            {
                if (indirimMarketList.GetItemChecked(k))
                {
                    urun[urunSay].MarketNoAl = k;
                    urun[int.Parse(urunKodutxt.Text)].MarkettenSil = k;
                    if (urun[int.Parse(urunKodutxt.Text)].AlinanToptanciAdi == "Temizlik Ürünü Toptancısı")
                    {
                        urun[urunSay].AlinanToptanciAdi = "Temizlik Ürünü Toptancısı";
                        listTemizlik[k].Items.Clear();
                        for (int i = 0; i<urunSay+1;i++)
                        {
                            for(int j=0;j<20; j++)
                            {
                                urun[i].Denetle = j;
                                if (urun[i].Denetle==k && urun[i].AlinanToptanciAdi == "Temizlik Ürünü Toptancısı")
                                {
                                    listTemizlik[k].Items.Add("Urun Kodu:" + urun[i].UrunKodu); 
                                    listTemizlik[k].Items.Add("Urun Adı:" + urun[i].UrunAdı);
                                    listTemizlik[k].Items.Add("Urun Adedi:" + urun[i].Adet);
                                    listTemizlik[k].Items.Add("Urun Satis Fiyati:" + urun[i].SatisFiyati);
                                    listTemizlik[k].Items.Add("Urun Son indirim Tarihi:" + urun[i].SonIndirimTarihi);
                                    listTemizlik[k].Items.Add("----------------------------------------");
                                }
                            }
                        }
                    }
                    else if (urun[int.Parse(urunKodutxt.Text)].AlinanToptanciAdi == "Gıda Ürünü Toptancısı")
                    {
                        urun[urunSay].AlinanToptanciAdi = "Gıda Ürünü Toptancısı";
                        listGida[k].Items.Clear();
                        for (int i = 0; i < urunSay+1; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                urun[i].Denetle = j;
                                if (urun[i].Denetle == k && urun[i].AlinanToptanciAdi == "Gıda Ürünü Toptancısı")
                                {
                                    listGida[k].Items.Add("Urun Kodu:" + urun[i].UrunKodu);
                                    listGida[k].Items.Add("Urun Adı:" + urun[i].UrunAdı);
                                    listGida[k].Items.Add("Urun Adedi:" + urun[i].Adet);
                                    listGida[k].Items.Add("Urun Satis Fiyati:" + urun[i].SatisFiyati);
                                    listGida[k].Items.Add("Urun Son indirim Tarihi:" + urun[i].SonIndirimTarihi);
                                    listGida[k].Items.Add("----------------------------------------");
                                }
                            }
                        }
                    }
                    else
                    {
                        urun[urunSay].AlinanToptanciAdi = "Kampanya Ürünü Toptancısı";
                        listKampanya[k].Items.Clear();
                        for (int i = 0; i < urunSay+1; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                urun[i].Denetle = j;
                                if (urun[i].Denetle == k && urun[i].AlinanToptanciAdi == "Kampanya Ürünü Toptancısı")
                                {
                                    listKampanya[k].Items.Add("Urun Kodu:" + urun[i].UrunKodu);
                                    listKampanya[k].Items.Add("Urun Adı:" + urun[i].UrunAdı);
                                    listKampanya[k].Items.Add("Urun Adedi:" + urun[i].Adet);
                                    listKampanya[k].Items.Add("Urun Satis Fiyati:" + urun[i].SatisFiyati);
                                    listKampanya[k].Items.Add("Urun Son indirim Tarihi:" + urun[i].SonIndirimTarihi);
                                    listKampanya[k].Items.Add("----------------------------------------");
                                }
                            }
                        }
                    }
                }
                
            }

            urunSay++;
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (kullanıcıAdı.Text == "Patron" && sifre.Text == "123456")
            {
                marketEklePanel.Visible = true;
                urunSatinAlimPanel.Visible = true;
                indirimPanel.Visible = true;
                calisanBilgiPanel.Visible = true;
                calisanBilgiGuncellePanel.Visible = true;
                clsnİseAlimPanel.Visible = true;
            }
            else if(kullanıcıAdı.Text == "Müdür" && sifre.Text == "123456")
            {
                marketEklePanel.Visible = false;
                urunSatinAlimPanel.Visible = false;
                indirimPanel.Visible = true;
                calisanBilgiPanel.Visible = false;
                calisanBilgiGuncellePanel.Visible = false;
                clsnİseAlimPanel.Visible = false;
            }
        }
    }
}
