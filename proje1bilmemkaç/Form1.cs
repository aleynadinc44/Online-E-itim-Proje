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


namespace proje1bilmemkaç
{
    public partial class Form1 : Form
    {
        SQLBaglantim bgl = new SQLBaglantim();

        private void Listeleme()
        {
            //eğer bağlantı kapalıysa aç
            if (bgl.baglanti().State == ConnectionState.Closed)
                bgl.baglanti().Open();
            // sql server işleri için kullanılan komutlar
            SqlCommand list = new SqlCommand("SELECT * FROM dbo.ogrencigiris", bgl.baglanti());




            SqlDataAdapter sda = new SqlDataAdapter(list);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bgl.baglanti().Close();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KayitBt_Click(object sender, EventArgs e)
        {
            kayitol form2 = new kayitol(); // Form2'den bir nesne oluştur
            form2.Show();                                // Form2'yi aç
            this.Hide();                                  // İsteğe bağlı: Form1'i gizle
        }

        private void kayıtogrt_Click(object sender, EventArgs e)
        {
            egitmenkyt form5 = new egitmenkyt(); // Form2'den bir nesne oluştur
            form5.Show();                                // Form2'yi aç
            this.Hide();
        }
        private void Ogrencigiris_Click(object sender, EventArgs e)
        {
            if (bgl.baglanti().State == ConnectionState.Closed)
                bgl.baglanti().Open();


            string sorgu = "SELECT COUNT(*) FROM OgrenciKayit WHERE TCNo = @TCNo AND Sifre = @Sifre";  // TCNo kullanıcı adı olarak alındı

            SqlCommand kontrol = new SqlCommand(sorgu, bgl.baglanti());
            kontrol.Parameters.AddWithValue("@TCNo", txtTCNo.Text);
            kontrol.Parameters.AddWithValue("@Sifre", sifreText.Text);

            int sonuc = (int)kontrol.ExecuteScalar();

            if (sonuc > 0)

            {
                kontrol.Parameters.AddWithValue("@TCNo", txtTCNo.Text);  // TCNo'yu alıyoruz
                kontrol.Parameters.AddWithValue("@Sifre", sifreText.Text); // Şifreyi ekliyoruz


                long tcNo = Convert.ToInt64(txtTCNo.Text);  // long yerine Int64 de yazılabilir
                ogrenciekr form3 = new ogrenciekr(tcNo);         // constructor da long olmalı
                form3.Show();
                this.Hide();               // Form1'i gizler
            }
            else
            {
                MessageBox.Show("Öğrenci Kullanıcı adı veya şifre yanlış!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.baglanti().Close(); // Bağlantıyı kapat
        }

       

        private void ogretmengiris_Click(object sender, EventArgs e)
        {
            if (bgl.baglanti().State == ConnectionState.Closed)
                bgl.baglanti().Open();


            string sorgu = "SELECT COUNT(*) FROM OgretmenKayit WHERE TCNo = @TCNo AND Sifre = @Sifre";  // TCNo yu kullanıcı adı olarak kullanmak için

            SqlCommand kontrol = new SqlCommand(sorgu, bgl.baglanti());
            kontrol.Parameters.AddWithValue("@TCNo", egimentc.Text);
            kontrol.Parameters.AddWithValue("@Sifre", egitmensifre.Text);

            int sonuc = (int)kontrol.ExecuteScalar();

            if (sonuc > 0)

            {
                kontrol.Parameters.AddWithValue("@TCNo", egimentc.Text);  // TCNo'yu alıyoruz
                kontrol.Parameters.AddWithValue("@Sifre", egitmensifre.Text); // Şifreyi ekliyoruz

                long tcNo = Convert.ToInt64(egimentc.Text);  // long yerine Int64 de yazılabilir
                egtekran form4 = new egtekran(tcNo);         // constructor da long olmalı
                form4.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Öğrenci Kullanıcı adı veya şifre yanlış!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();
        }
    }
}


