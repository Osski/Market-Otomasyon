using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace marketotomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");
        private void button1_Click(object sender, EventArgs e)
        {
            string adı = textBox1.Text;
            string şifre = textBox2.Text;
            bag.Open();
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = bag;
            komut.CommandText = "SELECT * FROM kullanici WHERE kullanici_id ='"+adı+ "' AND sifre ='" + şifre + "'";
            komut.ExecuteNonQuery();
            SQLiteDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Form1 form1 = new Form1();
                form1.Hide();

                anaekran anaekran = new anaekran();

                anaekran.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            
            bag.Close();
            
        }
        //btn1click olayı veritabanından kullanıcı adı şifre dogrulaması yapıyor

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeol uyeol = new uyeol();
            uyeol.ShowDialog();
            //uye olma ekranını açıyor

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sifreunuttum sifreekran = new sifreunuttum();
            sifreekran.Show();
            //şifremi unuttum ekranını açıyor
        }
    }
}
