using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneYonetim
{
    public partial class FormYeniUyeKayıt : Form
    {
        public FormYeniUyeKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Db_Kutuphane;Integrated Security=True;Trust Server Certificate=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi=textBox1.Text;
            Boolean isOk = true;
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select KullaniciAdi FROM TableKullanicilar", baglanti);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if(reader[0].ToString()==kullaniciAdi)
                    {
                        MessageBox.Show("Seçtiğiniz kullanıcı adı daha önce alınmıştır.Lütfen yeni bir kullanici adı deneyiniz!");
                        isOk = false;
                    }
                }
                reader.Close();
                if (isOk) {
                    if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("Girilen şifreler eşleşmemektedir!");
                        isOk = false;
                    }
                    else
                    {
                        try
                        {
                            SqlCommand sqlcommand = new SqlCommand("INSERT INTO TableKullanicilar " +
                                "(KullaniciAdi,Sifre) VALUES (@p1,@p2)", baglanti);

                            sqlcommand.Parameters.AddWithValue("@p1", textBox1.Text);
                            sqlcommand.Parameters.AddWithValue("@p2", textBox2.Text);

                            sqlcommand.ExecuteNonQuery();
                            MessageBox.Show("Kütüphane kullanıcı kaydınız başarıyla oluşturulmuştur!");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}
