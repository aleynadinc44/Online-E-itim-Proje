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

namespace proje1bilmemkaç
{
    public partial class egitmenkyt: Form
    {
        public egitmenkyt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        SQLBaglantim bgl = new SQLBaglantim();
        public class Baglanti
        {
            public SqlConnection baglanti()
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6Q32OA4J\SQLEXPRESS;Initial Catalog=onlineegitimsistemi;Integrated Security=True");
                return conn;
            }
        }

        private void KayitOlBt_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6Q32OA4J\SQLEXPRESS;Initial Catalog=onlineegitimsistemi;Integrated Security=True"))
                {
                    conn.Open();

                    DateTime dogumTarihi;
                    if (!DateTime.TryParse(txtDogumTarihi.Text, out dogumTarihi))
                    {
                        MessageBox.Show("Geçerli bir tarih formatı girin (örn: 01.01.2000)");
                        return;
                    }

                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO OgretmenKayit (EgitmenAdı, Soyadı, TCNo, DogumTarihi, Branş, CepTelefonu, Adres,Sifre) " +
                    "VALUES (@Ad, @Soyad, @TCNo, @DogumTarihi, @Brans, @CepTelefonu, @Adres, @Sifre)";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@TCNo", txtTCNo.Text);
                    komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(txtDogumTarihi.Text));
                    komut.Parameters.AddWithValue("@Brans", brasnstxt.Text);
                    komut.Parameters.AddWithValue("@CepTelefonu", txtCepTelefonu.Text);
                    komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                    komut.Parameters.AddWithValue("@Sifre", Sifretxt.Text);

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla tamamlandı!", "Başarılı");
                        
                        long tcNo = Convert.ToInt64(txtTCNo.Text);  // long yerine Int64 de yazılabilir
                        egtekran form4 = new egtekran(tcNo);         // constructor da long olmalı
                        form4.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Hiçbir satır eklenmedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iptalbt_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void İptalbt_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
