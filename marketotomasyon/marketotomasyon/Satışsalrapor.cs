using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketotomasyon
{
    public partial class Satışsalrapor : Form
    {
        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");

        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet Daset = new DataSet();
        public Satışsalrapor()
        {
            InitializeComponent();
           
        }
        
       
        private void Satışsalrapor_Load(object sender, EventArgs e)
        {
            bag.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select s.tarih,c.isim,m.musteri_id,m.tc_no,m.isim,s.odeme,s.toplamsepetmiktari,s.satis_id from satis s,musteriler m,calisanlar c where (s.musteri_id=m.musteri_id)and(s.calisan_id=c.calisan_id) order by tarih desc", bag);
            da.Fill(Daset, "satis");
            dataGridView1.DataSource = Daset.Tables["satis"];
            //dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].HeaderText = "TARİH";
            dataGridView1.Columns[1].HeaderText = "ÇALIŞAN İSİM";
            dataGridView1.Columns[2].HeaderText = "MUSTERİ ID";
            dataGridView1.Columns[3].HeaderText = "MUSTERİ TC";
            dataGridView1.Columns[4].HeaderText = "MUSTERİ İSİM";
            dataGridView1.Columns[5].HeaderText = "ODEME";
            dataGridView1.Columns[6].HeaderText = "TOPLAM FİYAT";
            dataGridView1.Columns[7].HeaderText = "SATIŞ NUMARASI";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bag.Close();
            geneltplm();

        }
        
        private void geneltplm()
        {
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("select sum(toplamsepetmiktari) from satis",bag);
            string deger = komut.ExecuteScalar().ToString();
            bag.Close();
            geneltoplam.Text= deger;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            
            DataTable dt = new DataTable();
            string sql = "select s.tarih,c.isim,m.isim,m.musteri_id,s.odeme,s.toplamsepetmiktari,s.satis_id from satis s,musteriler m,calisanlar c where (s.musteri_id=m.musteri_id)and(s.calisan_id=c.calisan_id) and tarih between @tarih1 and @tarih2 order by tarih desc";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value);
            bag.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }
        
        public static string anne;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           anne= dataGridView1.Rows[0].Cells[2].Value.ToString();
            detayform dty = new detayform();
            dty.Show();
        }

       
    }
}
