namespace proje1bilmemkaç
{
    partial class ogrenciekr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciekr));
            this.dataGridViewDersProgrami = new System.Windows.Forms.DataGridView();
            this.dersIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.günDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egitmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egitmenAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersProgramiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineegitimsistemiDataSet = new proje1bilmemkaç.onlineegitimsistemiDataSet();
            this.dataGridViewOgrenciNotlari = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizeNotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalNotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.sinif = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OgrenciAdiSoyadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ogrenciIDtxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cıkısbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bolumtxt = new System.Windows.Forms.TextBox();
            this.siniftxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.videoKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videonunKonusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoKalitesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoekleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewdosya = new System.Windows.Forms.DataGridView();
            this.dosyaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyanınKonusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyaTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyaekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notlarTableAdapter = new proje1bilmemkaç.onlineegitimsistemiDataSetTableAdapters.NotlarTableAdapter();
            this.dersProgramiTableAdapter = new proje1bilmemkaç.onlineegitimsistemiDataSetTableAdapters.DersProgramiTableAdapter();
            this.dosyaekleTableAdapter = new proje1bilmemkaç.onlineegitimsistemiDataSetTableAdapters.dosyaekleTableAdapter();
            this.videoekleTableAdapter = new proje1bilmemkaç.onlineegitimsistemiDataSetTableAdapters.videoekleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineegitimsistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciNotlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoekleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdosya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosyaekleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoekleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDersProgrami
            // 
            this.dataGridViewDersProgrami.AutoGenerateColumns = false;
            this.dataGridViewDersProgrami.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewDersProgrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersProgrami.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn1,
            this.günDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.dersDataGridViewTextBoxColumn,
            this.egitmenIDDataGridViewTextBoxColumn,
            this.egitmenAdıDataGridViewTextBoxColumn});
            this.dataGridViewDersProgrami.DataSource = this.dersProgramiBindingSource;
            this.dataGridViewDersProgrami.Location = new System.Drawing.Point(45, 276);
            this.dataGridViewDersProgrami.Name = "dataGridViewDersProgrami";
            this.dataGridViewDersProgrami.RowHeadersWidth = 51;
            this.dataGridViewDersProgrami.RowTemplate.Height = 24;
            this.dataGridViewDersProgrami.Size = new System.Drawing.Size(677, 236);
            this.dataGridViewDersProgrami.TabIndex = 0;
            // 
            // dersIDDataGridViewTextBoxColumn1
            // 
            this.dersIDDataGridViewTextBoxColumn1.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn1.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn1.Name = "dersIDDataGridViewTextBoxColumn1";
            this.dersIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dersIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // günDataGridViewTextBoxColumn
            // 
            this.günDataGridViewTextBoxColumn.DataPropertyName = "Gün";
            this.günDataGridViewTextBoxColumn.HeaderText = "Gün";
            this.günDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.günDataGridViewTextBoxColumn.Name = "günDataGridViewTextBoxColumn";
            this.günDataGridViewTextBoxColumn.Width = 125;
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "Saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "Saat";
            this.saatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            this.saatDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersDataGridViewTextBoxColumn
            // 
            this.dersDataGridViewTextBoxColumn.DataPropertyName = "Ders";
            this.dersDataGridViewTextBoxColumn.HeaderText = "Ders";
            this.dersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersDataGridViewTextBoxColumn.Name = "dersDataGridViewTextBoxColumn";
            this.dersDataGridViewTextBoxColumn.Width = 125;
            // 
            // egitmenIDDataGridViewTextBoxColumn
            // 
            this.egitmenIDDataGridViewTextBoxColumn.DataPropertyName = "EgitmenID";
            this.egitmenIDDataGridViewTextBoxColumn.HeaderText = "EgitmenID";
            this.egitmenIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.egitmenIDDataGridViewTextBoxColumn.Name = "egitmenIDDataGridViewTextBoxColumn";
            this.egitmenIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // egitmenAdıDataGridViewTextBoxColumn
            // 
            this.egitmenAdıDataGridViewTextBoxColumn.DataPropertyName = "EgitmenAdı";
            this.egitmenAdıDataGridViewTextBoxColumn.HeaderText = "EgitmenAdı";
            this.egitmenAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.egitmenAdıDataGridViewTextBoxColumn.Name = "egitmenAdıDataGridViewTextBoxColumn";
            this.egitmenAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersProgramiBindingSource
            // 
            this.dersProgramiBindingSource.DataMember = "DersProgrami";
            this.dersProgramiBindingSource.DataSource = this.onlineegitimsistemiDataSet;
            // 
            // onlineegitimsistemiDataSet
            // 
            this.onlineegitimsistemiDataSet.DataSetName = "onlineegitimsistemiDataSet";
            this.onlineegitimsistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewOgrenciNotlari
            // 
            this.dataGridViewOgrenciNotlari.AutoGenerateColumns = false;
            this.dataGridViewOgrenciNotlari.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewOgrenciNotlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenciNotlari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.dersIDDataGridViewTextBoxColumn,
            this.vizeNotuDataGridViewTextBoxColumn,
            this.finalNotuDataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn});
            this.dataGridViewOgrenciNotlari.DataSource = this.notlarBindingSource;
            this.dataGridViewOgrenciNotlari.Location = new System.Drawing.Point(638, 58);
            this.dataGridViewOgrenciNotlari.Name = "dataGridViewOgrenciNotlari";
            this.dataGridViewOgrenciNotlari.RowHeadersWidth = 51;
            this.dataGridViewOgrenciNotlari.RowTemplate.Height = 24;
            this.dataGridViewOgrenciNotlari.Size = new System.Drawing.Size(285, 150);
            this.dataGridViewOgrenciNotlari.TabIndex = 4;
            this.dataGridViewOgrenciNotlari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgrenciNotlari_CellContentClick);
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizeNotuDataGridViewTextBoxColumn
            // 
            this.vizeNotuDataGridViewTextBoxColumn.DataPropertyName = "VizeNotu";
            this.vizeNotuDataGridViewTextBoxColumn.HeaderText = "VizeNotu";
            this.vizeNotuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vizeNotuDataGridViewTextBoxColumn.Name = "vizeNotuDataGridViewTextBoxColumn";
            this.vizeNotuDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalNotuDataGridViewTextBoxColumn
            // 
            this.finalNotuDataGridViewTextBoxColumn.DataPropertyName = "FinalNotu";
            this.finalNotuDataGridViewTextBoxColumn.HeaderText = "FinalNotu";
            this.finalNotuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalNotuDataGridViewTextBoxColumn.Name = "finalNotuDataGridViewTextBoxColumn";
            this.finalNotuDataGridViewTextBoxColumn.Width = 125;
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            this.ortalamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ortalamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // notlarBindingSource
            // 
            this.notlarBindingSource.DataMember = "Notlar";
            this.notlarBindingSource.DataSource = this.onlineegitimsistemiDataSet;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(215, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ad Soyad";
            // 
            // sinif
            // 
            this.sinif.AutoSize = true;
            this.sinif.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinif.Location = new System.Drawing.Point(249, 150);
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(46, 23);
            this.sinif.TabIndex = 14;
            this.sinif.Text = "Sınıf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(203, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Öğrenci ID";
            // 
            // OgrenciAdiSoyadi
            // 
            this.OgrenciAdiSoyadi.Location = new System.Drawing.Point(332, 104);
            this.OgrenciAdiSoyadi.Name = "OgrenciAdiSoyadi";
            this.OgrenciAdiSoyadi.Size = new System.Drawing.Size(160, 22);
            this.OgrenciAdiSoyadi.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje1bilmemkaç.Properties.Resources.Ekran_görüntüsü_2025_04_30_212808;
            this.pictureBox1.Location = new System.Drawing.Point(60, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ogrenciIDtxt
            // 
            this.ogrenciIDtxt.Location = new System.Drawing.Point(332, 55);
            this.ogrenciIDtxt.Name = "ogrenciIDtxt";
            this.ogrenciIDtxt.Size = new System.Drawing.Size(100, 22);
            this.ogrenciIDtxt.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 567);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cıkısbt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bolumtxt);
            this.tabPage1.Controls.Add(this.siniftxt);
            this.tabPage1.Controls.Add(this.dataGridViewOgrenciNotlari);
            this.tabPage1.Controls.Add(this.dataGridViewDersProgrami);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.sinif);
            this.tabPage1.Controls.Add(this.ogrenciIDtxt);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.OgrenciAdiSoyadi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anasayfa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cıkısbt
            // 
            this.cıkısbt.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısbt.Image = ((System.Drawing.Image)(resources.GetObject("cıkısbt.Image")));
            this.cıkısbt.Location = new System.Drawing.Point(851, 389);
            this.cıkısbt.Name = "cıkısbt";
            this.cıkısbt.Size = new System.Drawing.Size(123, 123);
            this.cıkısbt.TabIndex = 19;
            this.cıkısbt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cıkısbt.UseVisualStyleBackColor = true;
            this.cıkısbt.Click += new System.EventHandler(this.cıkısbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(240, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bölüm";
            // 
            // bolumtxt
            // 
            this.bolumtxt.Location = new System.Drawing.Point(332, 195);
            this.bolumtxt.Name = "bolumtxt";
            this.bolumtxt.Size = new System.Drawing.Size(160, 22);
            this.bolumtxt.TabIndex = 17;
            // 
            // siniftxt
            // 
            this.siniftxt.Location = new System.Drawing.Point(332, 150);
            this.siniftxt.Name = "siniftxt";
            this.siniftxt.Size = new System.Drawing.Size(160, 22);
            this.siniftxt.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridViewdosya);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kaynaklar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoKoduDataGridViewTextBoxColumn,
            this.videonunKonusuDataGridViewTextBoxColumn,
            this.videoKalitesiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.videoekleBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(540, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(399, 232);
            this.dataGridView2.TabIndex = 1;
            // 
            // videoKoduDataGridViewTextBoxColumn
            // 
            this.videoKoduDataGridViewTextBoxColumn.DataPropertyName = "Video Kodu";
            this.videoKoduDataGridViewTextBoxColumn.HeaderText = "Video Kodu";
            this.videoKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.videoKoduDataGridViewTextBoxColumn.Name = "videoKoduDataGridViewTextBoxColumn";
            this.videoKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // videonunKonusuDataGridViewTextBoxColumn
            // 
            this.videonunKonusuDataGridViewTextBoxColumn.DataPropertyName = "Video\'nun konusu";
            this.videonunKonusuDataGridViewTextBoxColumn.HeaderText = "Video\'nun konusu";
            this.videonunKonusuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.videonunKonusuDataGridViewTextBoxColumn.Name = "videonunKonusuDataGridViewTextBoxColumn";
            this.videonunKonusuDataGridViewTextBoxColumn.Width = 125;
            // 
            // videoKalitesiDataGridViewTextBoxColumn
            // 
            this.videoKalitesiDataGridViewTextBoxColumn.DataPropertyName = "Video Kalitesi";
            this.videoKalitesiDataGridViewTextBoxColumn.HeaderText = "Video Kalitesi";
            this.videoKalitesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.videoKalitesiDataGridViewTextBoxColumn.Name = "videoKalitesiDataGridViewTextBoxColumn";
            this.videoKalitesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // videoekleBindingSource1
            // 
            this.videoekleBindingSource1.DataMember = "videoekle";
            this.videoekleBindingSource1.DataSource = this.onlineegitimsistemiDataSet;
            // 
            // dataGridViewdosya
            // 
            this.dataGridViewdosya.AllowUserToOrderColumns = true;
            this.dataGridViewdosya.AutoGenerateColumns = false;
            this.dataGridViewdosya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdosya.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dosyaKoduDataGridViewTextBoxColumn,
            this.dosyanınKonusuDataGridViewTextBoxColumn,
            this.dosyaTürüDataGridViewTextBoxColumn});
            this.dataGridViewdosya.DataSource = this.dosyaekleBindingSource;
            this.dataGridViewdosya.Location = new System.Drawing.Point(50, 102);
            this.dataGridViewdosya.Name = "dataGridViewdosya";
            this.dataGridViewdosya.RowHeadersWidth = 51;
            this.dataGridViewdosya.RowTemplate.Height = 24;
            this.dataGridViewdosya.Size = new System.Drawing.Size(409, 232);
            this.dataGridViewdosya.TabIndex = 0;
            // 
            // dosyaKoduDataGridViewTextBoxColumn
            // 
            this.dosyaKoduDataGridViewTextBoxColumn.DataPropertyName = "Dosya Kodu";
            this.dosyaKoduDataGridViewTextBoxColumn.HeaderText = "Dosya Kodu";
            this.dosyaKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosyaKoduDataGridViewTextBoxColumn.Name = "dosyaKoduDataGridViewTextBoxColumn";
            this.dosyaKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // dosyanınKonusuDataGridViewTextBoxColumn
            // 
            this.dosyanınKonusuDataGridViewTextBoxColumn.DataPropertyName = "Dosya\'nın konusu";
            this.dosyanınKonusuDataGridViewTextBoxColumn.HeaderText = "Dosya\'nın konusu";
            this.dosyanınKonusuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosyanınKonusuDataGridViewTextBoxColumn.Name = "dosyanınKonusuDataGridViewTextBoxColumn";
            this.dosyanınKonusuDataGridViewTextBoxColumn.Width = 125;
            // 
            // dosyaTürüDataGridViewTextBoxColumn
            // 
            this.dosyaTürüDataGridViewTextBoxColumn.DataPropertyName = "Dosya türü";
            this.dosyaTürüDataGridViewTextBoxColumn.HeaderText = "Dosya türü";
            this.dosyaTürüDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosyaTürüDataGridViewTextBoxColumn.Name = "dosyaTürüDataGridViewTextBoxColumn";
            this.dosyaTürüDataGridViewTextBoxColumn.Width = 125;
            // 
            // dosyaekleBindingSource
            // 
            this.dosyaekleBindingSource.DataMember = "dosyaekle";
            this.dosyaekleBindingSource.DataSource = this.onlineegitimsistemiDataSet;
            // 
            // notlarTableAdapter
            // 
            this.notlarTableAdapter.ClearBeforeFill = true;
            // 
            // dersProgramiTableAdapter
            // 
            this.dersProgramiTableAdapter.ClearBeforeFill = true;
            // 
            // dosyaekleTableAdapter
            // 
            this.dosyaekleTableAdapter.ClearBeforeFill = true;
            // 
            // videoekleTableAdapter
            // 
            this.videoekleTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciekr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1030, 606);
            this.Controls.Add(this.tabControl1);
            this.Name = "ogrenciekr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ekranı";
            this.Load += new System.EventHandler(this.ogrenciekr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersProgrami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineegitimsistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciNotlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoekleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdosya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosyaekleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoekleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDersProgrami;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciNotlari;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögretmenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğretmenAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OgrenciAdiSoyadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ogrenciIDtxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridViewdosya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bolumtxt;
        private System.Windows.Forms.TextBox siniftxt;
        private System.Windows.Forms.Button cıkısbt;
        private System.Windows.Forms.BindingSource videoekleBindingSource;
        private onlineegitimsistemiDataSet onlineegitimsistemiDataSet;
        private System.Windows.Forms.BindingSource notlarBindingSource;
        private onlineegitimsistemiDataSetTableAdapters.NotlarTableAdapter notlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizeNotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalNotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dersProgramiBindingSource;
        private onlineegitimsistemiDataSetTableAdapters.DersProgramiTableAdapter dersProgramiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn günDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egitmenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egitmenAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dosyaekleBindingSource;
        private onlineegitimsistemiDataSetTableAdapters.dosyaekleTableAdapter dosyaekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyanınKonusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource videoekleBindingSource1;
        private onlineegitimsistemiDataSetTableAdapters.videoekleTableAdapter videoekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videonunKonusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoKalitesiDataGridViewTextBoxColumn;
    }
}