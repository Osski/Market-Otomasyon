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
namespace marketotomasyon
{
    public partial class sifreunuttum : Form
    {
        SqlConnection bag = new SqlConnection("Server = DESKTOP-26GRNM0\\SQLEXPRESS; initial catalog = marketbarkod;integrated security = true;");
        public sifreunuttum()
        {
            InitializeComponent();
        }
        string sifre;
        string ID;
        private void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText = "SELECT kullanici_id,sifre FROM kullanici WHERE Email='" + mail + "'";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {

                ID = dr["kullanici_id"].ToString();
                sifre = dr["sifre"].ToString();
                label1.Text = ID;
                label2.Text = sifre;
            }
            //veritabınındakı kullanıcı tablosundan girilen emaile göre sifre ve kullanıcı adı getiriyor bunları da labela aktarıyor.
        }
    }
}
