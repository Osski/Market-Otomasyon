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
using System.IO;
using System.Data.SQLite;


namespace marketotomasyon
{
    public partial class deneme : Form
    {
        
        
        public deneme()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection bag = new SQLiteConnection("Data Source=market.db;Version=3;");
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from kullanici",bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
