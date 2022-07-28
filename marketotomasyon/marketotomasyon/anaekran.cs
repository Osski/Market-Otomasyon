using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketotomasyon
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        private void btnsatıs_Click(object sender, EventArgs e)
        {
            SatışEkran satısekran = new SatışEkran();
            satısekran.Show();
        }

        private void btnürünekle_Click(object sender, EventArgs e)
        {
            ÜrünEkle ürünEkle = new ÜrünEkle();
            ürünEkle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ürünler ürünler = new Ürünler();
            ürünler.Show();
        }

        private void btnmüşteri_Click(object sender, EventArgs e)
        {
            Müşteriler müşteriler = new Müşteriler();
            müşteriler.Show();
        }

        private void btnfirma_Click(object sender, EventArgs e)
        {
            Firmalar firmalar = new Firmalar();
            firmalar.Show();
        }

        private void btnrapor_Click(object sender, EventArgs e)
        {
            Satışsalrapor satışsalrapor = new Satışsalrapor();
            satışsalrapor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult result1= MessageBox.Show("Kapatılacak", "eminmisiniz", MessageBoxButtons.YesNo);
            if (result1==DialogResult.Yes)
            {
             Application.Exit();
            }
            
        }

        private void anaekran_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
          

                form1.Show();
        }
        //tüm formlar ana sayfadan açılıyor.
    }
}
