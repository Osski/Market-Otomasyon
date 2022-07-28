using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using Microsoft.SqlServer.Server;

namespace marketotomasyon
{
    public partial class ÜrünEkle : Form
    {
        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");
        public ÜrünEkle()
        {
            InitializeComponent();
        }

        private void ÜrünEkle_Load(object sender, EventArgs e)
        {
            grupgetir();

        }

        private void grupgetir()
        {
            
            SQLiteDataAdapter da = new SQLiteDataAdapter("select grup_id ,nitelik from urun_gruplari", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (textBox1.Text == String.Empty)
                hata = 1;

            if (textBox2.Text == String.Empty)
                hata = 1;

            if (textBox4.Text == String.Empty)
                hata = 1;

            if (hata == 1)
            {
                MessageBox.Show("ADI,ÜRÜN_NO ve Fiyat alanları boş geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SQLiteConnection.ClearAllPools();


            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("insert into urunler(urun_adi,barkodno,grup_no,marka,gramaj,fiyat,stok_sayısı) values (@urun_adi,@barkodno,@grup_no,@marka,@gramaj,@fiyat,@stok_sayısı)");
            komut.Connection = bag;
            komut.Parameters.AddWithValue("@urun_adi",textBox1.Text);
            komut.Parameters.AddWithValue("@barkodno", Convert.ToInt32(textBox2.Text));
            komut.Parameters.AddWithValue("@grup_no", Convert.ToInt32(textBox3.Text));
            komut.Parameters.AddWithValue("@marka", textBox5.Text);
            komut.Parameters.AddWithValue("@gramaj", textBox6.Text);
            komut.Parameters.AddWithValue("@fiyat", textBox4.Text);
            komut.Parameters.AddWithValue("@stok_sayısı", Convert.ToInt32(textBox11.Text));
            komut.ExecuteNonQuery();
            bag.Close();

            MessageBox.Show("Kayıt Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (textBox7.Text == String.Empty)
                hata = 1;

            if (textBox9.Text == String.Empty)
                hata = 1;

            if (hata == 1)
            {
                MessageBox.Show("GRUP_NO VE KDV BOŞ GEÇİLEMEZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("insert into urun_gruplari(grup_id,nitelik,kdv,saklama_kriteri) values (@grup_id,@nitelik,@kdv,@saklama_kriteri)");
            komut.Connection = bag;
           
            komut.Parameters.AddWithValue("@grup_id", textBox7.Text);
            komut.Parameters.AddWithValue("@nitelik", textBox8.Text);
            komut.Parameters.AddWithValue("@kdv", textBox9.Text);
            komut.Parameters.AddWithValue("@saklama_kriteri", textBox10.Text);
            komut.ExecuteNonQuery();
            bag.Close();

            MessageBox.Show("Grup Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            grupgetir();
        }
    }
}
