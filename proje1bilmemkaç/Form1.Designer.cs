namespace proje1bilmemkaç
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.KayitBt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.egitmensifre = new System.Windows.Forms.TextBox();
            this.egimentc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogretmengiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTCNo = new System.Windows.Forms.MaskedTextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ogrencigiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kayıtogrt = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KayitBt
            // 
            this.KayitBt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitBt.ForeColor = System.Drawing.Color.Firebrick;
            this.KayitBt.Location = new System.Drawing.Point(130, 405);
            this.KayitBt.Name = "KayitBt";
            this.KayitBt.Size = new System.Drawing.Size(160, 54);
            this.KayitBt.TabIndex = 7;
            this.KayitBt.Text = "Kayıt Ol";
            this.KayitBt.UseVisualStyleBackColor = true;
            this.KayitBt.Click += new System.EventHandler(this.KayitBt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.egitmensifre);
            this.groupBox2.Controls.Add(this.egimentc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ogretmengiris);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(447, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 295);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eğitmen Girişi";
            // 
            // egitmensifre
            // 
            this.egitmensifre.Location = new System.Drawing.Point(164, 123);
            this.egitmensifre.Name = "egitmensifre";
            this.egitmensifre.PasswordChar = '*';
            this.egitmensifre.Size = new System.Drawing.Size(112, 33);
            this.egitmensifre.TabIndex = 42;
            // 
            // egimentc
            // 
            this.egimentc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.egimentc.Location = new System.Drawing.Point(164, 63);
            this.egimentc.Mask = "00000000000";
            this.egimentc.Name = "egimentc";
            this.egimentc.Size = new System.Drawing.Size(135, 27);
            this.egimentc.TabIndex = 42;
            this.egimentc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // ogretmengiris
            // 
            this.ogretmengiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmengiris.Location = new System.Drawing.Point(119, 239);
            this.ogretmengiris.Name = "ogretmengiris";
            this.ogretmengiris.Size = new System.Drawing.Size(91, 34);
            this.ogretmengiris.TabIndex = 2;
            this.ogretmengiris.Text = "Giriş yap";
            this.ogretmengiris.UseVisualStyleBackColor = true;
            this.ogretmengiris.Click += new System.EventHandler(this.ogretmengiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.txtTCNo);
            this.groupBox1.Controls.Add(this.sifreText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Ogrencigiris);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(49, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Girişi";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(150, 65);
            this.txtTCNo.Mask = "00000000000";
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(135, 27);
            this.txtTCNo.TabIndex = 41;
            this.txtTCNo.ValidatingType = typeof(System.DateTime);
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(150, 129);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.Size = new System.Drawing.Size(112, 33);
            this.sifreText.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(77, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kullanıcı Adı :";
            // 
            // Ogrencigiris
            // 
            this.Ogrencigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrencigiris.Location = new System.Drawing.Point(111, 237);
            this.Ogrencigiris.Name = "Ogrencigiris";
            this.Ogrencigiris.Size = new System.Drawing.Size(91, 34);
            this.Ogrencigiris.TabIndex = 7;
            this.Ogrencigiris.Text = "Giriş yap";
            this.Ogrencigiris.UseVisualStyleBackColor = true;
            this.Ogrencigiris.Click += new System.EventHandler(this.Ogrencigiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(353, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giriş";
            // 
            // kayıtogrt
            // 
            this.kayıtogrt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtogrt.ForeColor = System.Drawing.Color.Firebrick;
            this.kayıtogrt.Location = new System.Drawing.Point(514, 405);
            this.kayıtogrt.Name = "kayıtogrt";
            this.kayıtogrt.Size = new System.Drawing.Size(160, 54);
            this.kayıtogrt.TabIndex = 8;
            this.kayıtogrt.Text = "Kayıt Ol";
            this.kayıtogrt.UseVisualStyleBackColor = true;
            this.kayıtogrt.Click += new System.EventHandler(this.kayıtogrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 509);
            this.Controls.Add(this.kayıtogrt);
            this.Controls.Add(this.KayitBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KayitBt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ogretmengiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Ogrencigiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTCNo;
        private System.Windows.Forms.Button kayıtogrt;
        private System.Windows.Forms.TextBox egitmensifre;
        private System.Windows.Forms.MaskedTextBox egimentc;
    }
}

