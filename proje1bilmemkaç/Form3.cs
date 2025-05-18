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

namespace proje1bilmemkaç
{
    public partial class ogrenciekr : Form // Form sınıfının adını doğru yazdığınızdan emin olun
    {
        private string connectionString = "Server=LAPTOP-6Q32OA4J\\SQLEXPRESS;Database=onlineegitimsistemi;Integrated Security=True;";
        private long seciliOgrenciID; // Bu değeri uygulamanızdaki mantığa göre dinamik olarak almalısınız.

        public ogrenciekr (long tcNo)
        {
            InitializeComponent();
            seciliOgrenciID = tcNo;
        }

        private void ogrenciekr_Load(object sender, EventArgs e) // Form Load olay işleyicisinin adını kontrol edin
        {
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.videoekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.videoekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.videoekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.dosyaekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dosyaekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.dosyaekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.DersProgrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersProgramiTableAdapter.Fill(this.onlineegitimsistemiDataSet.DersProgrami);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.Notlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.notlarTableAdapter.Fill(this.onlineegitimsistemiDataSet.Notlar);

            OgrenciNotlariniYukle();
            DersPrograminiYukle();
            OgrenciBilgileriniYukle();
        }

        private void OgrenciNotlariniYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT n.DersID, d.Ders AS DersAdi, n.VizeNotu, n.FinalNotu, n.Ortalama " +
                                   "FROM dbo.Notlar n " +
                                   "INNER JOIN dbo.DersProgrami d ON n.DersID = d.DersID " +
                                   "WHERE n.OgrenciID = @OgrenciID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OgrenciID", seciliOgrenciID);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewOgrenciNotlari.DataSource = dt;

                        // Sadece gerekli sütunları göster ve başlıklarını düzenle
                        if (dataGridViewOgrenciNotlari.Columns.Contains("DersID"))
                            dataGridViewOgrenciNotlari.Columns["DersID"].HeaderText = "Ders ID";
                        if (dataGridViewOgrenciNotlari.Columns.Contains("DersAdi"))
                            dataGridViewOgrenciNotlari.Columns["DersAdi"].HeaderText = "Ders Adı";
                        if (dataGridViewOgrenciNotlari.Columns.Contains("VizeNotu"))
                            dataGridViewOgrenciNotlari.Columns["VizeNotu"].HeaderText = "Vize Notu";
                        if (dataGridViewOgrenciNotlari.Columns.Contains("FinalNotu"))
                            dataGridViewOgrenciNotlari.Columns["FinalNotu"].HeaderText = "Final Notu";
                        if (dataGridViewOgrenciNotlari.Columns.Contains("Ortalama"))
                            dataGridViewOgrenciNotlari.Columns["Ortalama"].HeaderText = "Ortalama";
                        if (dataGridViewOgrenciNotlari.Columns.Contains("OgrenciID")) // Eğer varsa gizle
                            dataGridViewOgrenciNotlari.Columns["OgrenciID"].Visible = false;

                        this.notlarTableAdapter.Fill(this.onlineegitimsistemiDataSet.Notlar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci notları yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void DersPrograminiYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DersID, Gün, Saat, Ders AS DersAdı, EgitmenAdı ,EgitmenID FROM dbo.DersProgrami"; // 'Ders' sütununu 'DersAdi' olarak aliasladım
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewDersProgrami.DataSource = dt;

                        // Sütun başlıklarını düzenle
                        if (dataGridViewDersProgrami.Columns.Contains("DersID"))
                            dataGridViewDersProgrami.Columns["DersID"].HeaderText = "Ders ID";
                        if (dataGridViewDersProgrami.Columns.Contains("Gün"))
                            dataGridViewDersProgrami.Columns["Gün"].HeaderText = "Gün";
                        if (dataGridViewDersProgrami.Columns.Contains("Saat"))
                            dataGridViewDersProgrami.Columns["Saat"].HeaderText = "Saat";
                        if (dataGridViewDersProgrami.Columns.Contains("DersAdi")) // Aliasladığımız ismi kullanıyoruz
                            dataGridViewDersProgrami.Columns["DersAdi"].HeaderText = "Ders Adı";
                        if (dataGridViewDersProgrami.Columns.Contains("EgitmenAdı"))
                            dataGridViewDersProgrami.Columns["EgitmenAdı"].HeaderText = "Eğitmen Adı";
                        if (dataGridViewDersProgrami.Columns.Contains("OgretmenID")) // Eğer varsa gizle
                            dataGridViewDersProgrami.Columns["EgitmenID"].Visible = false;
                        this.dersProgramiTableAdapter.Fill(this.onlineegitimsistemiDataSet.DersProgrami);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders programı yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void dataGridViewOgrenciNotlari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView üzerindeki bir hücreye tıklandığında yapılacak işlemler (gerekirse burayı doldurun)
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Panel çizildiğinde yapılacak işlemler (gerekirse burayı doldurun)
        }

        private void dosyaac_Click(object sender, EventArgs e)
        {
        
            if (dataGridViewdosya.SelectedRows.Count > 0)
            {
                string dosyaKodu = dataGridViewdosya.SelectedRows[0].Cells["DosyaKodu"].Value.ToString();

                // Dosya yolu oluştur (örnek: C:\Dosyalar\KODU.pdf)
                string dosyaYolu = Path.Combine("C:\\Dosyalar", dosyaKodu + ".pdf"); // uzantıya göre düzenle

                if (File.Exists(dosyaYolu))
                {
                    System.Diagnostics.Process.Start(dosyaYolu);
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı: " + dosyaYolu);
                }
            }
            else
            {
                MessageBox.Show("Lütfen açmak istediğiniz bir dosyayı seçin.");
            }
        }


         private void OgrenciBilgileriniYukle()
         {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                     //Belirli bir eğitmenin bilgilerini ÇEKMEK için SQL sorgusu
                    string sorgu = "SELECT OgrenciID, Adı, Soyadı, Sınıf ,Bölüm FROM OgrenciKayit WHERE TcNo = @TcNo";

                    using (SqlCommand command = new SqlCommand(sorgu, conn))
                    {
                       //  Parametreye mevcut eğitmen ID'sini atıyoruz
                        command.Parameters.AddWithValue("@TcNo", seciliOgrenciID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Eğer bir kayıt bulunduysa
                            {
                                // Veritabanından okunan değerleri form üzerindeki kontrollere aktar
                                ogrenciIDtxt.Text = reader["OgrenciID"].ToString();
                                OgrenciAdiSoyadi.Text = $"{reader["Adı"]} {reader["Soyadı"]}";
                                siniftxt.Text = reader["Sınıf"].ToString();
                                bolumtxt.Text = reader["Bölüm"].ToString();


                            }
                            else
                            {
                                MessageBox.Show("Belirtilen ID'ye sahip eğitmen bulunamadı.", "Bilgi");
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata");
            }
        }

        private void cıkısbt_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide(); ;
        }
    }
}