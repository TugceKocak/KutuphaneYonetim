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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneYonetim
{
    public partial class FormKullanici : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Db_Kutuphane;Integrated Security=True;Trust Server Certificate=True");
        string kullaniciadi = "";
        public FormKullanici(string kullanici)
        {
            InitializeComponent();
            kitaplariGoster();
            kullaniciadi = kullanici;
            oduncKitaplariGoster();
            groupBox2.Visible = false;
        }
        private void kitaplariGoster()
        {
            string q = "SELECT * FROM TableKitaplar";
            SqlDataAdapter adapter = new SqlDataAdapter(q, baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {

                string comboselected = (string)comboBox1.SelectedItem;
                switch (comboselected)
                {
                    case "Kitap Adı":
                        comboselected = "KitapAdi";
                        break;
                    case "Yazar Adı":
                        comboselected = "YazarAdi";
                        break;
                    case "Kitap Türü":
                        comboselected = "KitapTurKodu";
                        break;
                }
                string q = "SELECT * FROM TableKitaplar WHERE " + comboselected + " LIKE '" + textBox1.Text + "%'";
                try
                {
                    baglanti.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(q, baglanti);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();

                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                string oduncKitaplar = "";
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select OduncKitaplar FROM TableKullanicilar WHERE KullaniciAdi=@pr1", baglanti);
                cmd.Parameters.AddWithValue("@pr1", kullaniciadi);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oduncKitaplar = reader[0].ToString();
                }
                reader.Close();
                string[] oduncKitaplarID = oduncKitaplar.Split(',');
                if (oduncKitaplarID.Length == 5)
                {
                    MessageBox.Show("5 adetten fazla ödünç kitap alamazsınız!");
                    return;
                }
                int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
                string secilenKitapId = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
                oduncKitaplar = oduncKitaplar + secilenKitapId +",";
                
                SqlCommand sqlcommand = new SqlCommand("UPDATE TableKitaplar SET Durum=@p1, OduncAlanKullanici=@p2, OduncAlmaTarihi=@p3 WHERE ID=@p4", baglanti);

                sqlcommand.Parameters.AddWithValue("@p1", "False");
                sqlcommand.Parameters.AddWithValue("@p2", kullaniciadi);
                sqlcommand.Parameters.AddWithValue("@p3", DateTime.Now.Date);
                sqlcommand.Parameters.AddWithValue("@p4", secilenKitapId);
                sqlcommand.ExecuteNonQuery();

                SqlCommand sqlcommand2 = new SqlCommand("UPDATE TableKullanicilar SET OduncKitaplar=@p1 WHERE KullaniciAdi=@p2", baglanti);

                sqlcommand2.Parameters.AddWithValue("@p1", oduncKitaplar);
                sqlcommand2.Parameters.AddWithValue("@p2", kullaniciadi);
                sqlcommand2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
            kitaplariGoster();
            oduncKitaplariGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilenSatir = dataGridView2.SelectedCells[0].RowIndex;
            string secilenKitapId = dataGridView2.Rows[secilenSatir].Cells[0].Value.ToString();
            try
            {
                string oduncKitaplar = "";
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select OduncKitaplar FROM TableKullanicilar WHERE KullaniciAdi=@pr1", baglanti);
                cmd.Parameters.AddWithValue("@pr1", kullaniciadi);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oduncKitaplar = reader[0].ToString();
                }
                reader.Close();

                ArrayList oduncKitaplarID = new ArrayList();
                foreach(string kitapId in oduncKitaplar.Split(','))
                {
                    oduncKitaplarID.Add(kitapId);
                }
                oduncKitaplarID.Remove(secilenKitapId);
                oduncKitaplar = "";
                foreach(string kitapid in oduncKitaplarID)
                {
                    oduncKitaplar += kitapid + ",";
                }
                SqlCommand sqlcommand = new SqlCommand("UPDATE TableKitaplar SET Durum=@p1, OduncAlanKullanici=@p2, OduncAlmaTarihi=@p3 WHERE ID=@p4", baglanti);

                sqlcommand.Parameters.AddWithValue("@p1", "True");
                sqlcommand.Parameters.AddWithValue("@p2", "");
                sqlcommand.Parameters.AddWithValue("@p3", "");
                sqlcommand.Parameters.AddWithValue("@p4", secilenKitapId);
                sqlcommand.ExecuteNonQuery();

                SqlCommand sqlcommand2 = new SqlCommand("UPDATE TableKullanicilar SET OduncKitaplar=@p1 WHERE KullaniciAdi=@p2", baglanti);

                sqlcommand2.Parameters.AddWithValue("@p1", oduncKitaplar);
                sqlcommand2.Parameters.AddWithValue("@p2", kullaniciadi);
                sqlcommand2.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
            oduncKitaplariGoster();
            kitaplariGoster();
        }
        private void oduncKitaplariGoster()
        {
            try
            {
                string oduncKitaplar = "";
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select OduncKitaplar FROM TableKullanicilar WHERE KullaniciAdi=@pr1", baglanti);
                cmd.Parameters.AddWithValue("@pr1", kullaniciadi);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oduncKitaplar = reader[0].ToString();
                }
                reader.Close();
                
                string[] oduncKitaplarID = oduncKitaplar.Split(',');

                
                string q_devam ="";
                for (int i = 0; i < oduncKitaplarID.Length; i++)
                {
                    q_devam = q_devam +"'"+ oduncKitaplarID[i]+"',";

                }
                q_devam=q_devam.Remove(q_devam.Length - 4);
                string q = "SELECT * FROM TableKitaplar WHERE ID IN ("+ q_devam + ")";
                
                SqlDataAdapter adapter = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    dataGridView2.DataSource = dt;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
        }
       
    }
}
