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
    public partial class Firmalar : Form
    {
        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");
        DataSet daset = new DataSet();
        public Firmalar()
        {
            InitializeComponent();
        }

        private void Firmalar_Load(object sender, EventArgs e)
        {
            tedarikgetir();
        }

        private void tedarikgetir()
        {
            bag.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tedarikciler", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bag.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("insert into tedarikciler(firma_isim,adres,telefon,email) values (@firma_isim,@adres,@telefon,@email)");
            komut.Connection = bag;
            komut.Parameters.AddWithValue("@firma_isim", textBox1.Text);
            komut.Parameters.AddWithValue("@adres", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.Parameters.AddWithValue("@email", textBox4.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            tedarikgetir();
        }

       
    }
}
