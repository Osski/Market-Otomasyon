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
    public partial class detayform : Form
    {

        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");
        DataSet daset = new DataSet();
        public detayform()
        {
            InitializeComponent();
        }
        
        private void detayform_Load(object sender, EventArgs e)
        {
            
           
            DataTable dt = new DataTable();
            string sql = "select m.musteri_id,u.urun_adi,d.miktari,d.satisfiyati,d.toplamfiyati,s.tarih,d.detaysatis_id from detaysatis d,urunler u,musteriler m,satis s where(d.musteri_id=m.musteri_id)and (d.urun_id=u.urun_id)and (d.sepet_id=s.satis_id)and s.musteri_id='" + Satışsalrapor.anne + "'";
           SQLiteDataAdapter da = new SQLiteDataAdapter(sql, bag);
            bag.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "MUSTERİ ID";
            dataGridView1.Columns[1].HeaderText = "ÜRÜN ADI";
            dataGridView1.Columns[2].HeaderText = "MİKTARI";
            dataGridView1.Columns[3].HeaderText = "SATIŞ FİYATI";
            dataGridView1.Columns[4].HeaderText = "TOPLAM FİYATI";
            dataGridView1.Columns[5].HeaderText = "TARİH";
            dataGridView1.Columns[6].HeaderText = "DETAY SATIŞ NUMARASI";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bag.Close();
            

        }
    }
}
