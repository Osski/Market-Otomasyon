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
    public partial class uyeol : Form
    {
        SqlConnection bag = new SqlConnection("Server = DESKTOP-26GRNM0\\SQLEXPRESS; initial catalog = marketbarkod;integrated security = true;");
        public uyeol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (textBox1.Text == String.Empty)
                hata = 1;

            if (textBox2.Text == String.Empty)
                hata = 1;

            if (textBox3.Text == String.Empty)
                hata = 1;
            // textboxların texti eğer boş sa messagebox dan hata karsımıza cıkıyor
            if (hata == 1)
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                bag.Open();
                SqlCommand komut = new SqlCommand("insert into kullanici(kullanici_id,sifre,Email) values (@kullanici_id,@sifre,@Email)");
                komut.Connection = bag;
                komut.Parameters.AddWithValue("@kullanici_id", textBox1.Text);
                komut.Parameters.AddWithValue("@sifre", textBox2.Text);
                komut.Parameters.AddWithValue("@Email", textBox3.Text);
                komut.ExecuteNonQuery();
                bag.Close();
                //textboxların değeri dolu ise girilen değerleri veritabanına kaydediyor.
                MessageBox.Show("Kullanıcı Eklendi");
            }
        }
    }
}
