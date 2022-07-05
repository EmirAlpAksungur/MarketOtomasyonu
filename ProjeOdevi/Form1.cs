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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string kullanici;
        private void giris_Click(object sender, EventArgs e)
        {
            
           
                KullaniciPaneli kullaniciPaneli = new KullaniciPaneli();    
                kullaniciPaneli.Show();
                this.Hide();
           

        }
    }
}
