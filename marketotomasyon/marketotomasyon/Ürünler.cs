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

namespace marketotomasyon
{
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }
        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");
        DataSet Daset =new DataSet();
        private void Ürünler_Load(object sender, EventArgs e)
        {
            ÜrünListele();
        }

        private void ÜrünListele()
        {
            bag.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from urunler", bag);
            da.Fill(Daset, "urunler");
            dataGridView1.DataSource = Daset.Tables["urunler"];
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bag.Close();
        }
       



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["grup_no"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["gramaj"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["stok_sayısı"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("update urunler set urun_adi=@urun_adi,grup_no=@grup_no,marka=@marka,gramaj=@gramaj,fiyat=@fiyat,stok_sayısı=@stok_sayısı where barkodno=@barkodno",bag);
           Daset.Tables["urunler"].Clear();
            komut.Parameters.AddWithValue("@urun_adi", textBox1.Text);
            komut.Parameters.AddWithValue("@barkodno", textBox2.Text);
            komut.Parameters.AddWithValue("@grup_no", textBox3.Text);
            komut.Parameters.AddWithValue("@marka", textBox4.Text);
            komut.Parameters.AddWithValue("@gramaj", textBox5.Text);
            komut.Parameters.AddWithValue("@fiyat", textBox6.Text);
            komut.Parameters.AddWithValue("@stok_sayısı", textBox8.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            ÜrünListele();
            MessageBox.Show("Güncelleme Yapıldı");
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
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("delete from urunler where barkodno= '"+ dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            Daset.Tables["barkodno"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi");

        }

       
    }
}
