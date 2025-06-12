using System.Data;
using System.Data.SqlClient;

namespace Stoktakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=NUR\\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr= new SqlDataAdapter("select *from sepet ",baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource=daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[1].Visible=false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüþteriListele listele = new frmMüþteriListele();
            listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüþteriEkle ekle= new frmMüþteriEkle();
            ekle.ShowDialog();
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                label9.Text = komut.ExecuteScalar() + " TL ";
                baglanti.Close();

            }
            catch(Exception)
            {
                ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele= new frmÜrünListele();
            listele.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori= new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka= new frmMarka();
            marka.ShowDialog(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtTc1.Text=="")
            {
                txtAdSoyad1.Text = "";
                txtTelefon1.Text = "";
            }

            baglanti.Open();
            SqlCommand komut= new SqlCommand("select *from müþteri where tc like '"+txtTc1.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtAdSoyad1.Text = read["adsoyad"].ToString();
                txtTelefon1.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            Temzile();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + txtBarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdý.Text = read["urunadi"].ToString();
                txtSatýþFiyatý.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void Temzile()
        {
            if (txtBarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
            SqlDataReader read= komut.ExecuteReader();
            while(read.Read())
            {
                if (txtBarkod.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc1.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad1.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon1.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdý.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatýþFiyatý.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktari=miktari+'"+int.Parse(txtMiktari.Text)+ "' where barkodno='"+txtBarkod.Text+"'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati=miktari*satisfiyati where barkodno='"+txtBarkod.Text+"'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
           
            txtMiktari.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatýþFiyatý.Text)).ToString();
            }
            catch(Exception)
            {
                ;
            }
        }

        private void txtSatýþFiyatý_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatýþFiyatý.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() +"' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Ürün Sepetten Kaldýrýldý");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatýþÝptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Ürünler Sepetten Kaldýrýldý");
            daset.Tables["sepet"].Clear();

            sepetlistele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmSatýþListele listele = new FrmSatýþListele();
            listele.ShowDialog();
        }

        private void btnSatýþYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc1.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad1.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon1.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close(); 
               
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satýþ Yapýldý");


            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }
    }
}