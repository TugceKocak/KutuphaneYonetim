using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneYonetim
{
    public partial class FormYonetici : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Db_Kutuphane;Integrated Security=True;Trust Server Certificate=True");

        public FormYonetici()
        {
            InitializeComponent();
            kitaplariGoster();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlcommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi=@p1, YazarAdi=@p2, ISBN=@p3, KitapTurKodu=@p4 WHERE ID=@p5", baglanti);

                sqlcommand.Parameters.AddWithValue("@p1", textBox2.Text);
                sqlcommand.Parameters.AddWithValue("@p2", textBox3.Text);
                sqlcommand.Parameters.AddWithValue("@p3", textBox4.Text);
                sqlcommand.Parameters.AddWithValue("@p4", textBox5.Text);
                sqlcommand.Parameters.AddWithValue("@p5", label9.Text);

                sqlcommand.ExecuteNonQuery();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlcommand = new SqlCommand("INSERT INTO TableKitaplar " +
                    "(KitapAdi,YazarAdi, ISBN, Durum, KitapTurKodu) VALUES (@p1,@p2,@p3,@p4,@p5)", baglanti);

                sqlcommand.Parameters.AddWithValue("@p1", textBox2.Text);
                sqlcommand.Parameters.AddWithValue("@p2", textBox3.Text);
                sqlcommand.Parameters.AddWithValue("@p3", textBox4.Text);
                sqlcommand.Parameters.AddWithValue("@p4", "True");
                sqlcommand.Parameters.AddWithValue("@p5", textBox5.Text);

                sqlcommand.ExecuteNonQuery();
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
            else
            {
                MessageBox.Show("Lütfen sorgulamak istediğiniz alanı seçiniz!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlcommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID=@p1", baglanti);
                sqlcommand.Parameters.AddWithValue("@p1", label9.Text);
                sqlcommand.ExecuteNonQuery();
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            label9.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilenSatir].Cells[7].Value.ToString();


        }

        private void FormYonetici_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kitaplariGoster();
        }
    }
}
