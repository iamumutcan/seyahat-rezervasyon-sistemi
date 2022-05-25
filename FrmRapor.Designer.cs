namespace TatilRez
{
    partial class FrmRapor
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
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.rbtnJSON = new System.Windows.Forms.RadioButton();
            this.rbtnHTML = new System.Windows.Forms.RadioButton();
            this.rbtnXML = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRaporAl);
            this.panel1.Controls.Add(this.rbtnJSON);
            this.panel1.Controls.Add(this.rbtnHTML);
            this.panel1.Controls.Add(this.rbtnXML);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 65);
            this.panel1.TabIndex = 1;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRaporAl.Location = new System.Drawing.Point(805, 0);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(75, 65);
            this.btnRaporAl.TabIndex = 3;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // rbtnJSON
            // 
            this.rbtnJSON.AutoSize = true;
            this.rbtnJSON.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnJSON.Location = new System.Drawing.Point(102, 0);
            this.rbtnJSON.Name = "rbtnJSON";
            this.rbtnJSON.Size = new System.Drawing.Size(53, 65);
            this.rbtnJSON.TabIndex = 2;
            this.rbtnJSON.TabStop = true;
            this.rbtnJSON.Text = "JSON";
            this.rbtnJSON.UseVisualStyleBackColor = true;
            // 
            // rbtnHTML
            // 
            this.rbtnHTML.AutoSize = true;
            this.rbtnHTML.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnHTML.Location = new System.Drawing.Point(47, 0);
            this.rbtnHTML.Name = "rbtnHTML";
            this.rbtnHTML.Size = new System.Drawing.Size(55, 65);
            this.rbtnHTML.TabIndex = 1;
            this.rbtnHTML.TabStop = true;
            this.rbtnHTML.Text = "HTML";
            this.rbtnHTML.UseVisualStyleBackColor = true;
            // 
            // rbtnXML
            // 
            this.rbtnXML.AutoSize = true;
            this.rbtnXML.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnXML.Location = new System.Drawing.Point(0, 0);
            this.rbtnXML.Name = "rbtnXML";
            this.rbtnXML.Size = new System.Drawing.Size(47, 65);
            this.rbtnXML.TabIndex = 0;
            this.rbtnXML.TabStop = true;
            this.rbtnXML.Text = "XML";
            this.rbtnXML.UseVisualStyleBackColor = true;
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.RadioButton rbtnJSON;
        private System.Windows.Forms.RadioButton rbtnHTML;
        private System.Windows.Forms.RadioButton rbtnXML;
    }
}