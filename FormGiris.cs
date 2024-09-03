using Microsoft.Data.SqlClient;

namespace KutuphaneYonetim
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Db_Kutuphane;Integrated Security=True;Trust Server Certificate=True");
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select Sifre FROM TableKullanicilar WHERE KullaniciAdi=@pr1", baglanti);
                cmd.Parameters.AddWithValue("@pr1", textBox1.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                string kullaniciadi = textBox1.Text;
                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }
                if (sifre == textBox2.Text)
                {
                    label3.Text = "Giris basarýlý";
                    FormKullanici formKullanici= new FormKullanici(kullaniciadi);
                    formKullanici.Show();
                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý!");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYeniUyeKayýt formYeniUyeKayýt = new FormYeniUyeKayýt();
            formYeniUyeKayýt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi=@pr1", baglanti);
                cmd.Parameters.AddWithValue("@pr1", textBox1.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }
                if (sifre == textBox2.Text)
                {
                    FormYonetici formYonetici = new FormYonetici();
                    formYonetici.Show();
                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý!");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
    
}
