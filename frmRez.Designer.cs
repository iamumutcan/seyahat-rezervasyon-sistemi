namespace TatilRez
{
    partial class frmRez
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCadir = new System.Windows.Forms.RadioButton();
            this.rbtnOtel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnOtobus = new System.Windows.Forms.RadioButton();
            this.rbtnUcak = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxNereye = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxNereden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.DateTimeGidis = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimeDonus = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rezervasyon Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCadir);
            this.groupBox1.Controls.Add(this.rbtnOtel);
            this.groupBox1.Location = new System.Drawing.Point(90, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konaklama";
            // 
            // rbtnCadir
            // 
            this.rbtnCadir.AutoSize = true;
            this.rbtnCadir.Location = new System.Drawing.Point(56, 37);
            this.rbtnCadir.Name = "rbtnCadir";
            this.rbtnCadir.Size = new System.Drawing.Size(49, 17);
            this.rbtnCadir.TabIndex = 1;
            this.rbtnCadir.TabStop = true;
            this.rbtnCadir.Text = "Çadır";
            this.rbtnCadir.UseVisualStyleBackColor = true;
            this.rbtnCadir.CheckedChanged += new System.EventHandler(this.rbtnCadir_CheckedChanged);
            // 
            // rbtnOtel
            // 
            this.rbtnOtel.AutoSize = true;
            this.rbtnOtel.Location = new System.Drawing.Point(6, 37);
            this.rbtnOtel.Name = "rbtnOtel";
            this.rbtnOtel.Size = new System.Drawing.Size(44, 17);
            this.rbtnOtel.TabIndex = 0;
            this.rbtnOtel.TabStop = true;
            this.rbtnOtel.Text = "Otel";
            this.rbtnOtel.UseVisualStyleBackColor = true;
            this.rbtnOtel.CheckedChanged += new System.EventHandler(this.rbtnOtel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnOtobus);
            this.groupBox2.Controls.Add(this.rbtnUcak);
            this.groupBox2.Location = new System.Drawing.Point(90, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ulaşım";
            // 
            // rbtnOtobus
            // 
            this.rbtnOtobus.AutoSize = true;
            this.rbtnOtobus.Location = new System.Drawing.Point(63, 37);
            this.rbtnOtobus.Name = "rbtnOtobus";
            this.rbtnOtobus.Size = new System.Drawing.Size(59, 17);
            this.rbtnOtobus.TabIndex = 1;
            this.rbtnOtobus.TabStop = true;
            this.rbtnOtobus.Text = "Otobüs";
            this.rbtnOtobus.UseVisualStyleBackColor = true;
            this.rbtnOtobus.CheckedChanged += new System.EventHandler(this.rbtnOtobus_CheckedChanged);
            // 
            // rbtnUcak
            // 
            this.rbtnUcak.AutoSize = true;
            this.rbtnUcak.Location = new System.Drawing.Point(6, 37);
            this.rbtnUcak.Name = "rbtnUcak";
            this.rbtnUcak.Size = new System.Drawing.Size(51, 17);
            this.rbtnUcak.TabIndex = 0;
            this.rbtnUcak.TabStop = true;
            this.rbtnUcak.Text = "Uçak";
            this.rbtnUcak.UseVisualStyleBackColor = true;
            this.rbtnUcak.CheckedChanged += new System.EventHandler(this.rbtnUcak_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbxNereye);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbxNereden);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTcNo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtSoyad);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtAd);
            this.groupBox3.Location = new System.Drawing.Point(250, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 156);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişisel Bilgiler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nereye:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbxNereye
            // 
            this.cmbxNereye.FormattingEnabled = true;
            this.cmbxNereye.Items.AddRange(new object[] {
            "Adana (Çukurova)",
            "Adana (Seyhan)",
            "Adana (Yüreğir)",
            "Adana (Sarıçam)",
            "Adana (Karataş)",
            "Adana (Ceyhan)",
            "Adana (Pozantı)",
            "Adana (Feke)"});
            this.cmbxNereye.Location = new System.Drawing.Point(136, 125);
            this.cmbxNereye.Name = "cmbxNereye";
            this.cmbxNereye.Size = new System.Drawing.Size(100, 21);
            this.cmbxNereye.TabIndex = 8;
            this.cmbxNereye.Text = "Adana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nereden:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbxNereden
            // 
            this.cmbxNereden.FormattingEnabled = true;
            this.cmbxNereden.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Erzurum",
            "İzmir",
            "Paris",
            "Marsilya",
            "Roma",
            "Milano (Milan)",
            "Barcelona",
            "Madrid (Real)",
            "Mancster (United)",
            "Münih (Bayren)"});
            this.cmbxNereden.Location = new System.Drawing.Point(136, 98);
            this.cmbxNereden.Name = "cmbxNereden";
            this.cmbxNereden.Size = new System.Drawing.Size(100, 21);
            this.cmbxNereden.TabIndex = 6;
            this.cmbxNereden.Text = "Adana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC  Kimlik No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(136, 71);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(136, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(136, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // DateTimeGidis
            // 
            this.DateTimeGidis.Location = new System.Drawing.Point(70, 19);
            this.DateTimeGidis.Name = "DateTimeGidis";
            this.DateTimeGidis.Size = new System.Drawing.Size(166, 20);
            this.DateTimeGidis.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gidiş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dönüş Tarihi";
            // 
            // DateTimeDonus
            // 
            this.DateTimeDonus.Location = new System.Drawing.Point(70, 45);
            this.DateTimeDonus.Name = "DateTimeDonus";
            this.DateTimeDonus.Size = new System.Drawing.Size(166, 20);
            this.DateTimeDonus.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DateTimeGidis);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.DateTimeDonus);
            this.groupBox4.Location = new System.Drawing.Point(250, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 85);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seyahat Tarihleri";
            // 
            // frmRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(545, 400);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmRez";
            this.Text = "Seyahat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCadir;
        private System.Windows.Forms.RadioButton rbtnOtel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnOtobus;
        private System.Windows.Forms.RadioButton rbtnUcak;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimeDonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimeGidis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxNereye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxNereden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

