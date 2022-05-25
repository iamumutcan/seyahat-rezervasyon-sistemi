namespace TatilRez
{
    partial class FrmRezGoster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKonaklamaIptal = new System.Windows.Forms.Button();
            this.btnUlasimIptal = new System.Windows.Forms.Button();
            this.btnRezIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKonaklamaIptal);
            this.panel1.Controls.Add(this.btnUlasimIptal);
            this.panel1.Controls.Add(this.btnRezIptal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnKonaklamaIptal
            // 
            this.btnKonaklamaIptal.BackColor = System.Drawing.Color.SandyBrown;
            this.btnKonaklamaIptal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKonaklamaIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonaklamaIptal.Location = new System.Drawing.Point(278, 0);
            this.btnKonaklamaIptal.Name = "btnKonaklamaIptal";
            this.btnKonaklamaIptal.Size = new System.Drawing.Size(139, 73);
            this.btnKonaklamaIptal.TabIndex = 2;
            this.btnKonaklamaIptal.Text = "Konaklama İptal";
            this.btnKonaklamaIptal.UseVisualStyleBackColor = false;
            this.btnKonaklamaIptal.Click += new System.EventHandler(this.btnKonaklamaIptal_Click);
            // 
            // btnUlasimIptal
            // 
            this.btnUlasimIptal.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUlasimIptal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUlasimIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUlasimIptal.Location = new System.Drawing.Point(139, 0);
            this.btnUlasimIptal.Name = "btnUlasimIptal";
            this.btnUlasimIptal.Size = new System.Drawing.Size(139, 73);
            this.btnUlasimIptal.TabIndex = 1;
            this.btnUlasimIptal.Text = "Ulaşım İptal";
            this.btnUlasimIptal.UseVisualStyleBackColor = false;
            this.btnUlasimIptal.Click += new System.EventHandler(this.btnUlasimIptal_Click);
            // 
            // btnRezIptal
            // 
            this.btnRezIptal.BackColor = System.Drawing.Color.Red;
            this.btnRezIptal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRezIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezIptal.Location = new System.Drawing.Point(0, 0);
            this.btnRezIptal.Name = "btnRezIptal";
            this.btnRezIptal.Size = new System.Drawing.Size(139, 73);
            this.btnRezIptal.TabIndex = 0;
            this.btnRezIptal.Text = "Rezervasyon İptal";
            this.btnRezIptal.UseVisualStyleBackColor = false;
            this.btnRezIptal.Click += new System.EventHandler(this.btnRezIptal_Click);
            // 
            // FrmRezGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRezGoster";
            this.Text = "FrmRezGoster";
            this.Load += new System.EventHandler(this.FrmRezGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKonaklamaIptal;
        private System.Windows.Forms.Button btnUlasimIptal;
        private System.Windows.Forms.Button btnRezIptal;
    }
}