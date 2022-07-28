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
    public partial class Müşteriler : Form
    {

        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");
        DataSet Daset = new DataSet();

        public Müşteriler()
        {
            InitializeComponent();
        }




        private void MüşteriListele()
        {
            bag.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select isim,soyisim,adres,telefon,email,tc_no from musteriler;", bag);
            da.Fill(Daset, "musteriler");
            dataGridView1.DataSource = Daset.Tables["musteriler"];
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bag.Close();
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            MüşteriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("insert into musteriler(isim,soyisim,adres,telefon,email,tc_no) values (@isim,@soyisim,@adres,@telefon,@email,@tc_no)");
            komut.Connection = bag;
            komut.Parameters.AddWithValue("@isim", textBox2.Text);
            komut.Parameters.AddWithValue("@soyisim", textBox3.Text);
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.Parameters.AddWithValue("@telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@email", textBox6.Text);
            komut.Parameters.AddWithValue("@tc_no", textBox7.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri kaydı eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MüşteriListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells["isim"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["soyisim"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString();
        }
    
    }
}
