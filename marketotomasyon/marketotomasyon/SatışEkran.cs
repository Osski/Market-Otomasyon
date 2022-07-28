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
using System.Data.OleDb;
using System.Data.SQLite;

namespace marketotomasyon
{
    public partial class SatışEkran : Form
    {
        public SatışEkran()
        {
            InitializeComponent();
        }
        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");

        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            bag.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select s.barkodno,u.urun_adi,u.urun_id,s.miktari,s.satisfiyati,s.toplamfiyati,s.toplamsepetmiktari from sepet s,urunler u where (u.urun_id=s.urun_id)", bag);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bag.Close();
            //sepet tablosunu datagride aktarıyor ve başlıklarını değiştiriyor
        }

        private void hesapla()
        {
            try
            {
                bag.Open();
                SQLiteCommand komut = new SQLiteCommand("select sum(toplamfiyati) from sepet", bag);
                textBoxgeneltoplam.Text = komut.ExecuteScalar() + "";
                bag.Close();


            }
            catch (Exception)
            {

                ;
            }
            // sepete girilen ürnlerin fiyatlarını topluyor ve bunları textboxa yazdırıyor

        }
        private void SatışEkran_Load(object sender, EventArgs e)
        {
            sepetlistele();
            cmbxgetir();
            cmbxmusterigetir();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("select * from urunler where barkodno like '" + textBox1.Text + "'", bag);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox7.Text = read["urun_adi"].ToString();
                textBox3.Text = read["urun_id"].ToString();
                textBox5.Text = read["fiyat"].ToString();
            }
            bag.Close();//barkod girilen textboxın texti değişirse yeni gelicek barkodun tekabül ettiği bilgileri textboxlara yazdırıyor
        }

        private void Temizle()
        {
            if (textBox1.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {

                        if (item != textBox4)

                        {

                            item.Text = "";

                        }
                    }
                }
            }
        }
        bool durum;
        //tüm textboxları temizliyor.
        private void barkodcontrol()
        {
            durum = true;
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("select * from sepet", bag);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            bag.Close();
            //textboxın içindeki sayı barkod değerine eşitsse durum değerini false yapıyor.

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                barkodcontrol();
                if (durum == true)
                {
                    try
                    {
                        bag.Open();
                        SQLiteCommand komut = new SQLiteCommand("insert into sepet (barkodno,urun_id,miktari,satisfiyati,toplamfiyati,tarih) values(@barkodno,@urun_id,@miktari,@satisfiyati,@toplamfiyati,@tarih)", bag);
                        komut.Parameters.AddWithValue("@barkodno", textBox1.Text);
                        komut.Parameters.AddWithValue("@urun_id",Convert.ToInt32( textBox3.Text));
                        komut.Parameters.AddWithValue("@miktari", int.Parse(textBox4.Text));
                        komut.Parameters.AddWithValue("@satisfiyati", double.Parse(textBox5.Text));
                        komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(textBox6.Text));
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());


                        komut.ExecuteNonQuery();
                        bag.Close();
                    }
                    catch (Exception)
                    {
                        DialogResult dialogResult1 = MessageBox.Show("Ürün Veritabanında Bulunamadı. Yeni bir ürün eklemek istermisiniz", "Uyarı", MessageBoxButtons.YesNo);
                        if (dialogResult1 == DialogResult.Yes)
                        {
                            ÜrünEkle ürünEkle = new ÜrünEkle();
                            ürünEkle.Show();
                        }
                        bag.Close();
                    }

                }
                //eğer klavyede enter tuşuna basılırsa barkodcontrol calısıyor barkodcontrolden gelen durum verisi eğer true ise ekrandakı verileri sepete giriyor eğer o barkodda bir ürün yoksa yeni ürün eklemek istermisiniz diye soruyor.
                else
                {
                    bag.Open();
                    SQLiteCommand komut2 = new SQLiteCommand("update sepet set miktari=miktari+'" + int.Parse(textBox4.Text) + "'where barkodno='" + textBox1.Text + "'", bag);
                    komut2.ExecuteNonQuery();
                    SQLiteCommand komut3 = new SQLiteCommand("update sepet set toplamfiyati=miktari*satisfiyati where barkodno='" + textBox1.Text + "'", bag);
                    //toplam fiyatı veritabanına aktarma
                    komut3.ExecuteNonQuery();
                    bag.Close();
                }


                daset.Tables["sepet"].Clear();
                sepetlistele();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {

                        if (item != textBox4)

                        {

                            item.Text = "";
                            //textboxları boşaltma

                        }
                    }
                }
                hesapla();
            }
        }//ürün eklendikten sonra sepet tablosu temizleniyor ve hesapla voidi tekrar çalışıyor.

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (double.Parse(textBox4.Text) * double.Parse(textBox5.Text)).ToString();
                //değer değişirse tekrardan ürünlerin toplam fiyatını yazdırma
            }
            catch (Exception)
            {

                ;
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (double.Parse(textBox4.Text) * double.Parse(textBox5.Text)).ToString();
                //değer değişirse tekrardan ürünlerin toplam fiyatını yazdırma
            }
            catch (Exception)
            {

                ;
            }
        }

        private void SatışEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("delete from sepet", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            //satış ekranı kapandıgında sepetteki ürünlri silme kodu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //pencere kapatma
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            //ürünü sepetten çıkartma kodu

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("delete from sepet ", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("SATIŞ İPTAL EDİLDİ");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            //satış iptal etme kodu
        }
        int nakit;
        private void button4_Click(object sender, EventArgs e)
        {
            nakit = 1;
            float a = float.Parse(textBoxgeneltoplam.Text);

            bag.Open();
            SQLiteCommand komut = new SQLiteCommand("insert into satis (tarih,musteri_id,calisan_id,toplamsepetmiktari,odeme) values(@tarih,@musteri_id,@calisan_id,@toplamsepetmiktari,@odeme)", bag);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now);
            komut.Parameters.AddWithValue("@musteri_id",comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@calisan_id",comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@toplamsepetmiktari", a);
            komut.Parameters.AddWithValue("@odeme", Convert.ToString(nakit));
            komut.ExecuteNonQuery();
            bag.Close();
            detaygir();

            bag.Open();
            SQLiteCommand komut2 = new SQLiteCommand("delete from sepet ", bag);
            komut2.ExecuteNonQuery();
            bag.Close();
            
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            // nakit bilgileri satis tablosuna kaydediyor

        }
        private void cmbxgetir()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from calisanlar", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "isim";
            comboBox2.ValueMember = "calisan_id";
            bag.Close();
            
            //comboboxları dolduruyor
        }
        private void cmbxmusterigetir()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from musteriler", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "tc_no";
            comboBox1.ValueMember = "musteri_id";

            bag.Close();
            //comboboxları dolduruyor
        }  
        private void detaygir()
        {
            for (int q = 0; q < dataGridView1.Rows.Count -1; q++)
            {

                bag.Open();
                SQLiteCommand komut5 = new SQLiteCommand("insert into detaysatis (urun_id,miktari,satisfiyati,toplamfiyati,tarih,musteri_id) values(@urun_id,@miktari,@satisfiyati,@toplamfiyati,@tarih,@musteri_id)", bag);
                komut5.Parameters.AddWithValue("@urun_id",dataGridView1.Rows[q].Cells["urun_id"].Value.ToString());
                komut5.Parameters.AddWithValue("@miktari",dataGridView1.Rows[q].Cells["miktari"].Value.ToString());
                komut5.Parameters.AddWithValue("@satisfiyati",dataGridView1.Rows[q].Cells["satisfiyati"].Value.ToString());
                komut5.Parameters.AddWithValue("@toplamfiyati",dataGridView1.Rows[q].Cells["toplamfiyati"].Value.ToString());
                komut5.Parameters.AddWithValue("@tarih",DateTime.Now);
                komut5.Parameters.AddWithValue("@musteri_id",comboBox1.SelectedValue);
                komut5.ExecuteNonQuery();
                bag.Close();
                //ürünleri ayrı ayrı musterilere detay satıs tablosuna kaydediyor.
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
