namespace proje1bilmemkaç
{
    partial class kayitol
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
            this.txtCepTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.txtTCNo = new System.Windows.Forms.MaskedTextBox();
            this.Kayitbt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dogumt = new System.Windows.Forms.Label();
            this.txtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.İptalbt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Sifretxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCepTelefonu.Location = new System.Drawing.Point(376, 437);
            this.txtCepTelefonu.Mask = "+90(999) 000-0000";
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(135, 27);
            this.txtCepTelefonu.TabIndex = 41;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(376, 232);
            this.txtTCNo.Mask = "00000000000";
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(135, 27);
            this.txtTCNo.TabIndex = 40;
            this.txtTCNo.ValidatingType = typeof(System.DateTime);
            // 
            // Kayitbt
            // 
            this.Kayitbt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayitbt.ForeColor = System.Drawing.Color.Maroon;
            this.Kayitbt.Location = new System.Drawing.Point(98, 629);
            this.Kayitbt.Name = "Kayitbt";
            this.Kayitbt.Size = new System.Drawing.Size(243, 69);
            this.Kayitbt.TabIndex = 39;
            this.Kayitbt.Text = "Kayıt Ol";
            this.Kayitbt.UseVisualStyleBackColor = true;
            this.Kayitbt.Click += new System.EventHandler(this.KayitOlBt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(337, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 44);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kayıt";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(376, 189);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(135, 27);
            this.txtSoyad.TabIndex = 37;
            // 
            // txtSinif
            // 
            this.txtSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinif.Location = new System.Drawing.Point(376, 349);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(135, 27);
            this.txtSinif.TabIndex = 36;
            this.txtSinif.TextChanged += new System.EventHandler(this.txtSinif_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(286, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Sınıf :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(298, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(264, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Bölüm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(259, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Soyadı :";
            // 
            // txtBolum
            // 
            this.txtBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolum.Location = new System.Drawing.Point(376, 393);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(135, 27);
            this.txtBolum.TabIndex = 31;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(376, 149);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 27);
            this.txtAd.TabIndex = 30;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(199, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cep Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(256, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "TC. No :";
            // 
            // dogumt
            // 
            this.dogumt.AutoSize = true;
            this.dogumt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumt.Location = new System.Drawing.Point(187, 287);
            this.dogumt.Name = "dogumt";
            this.dogumt.Size = new System.Drawing.Size(154, 26);
            this.dogumt.TabIndex = 42;
            this.dogumt.Text = "Doğum Tarihi :";
            this.dogumt.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogumTarihi.Location = new System.Drawing.Point(376, 289);
            this.txtDogumTarihi.Mask = "0000/00/00";
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(135, 27);
            this.txtDogumTarihi.TabIndex = 43;
            this.txtDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(376, 496);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(135, 22);
            this.txtAdres.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(275, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Adres:";
            // 
            // İptalbt
            // 
            this.İptalbt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.İptalbt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İptalbt.ForeColor = System.Drawing.Color.Maroon;
            this.İptalbt.Location = new System.Drawing.Point(403, 629);
            this.İptalbt.Name = "İptalbt";
            this.İptalbt.Size = new System.Drawing.Size(232, 69);
            this.İptalbt.TabIndex = 46;
            this.İptalbt.Text = "İptal";
            this.İptalbt.UseVisualStyleBackColor = true;
            this.İptalbt.Click += new System.EventHandler(this.iptalbt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(276, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 26);
            this.label9.TabIndex = 47;
            this.label9.Text = "Şifre:";
            // 
            // Sifretxt
            // 
            this.Sifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifretxt.Location = new System.Drawing.Point(376, 545);
            this.Sifretxt.Multiline = true;
            this.Sifretxt.Name = "Sifretxt";
            this.Sifretxt.PasswordChar = '*';
            this.Sifretxt.Size = new System.Drawing.Size(135, 22);
            this.Sifretxt.TabIndex = 48;
            // 
            // kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1bilmemkaç.Properties.Resources._4_4;
            this.ClientSize = new System.Drawing.Size(782, 751);
            this.Controls.Add(this.Sifretxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.İptalbt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.dogumt);
            this.Controls.Add(this.txtCepTelefonu);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.Kayitbt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSinif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "kayitol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCepTelefonu;
        private System.Windows.Forms.MaskedTextBox txtTCNo;
        private System.Windows.Forms.Button Kayitbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dogumt;
        private System.Windows.Forms.MaskedTextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button İptalbt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Sifretxt;
    }
}