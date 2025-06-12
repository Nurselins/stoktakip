using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoktakip
{
    public partial class FrmSatışListele : Form
    {
        public FrmSatışListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=NUR\\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis ", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }
        private void FrmSatışListele_Load(object sender, EventArgs e)
        {
            satışlistele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
