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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje1bilmemkaç
{
    public partial class egtekran : Form
    {

        private string connectionString = "Server=LAPTOP-6Q32OA4J\\SQLEXPRESS;Database=onlineegitimsistemi;Integrated Security=True;";
        private long mevcutTCNo;

        public egtekran(long tcNo)
        {
            InitializeComponent();
            mevcutTCNo = tcNo;
        }
        private void egtekran_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.videoekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.videoekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.videoekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.dosyaekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dosyaekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.dosyaekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.egitmen_dersprogrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.egitmen_dersprogramiTableAdapter.Fill(this.onlineegitimsistemiDataSet.egitmen_dersprogrami);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.egitmen_dersprogrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.egitmen_dersprogramiTableAdapter.Fill(this.onlineegitimsistemiDataSet.egitmen_dersprogrami);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.videoekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.videoekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.videoekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.dosyaekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dosyaekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.dosyaekle);
            onlineegitimsistemiDataSet.EnforceConstraints = false; // 🛑 Kısıtlamaları geçici devre dışı bırak
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.egitmen_dersprogrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.egitmen_dersprogramiTableAdapter.Fill(this.onlineegitimsistemiDataSet.egitmen_dersprogrami);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.videoekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.videoekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.videoekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.dosyaekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dosyaekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.dosyaekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet1.videoekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.videoekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.videoekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet1.dosyaekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dosyaekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.dosyaekle);
            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.egitmen_dersprogrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.egitmen_dersprogramiTableAdapter.Fill(this.onlineegitimsistemiDataSet.egitmen_dersprogrami);
            EgitmenBilgileriniYukle();

            // TODO: Bu kod satırı 'onlineegitimsistemiDataSet.egitmen_dersprogrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.egitmen_dersprogramiTableAdapter.Fill(this.onlineegitimsistemiDataSet.egitmen_dersprogrami);

          
        }

        private void EgitmenBilgileriniYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Belirli bir eğitmenin bilgilerini ÇEKMEK için SQL sorgusu
                    string sorgu = "SELECT EgitmenID, EgitmenAdı, Soyadı, Branş FROM OgretmenKayit WHERE TcNo = @TcNo";

                    using (SqlCommand command = new SqlCommand(sorgu, conn))
                    {
                        // Parametreye mevcut eğitmen ID'sini atıyoruz
                        command.Parameters.AddWithValue("@TcNo", mevcutTCNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Eğer bir kayıt bulunduysa
                            {
                                // Veritabanından okunan değerleri form üzerindeki kontrollere aktar
                                EgitmenIDtxt.Text = reader["EgitmenID"].ToString();
                                EgitmenAdiSoyadi.Text = $"{reader["EgitmenAdı"]} {reader["Soyadı"]}";

                                // ComboBox'ın Items koleksiyonunda bu branşın olup olmadığını kontrol etmeli ve seçmelisiniz.
                                Branstxt.Text = reader["Branş"].ToString();

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

        private void DosyaEklebt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string sorgu = "INSERT INTO dosyaekle ([Dosya'nın konusu], [Dosya türü],[Dosya Kodu]) " +
                    "VALUES (@Dosyakonu, @Dosyaturu, @Dosyakodu)";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@Dosyakonu",dosyakonutxt.Text);
                    komut.Parameters.AddWithValue("@Dosyaturu", dosyaturucombobox.Text);
                    komut.Parameters.AddWithValue("@Dosyakodu", dosyakodutxt.Text);

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Dosya Başarı ile eklendi!", "Başarılı");
                        //  Tabloyu yenile
                        this.dosyaekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.dosyaekle);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Hiçbir satır eklenmedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void videoeklebt_Click(object sender, EventArgs e)
        {
             
        
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string sorgu = "INSERT INTO videoekle ([Video'nun konusu], [Video Kalitesi],[Video Kodu]) " +
                    "VALUES (@videokonu, @videokalite, @videokodu)";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@videokonu", videokonu.Text);
                    komut.Parameters.AddWithValue("@videokalite", kalitecomboBox.Text);
                    komut.Parameters.AddWithValue("@videokodu", videokodu.Text);

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Video Başarı ile eklendi!", "Başarılı");
                        //  Tabloyu yenile
                        this.videoekleTableAdapter.Fill(this.onlineegitimsistemiDataSet.videoekle);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Hiçbir satır eklenmedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void dosyasilbt_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki Dosya Kodu'nu almaya yarar
                string dosyaKodu = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();


                // Kullanıcıya emin misin sorusu sorar
                DialogResult result = MessageBox.Show("Bu dosyayı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sorgu = "DELETE FROM dosyaekle WHERE [Dosya Kodu] = @DosyaKodu";
                        SqlCommand cmd = new SqlCommand(sorgu, conn);
                        cmd.Parameters.AddWithValue("@DosyaKodu", dosyaKodu);
                        int silinen = cmd.ExecuteNonQuery();
                        if (silinen > 0)
                        {
                            MessageBox.Show("Dosya başarıyla silindi.");
                            dosyaekleTableAdapter.Fill(onlineegitimsistemiDataSet.dosyaekle); // tabloyu yenile
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void videosilbt_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki Dosya Kodu'nu almaya yarar
                string videokodu = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();


                // Kullanıcıya emin misin sorusu sorar
                DialogResult result = MessageBox.Show("Bu videoyu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sorgu = "DELETE FROM videoekle WHERE [Video Kodu] = @videokodu";
                        SqlCommand cmd = new SqlCommand(sorgu, conn);
                        cmd.Parameters.AddWithValue("@videokodu", videokodu);
                        int silinen = cmd.ExecuteNonQuery();
                        if (silinen > 0)
                        {
                            MessageBox.Show("Video başarıyla silindi.");
                            videoekleTableAdapter.Fill(onlineegitimsistemiDataSet.videoekle); // tabloyu yenile
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void cıkısbt_Click(object sender, EventArgs e)
        {

            Form form1 = new Form1();
            form1.Show();
            this.Hide(); ;
        }

        private void dosyaturucombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}      
  
