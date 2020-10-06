namespace Randevu_Sistemi_Proje_Odevi
{
    partial class frm_rehbertanimlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rehbertanimlari));
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExceldenAktar = new System.Windows.Forms.Button();
            this.btnTumunuSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(736, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 33);
            this.button8.TabIndex = 7;
            this.button8.Text = "KAPAT";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnExceldenAktar);
            this.groupBox1.Controls.Add(this.btnTumunuSil);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnDuzenle);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExceldenAktar
            // 
            this.btnExceldenAktar.Location = new System.Drawing.Point(502, 16);
            this.btnExceldenAktar.Name = "btnExceldenAktar";
            this.btnExceldenAktar.Size = new System.Drawing.Size(157, 31);
            this.btnExceldenAktar.TabIndex = 12;
            this.btnExceldenAktar.Text = "Excel\'den Aktar";
            this.btnExceldenAktar.UseVisualStyleBackColor = true;
            this.btnExceldenAktar.Click += new System.EventHandler(this.btnExceldenAktar_Click);
            // 
            // btnTumunuSil
            // 
            this.btnTumunuSil.Location = new System.Drawing.Point(349, 16);
            this.btnTumunuSil.Name = "btnTumunuSil";
            this.btnTumunuSil.Size = new System.Drawing.Size(122, 31);
            this.btnTumunuSil.TabIndex = 11;
            this.btnTumunuSil.Text = "Tümünü Sil";
            this.btnTumunuSil.UseVisualStyleBackColor = true;
            this.btnTumunuSil.Click += new System.EventHandler(this.btnTumunuSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(235, 16);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 31);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(114, 16);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(96, 31);
            this.btnDuzenle.TabIndex = 9;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(4, 14);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(91, 31);
            this.btnYeni.TabIndex = 7;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 365);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sil
            // 
            this.sil.AutoSize = true;
            this.sil.Location = new System.Drawing.Point(323, 17);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(51, 23);
            this.sil.TabIndex = 14;
            this.sil.Text = "silme";
            this.sil.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frm_rehbertanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 487);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button8);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_rehbertanimlari";
            this.Text = "Rehber Tanımları";
            this.Load += new System.EventHandler(this.frm_rehbertanimlari_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExceldenAktar;
        private System.Windows.Forms.Button btnTumunuSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}