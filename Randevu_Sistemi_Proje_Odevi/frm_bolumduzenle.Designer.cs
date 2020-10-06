namespace Randevu_Sistemi_Proje_Odevi
{
    partial class frm_bolumduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bolumduzenle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cekBolum3 = new System.Windows.Forms.CheckBox();
            this.cekBolum2 = new System.Windows.Forms.CheckBox();
            this.cekBolum1 = new System.Windows.Forms.CheckBox();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnTumu = new System.Windows.Forms.Button();
            this.btnSecimYok = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cekBolum3);
            this.groupBox1.Controls.Add(this.cekBolum2);
            this.groupBox1.Controls.Add(this.cekBolum1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cekBolum3
            // 
            this.cekBolum3.AutoSize = true;
            this.cekBolum3.Location = new System.Drawing.Point(19, 96);
            this.cekBolum3.Name = "cekBolum3";
            this.cekBolum3.Size = new System.Drawing.Size(106, 27);
            this.cekBolum3.TabIndex = 2;
            this.cekBolum3.Text = "BÖLÜM 3";
            this.cekBolum3.UseVisualStyleBackColor = true;
            // 
            // cekBolum2
            // 
            this.cekBolum2.AutoSize = true;
            this.cekBolum2.Location = new System.Drawing.Point(19, 63);
            this.cekBolum2.Name = "cekBolum2";
            this.cekBolum2.Size = new System.Drawing.Size(107, 27);
            this.cekBolum2.TabIndex = 1;
            this.cekBolum2.Text = "BÖLÜM 2";
            this.cekBolum2.UseVisualStyleBackColor = true;
            // 
            // cekBolum1
            // 
            this.cekBolum1.AutoSize = true;
            this.cekBolum1.Location = new System.Drawing.Point(19, 30);
            this.cekBolum1.Name = "cekBolum1";
            this.cekBolum1.Size = new System.Drawing.Size(106, 27);
            this.cekBolum1.TabIndex = 0;
            this.cekBolum1.Text = "BÖLÜM 1";
            this.cekBolum1.UseVisualStyleBackColor = true;
            this.cekBolum1.CheckedChanged += new System.EventHandler(this.cekBolum1_CheckedChanged);
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(166, 23);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(120, 34);
            this.btnYukari.TabIndex = 1;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(166, 63);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(120, 34);
            this.btnAsagi.TabIndex = 2;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnTumu
            // 
            this.btnTumu.Location = new System.Drawing.Point(166, 103);
            this.btnTumu.Name = "btnTumu";
            this.btnTumu.Size = new System.Drawing.Size(120, 34);
            this.btnTumu.TabIndex = 3;
            this.btnTumu.Text = "Tümünü Seç";
            this.btnTumu.UseVisualStyleBackColor = true;
            this.btnTumu.Click += new System.EventHandler(this.btnTumu_Click);
            // 
            // btnSecimYok
            // 
            this.btnSecimYok.Location = new System.Drawing.Point(166, 143);
            this.btnSecimYok.Name = "btnSecimYok";
            this.btnSecimYok.Size = new System.Drawing.Size(120, 34);
            this.btnSecimYok.TabIndex = 4;
            this.btnSecimYok.Text = "Seçim Yok";
            this.btnSecimYok.UseVisualStyleBackColor = true;
            this.btnSecimYok.Click += new System.EventHandler(this.btnSecimYok_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(166, 264);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(120, 34);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frm_bolumduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(292, 305);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSecimYok);
            this.Controls.Add(this.btnTumu);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_bolumduzenle";
            this.Text = "Bölüm Düzenleme";
            this.Load += new System.EventHandler(this.frm_bolumduzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cekBolum3;
        private System.Windows.Forms.CheckBox cekBolum2;
        private System.Windows.Forms.CheckBox cekBolum1;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnTumu;
        private System.Windows.Forms.Button btnSecimYok;
        private System.Windows.Forms.Button btnCikis;
    }
}