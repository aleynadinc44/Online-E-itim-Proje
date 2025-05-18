using System;

namespace proje1bilmemkaç
{
    partial class egtekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(egtekran));
            this.EgitmenIDtxt = new System.Windows.Forms.TextBox();
            this.EgitmenAdiSoyadi = new System.Windows.Forms.TextBox();
            this.Branstxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cıkısbt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.videosilbt = new System.Windows.Forms.Button();
            this.dosyasilbt = new System.Windows.Forms.Button();
            this.videoeklebt = new System.Windows.Forms.Button();
            this.DosyEklebt = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kalitecomboBox = new System.Windows.Forms.ComboBox();
            this.videokodu = new System.Windows.Forms.TextBox();
            this.videokonu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dosyaturucombobox = new System.Windows.Forms.ComboBox();
            this.dosyakodutxt = new System.Windows.Forms.TextBox();
            this.dosyakonutxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.onlineegitimsistemiDataSet = new proje1bilmemkaç.onlineegitimsistemiDataSet();
            this.egitmendersprogramiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egitmen_dersprogramiTableAdapter = new proje1bilmemkaç.onlineegitimsistemiDataSetTableAdapters.egitmen_dersprogramiTableAdapter();
            this.egitmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyaekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dosyaekleTableAdapter = new proje1bilmemkaç.onlineegitimsistemiDataSetTableAdapters.dosyaekleTableAdapter();
            this.dosyaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyanınKonusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyaTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoekleTableAdapter = new proje1bilmemkaç.onlineegitimsistemiDataSetTableAdapters.videoekleTableAdapter();
            this.videoKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videonunKonusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoKalitesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineegitimsistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitmendersprogramiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosyaekleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoekleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EgitmenIDtxt
            // 
            this.EgitmenIDtxt.Location = new System.Drawing.Point(298, 42);
            this.EgitmenIDtxt.Name = "EgitmenIDtxt";
            this.EgitmenIDtxt.Size = new System.Drawing.Size(100, 22);
            this.EgitmenIDtxt.TabIndex = 1;
            // 
            // EgitmenAdiSoyadi
            // 
            this.EgitmenAdiSoyadi.Location = new System.Drawing.Point(298, 91);
            this.EgitmenAdiSoyadi.Name = "EgitmenAdiSoyadi";
            this.EgitmenAdiSoyadi.Size = new System.Drawing.Size(160, 22);
            this.EgitmenAdiSoyadi.TabIndex = 2;
            // 
            // Branstxt
            // 
            this.Branstxt.Location = new System.Drawing.Point(298, 139);
            this.Branstxt.Name = "Branstxt";
            this.Branstxt.Size = new System.Drawing.Size(160, 22);
            this.Branstxt.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 587);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cıkısbt);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Branstxt);
            this.tabPage1.Controls.Add(this.EgitmenAdiSoyadi);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.EgitmenIDtxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eğitmen Anasayfa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cıkısbt
            // 
            this.cıkısbt.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısbt.Image = ((System.Drawing.Image)(resources.GetObject("cıkısbt.Image")));
            this.cıkısbt.Location = new System.Drawing.Point(850, 23);
            this.cıkısbt.Name = "cıkısbt";
            this.cıkısbt.Size = new System.Drawing.Size(123, 115);
            this.cıkısbt.TabIndex = 9;
            this.cıkısbt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cıkısbt.UseVisualStyleBackColor = true;
            this.cıkısbt.Click += new System.EventHandler(this.cıkısbt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(181, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ad Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(215, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Branş";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(169, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Eğitmen ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.egitmenIDDataGridViewTextBoxColumn,
            this.dersadiDataGridViewTextBoxColumn,
            this.gunDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.soyadıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.egitmendersprogramiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 265);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje1bilmemkaç.Properties.Resources.Ekran_görüntüsü_2025_04_30_212713;
            this.pictureBox1.Location = new System.Drawing.Point(26, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.videosilbt);
            this.tabPage2.Controls.Add(this.dosyasilbt);
            this.tabPage2.Controls.Add(this.videoeklebt);
            this.tabPage2.Controls.Add(this.DosyEklebt);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.kalitecomboBox);
            this.tabPage2.Controls.Add(this.videokodu);
            this.tabPage2.Controls.Add(this.videokonu);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dosyaturucombobox);
            this.tabPage2.Controls.Add(this.dosyakodutxt);
            this.tabPage2.Controls.Add(this.dosyakonutxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // videosilbt
            // 
            this.videosilbt.Location = new System.Drawing.Point(764, 243);
            this.videosilbt.Name = "videosilbt";
            this.videosilbt.Size = new System.Drawing.Size(88, 44);
            this.videosilbt.TabIndex = 21;
            this.videosilbt.Text = "Video Sil";
            this.videosilbt.UseVisualStyleBackColor = true;
            this.videosilbt.Click += new System.EventHandler(this.videosilbt_Click);
            // 
            // dosyasilbt
            // 
            this.dosyasilbt.Location = new System.Drawing.Point(264, 243);
            this.dosyasilbt.Name = "dosyasilbt";
            this.dosyasilbt.Size = new System.Drawing.Size(88, 44);
            this.dosyasilbt.TabIndex = 20;
            this.dosyasilbt.Text = "Dosya Sil";
            this.dosyasilbt.UseVisualStyleBackColor = true;
            this.dosyasilbt.Click += new System.EventHandler(this.dosyasilbt_Click);
            // 
            // videoeklebt
            // 
            this.videoeklebt.Location = new System.Drawing.Point(619, 243);
            this.videoeklebt.Name = "videoeklebt";
            this.videoeklebt.Size = new System.Drawing.Size(88, 44);
            this.videoeklebt.TabIndex = 19;
            this.videoeklebt.Text = "Video Ekle";
            this.videoeklebt.UseVisualStyleBackColor = true;
            this.videoeklebt.Click += new System.EventHandler(this.videoeklebt_Click);
            // 
            // DosyEklebt
            // 
            this.DosyEklebt.Location = new System.Drawing.Point(125, 243);
            this.DosyEklebt.Name = "DosyEklebt";
            this.DosyEklebt.Size = new System.Drawing.Size(88, 44);
            this.DosyEklebt.TabIndex = 18;
            this.DosyEklebt.Text = "Dosya Ekle";
            this.DosyEklebt.UseVisualStyleBackColor = true;
            this.DosyEklebt.Click += new System.EventHandler(this.DosyaEklebt_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoKoduDataGridViewTextBoxColumn,
            this.videonunKonusuDataGridViewTextBoxColumn,
            this.videoKalitesiDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.videoekleBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(517, 306);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(421, 235);
            this.dataGridView3.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dosyaKoduDataGridViewTextBoxColumn,
            this.dosyanınKonusuDataGridViewTextBoxColumn,
            this.dosyaTürüDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dosyaekleBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(24, 306);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(421, 235);
            this.dataGridView2.TabIndex = 16;
            // 
            // kalitecomboBox
            // 
            this.kalitecomboBox.FormattingEnabled = true;
            this.kalitecomboBox.Items.AddRange(new object[] {
            "1440p",
            "1080p",
            "720p",
            "480p"});
            this.kalitecomboBox.Location = new System.Drawing.Point(750, 164);
            this.kalitecomboBox.Name = "kalitecomboBox";
            this.kalitecomboBox.Size = new System.Drawing.Size(121, 24);
            this.kalitecomboBox.TabIndex = 15;
            // 
            // videokodu
            // 
            this.videokodu.Location = new System.Drawing.Point(750, 202);
            this.videokodu.Name = "videokodu";
            this.videokodu.Size = new System.Drawing.Size(121, 22);
            this.videokodu.TabIndex = 14;
            // 
            // videokonu
            // 
            this.videokonu.Location = new System.Drawing.Point(750, 124);
            this.videokonu.Name = "videokonu";
            this.videokonu.Size = new System.Drawing.Size(121, 22);
            this.videokonu.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(615, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Video Kodu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(607, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Video Kalitesi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(578, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Video\'nun konusu";
            // 
            // dosyaturucombobox
            // 
            this.dosyaturucombobox.FormattingEnabled = true;
            this.dosyaturucombobox.Items.AddRange(new object[] {
            "TXT",
            "DOC",
            "DOCX",
            "XLS",
            "PPT",
            "PDF",
            "PNG",
            "JPG",
            "WAV",
            "AVİ"});
            this.dosyaturucombobox.Location = new System.Drawing.Point(253, 165);
            this.dosyaturucombobox.Name = "dosyaturucombobox";
            this.dosyaturucombobox.Size = new System.Drawing.Size(121, 24);
            this.dosyaturucombobox.TabIndex = 9;
            this.dosyaturucombobox.SelectedIndexChanged += new System.EventHandler(this.dosyaturucombobox_SelectedIndexChanged);
            // 
            // dosyakodutxt
            // 
            this.dosyakodutxt.Location = new System.Drawing.Point(253, 203);
            this.dosyakodutxt.Name = "dosyakodutxt";
            this.dosyakodutxt.Size = new System.Drawing.Size(121, 22);
            this.dosyakodutxt.TabIndex = 8;
            // 
            // dosyakonutxt
            // 
            this.dosyakonutxt.Location = new System.Drawing.Point(253, 126);
            this.dosyakonutxt.Name = "dosyakonutxt";
            this.dosyakonutxt.Size = new System.Drawing.Size(121, 22);
            this.dosyakonutxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(121, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dosya Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(132, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dosya türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(84, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dosya\'nın konusu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(670, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video Yükle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yükle";
            // 
            // onlineegitimsistemiDataSet
            // 
            this.onlineegitimsistemiDataSet.DataSetName = "onlineegitimsistemiDataSet";
            this.onlineegitimsistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // egitmendersprogramiBindingSource
            // 
            this.egitmendersprogramiBindingSource.DataMember = "egitmen_dersprogrami";
            this.egitmendersprogramiBindingSource.DataSource = this.onlineegitimsistemiDataSet;
            // 
            // egitmen_dersprogramiTableAdapter
            // 
            this.egitmen_dersprogramiTableAdapter.ClearBeforeFill = true;
            // 
            // egitmenIDDataGridViewTextBoxColumn
            // 
            this.egitmenIDDataGridViewTextBoxColumn.DataPropertyName = "EgitmenID";
            this.egitmenIDDataGridViewTextBoxColumn.HeaderText = "EgitmenID";
            this.egitmenIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.egitmenIDDataGridViewTextBoxColumn.Name = "egitmenIDDataGridViewTextBoxColumn";
            this.egitmenIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersadiDataGridViewTextBoxColumn
            // 
            this.dersadiDataGridViewTextBoxColumn.DataPropertyName = "ders_adi";
            this.dersadiDataGridViewTextBoxColumn.HeaderText = "ders_adi";
            this.dersadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersadiDataGridViewTextBoxColumn.Name = "dersadiDataGridViewTextBoxColumn";
            this.dersadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gunDataGridViewTextBoxColumn
            // 
            this.gunDataGridViewTextBoxColumn.DataPropertyName = "gun";
            this.gunDataGridViewTextBoxColumn.HeaderText = "gun";
            this.gunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gunDataGridViewTextBoxColumn.Name = "gunDataGridViewTextBoxColumn";
            this.gunDataGridViewTextBoxColumn.Width = 125;
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "saat";
            this.saatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            this.saatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "Adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            this.adıDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadıDataGridViewTextBoxColumn
            // 
            this.soyadıDataGridViewTextBoxColumn.DataPropertyName = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadıDataGridViewTextBoxColumn.Name = "soyadıDataGridViewTextBoxColumn";
            this.soyadıDataGridViewTextBoxColumn.Width = 125;
            // 
            // dosyaekleBindingSource
            // 
            this.dosyaekleBindingSource.DataMember = "dosyaekle";
            this.dosyaekleBindingSource.DataSource = this.onlineegitimsistemiDataSet;
            // 
            // dosyaekleTableAdapter
            // 
            this.dosyaekleTableAdapter.ClearBeforeFill = true;
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
            // videoekleBindingSource
            // 
            this.videoekleBindingSource.DataMember = "videoekle";
            this.videoekleBindingSource.DataSource = this.onlineegitimsistemiDataSet;
            // 
            // videoekleTableAdapter
            // 
            this.videoekleTableAdapter.ClearBeforeFill = true;
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
            // egtekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 606);
            this.Controls.Add(this.tabControl1);
            this.Name = "egtekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egitmen Ekranı";
            this.Load += new System.EventHandler(this.egtekran_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineegitimsistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitmendersprogramiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosyaekleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoekleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox EgitmenIDtxt;
        private System.Windows.Forms.TextBox EgitmenAdiSoyadi;
        private System.Windows.Forms.TextBox Branstxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dosyakonutxt;
        private System.Windows.Forms.TextBox dosyakodutxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox dosyaturucombobox;
        private System.Windows.Forms.ComboBox kalitecomboBox;
        private System.Windows.Forms.TextBox videokodu;
        private System.Windows.Forms.TextBox videokonu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button videoeklebt;
        private System.Windows.Forms.Button DosyEklebt;
        private System.Windows.Forms.Button videosilbt;
        private System.Windows.Forms.Button dosyasilbt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cıkısbt;
        private onlineegitimsistemiDataSet onlineegitimsistemiDataSet;
        private System.Windows.Forms.BindingSource egitmendersprogramiBindingSource;
        private onlineegitimsistemiDataSetTableAdapters.egitmen_dersprogramiTableAdapter egitmen_dersprogramiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn egitmenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dosyaekleBindingSource;
        private onlineegitimsistemiDataSetTableAdapters.dosyaekleTableAdapter dosyaekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyanınKonusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource videoekleBindingSource;
        private onlineegitimsistemiDataSetTableAdapters.videoekleTableAdapter videoekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videonunKonusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoKalitesiDataGridViewTextBoxColumn;
    }
}