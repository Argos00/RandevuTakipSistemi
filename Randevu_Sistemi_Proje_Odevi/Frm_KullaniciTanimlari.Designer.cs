namespace Randevu_Sistemi_Proje_Odevi
{
    partial class Frm_KullaniciTanimlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KullaniciTanimlari));
            this.btnekle = new System.Windows.Forms.Button();
            this.btndegistir = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 260);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(95, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Kullanıcı Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btndegistir
            // 
            this.btndegistir.Location = new System.Drawing.Point(116, 260);
            this.btndegistir.Name = "btndegistir";
            this.btndegistir.Size = new System.Drawing.Size(95, 23);
            this.btndegistir.TabIndex = 2;
            this.btndegistir.Text = "Kullanıcı Değiştir";
            this.btndegistir.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(217, 259);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(95, 23);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Kullanıcı Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(341, 259);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(78, 23);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // sil
            // 
            this.sil.AutoSize = true;
            this.sil.Location = new System.Drawing.Point(243, 285);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(35, 13);
            this.sil.TabIndex = 5;
            this.sil.Text = "label1";
            this.sil.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(399, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcı Listesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(407, 251);
            this.tabControl1.TabIndex = 0;
            // 
            // Frm_KullaniciTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 305);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btndegistir);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_KullaniciTanimlari";
            this.Text = "Kullanıcı Tanımları";
            this.Load += new System.EventHandler(this.Frm_KullaniciTanimlari_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btndegistir;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Label sil;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}