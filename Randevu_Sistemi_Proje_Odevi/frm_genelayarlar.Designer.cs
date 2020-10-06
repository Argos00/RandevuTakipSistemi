namespace Randevu_Sistemi_Proje_Odevi
{
    partial class frm_genelayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_genelayarlar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dudBitis = new System.Windows.Forms.DomainUpDown();
            this.dudBaslangic = new System.Windows.Forms.DomainUpDown();
            this.cekCalısmaSaatleri = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cekPazar = new System.Windows.Forms.CheckBox();
            this.cekCumartesi = new System.Windows.Forms.CheckBox();
            this.cekCuma = new System.Windows.Forms.CheckBox();
            this.cekPersembe = new System.Windows.Forms.CheckBox();
            this.cekCarsamba = new System.Windows.Forms.CheckBox();
            this.cekSali = new System.Windows.Forms.CheckBox();
            this.cekPazartesi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dudguncellemesure = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dudRAralık = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dudguncellemesure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudRAralık)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dudBitis);
            this.groupBox1.Controls.Add(this.dudBaslangic);
            this.groupBox1.Controls.Add(this.cekCalısmaSaatleri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cekPazar);
            this.groupBox1.Controls.Add(this.cekCumartesi);
            this.groupBox1.Controls.Add(this.cekCuma);
            this.groupBox1.Controls.Add(this.cekPersembe);
            this.groupBox1.Controls.Add(this.cekCarsamba);
            this.groupBox1.Controls.Add(this.cekSali);
            this.groupBox1.Controls.Add(this.cekPazartesi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(641, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haftalık Çalışma Takvimi";
            // 
            // dudBitis
            // 
            this.dudBitis.Location = new System.Drawing.Point(98, 122);
            this.dudBitis.Name = "dudBitis";
            this.dudBitis.Size = new System.Drawing.Size(120, 27);
            this.dudBitis.TabIndex = 11;
            // 
            // dudBaslangic
            // 
            this.dudBaslangic.Location = new System.Drawing.Point(98, 89);
            this.dudBaslangic.Name = "dudBaslangic";
            this.dudBaslangic.Size = new System.Drawing.Size(120, 27);
            this.dudBaslangic.TabIndex = 3;
            // 
            // cekCalısmaSaatleri
            // 
            this.cekCalısmaSaatleri.AutoSize = true;
            this.cekCalısmaSaatleri.Location = new System.Drawing.Point(247, 107);
            this.cekCalısmaSaatleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekCalısmaSaatleri.Name = "cekCalısmaSaatleri";
            this.cekCalısmaSaatleri.Size = new System.Drawing.Size(267, 23);
            this.cekCalısmaSaatleri.TabIndex = 10;
            this.cekCalısmaSaatleri.Text = "Sadece Çalışma Saatlerini Görüntüle";
            this.cekCalısmaSaatleri.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitiş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Başlangıç:";
            // 
            // cekPazar
            // 
            this.cekPazar.AutoSize = true;
            this.cekPazar.Location = new System.Drawing.Point(570, 54);
            this.cekPazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekPazar.Name = "cekPazar";
            this.cekPazar.Size = new System.Drawing.Size(65, 23);
            this.cekPazar.TabIndex = 7;
            this.cekPazar.Text = "Pazar";
            this.cekPazar.UseVisualStyleBackColor = true;
            // 
            // cekCumartesi
            // 
            this.cekCumartesi.AutoSize = true;
            this.cekCumartesi.Location = new System.Drawing.Point(459, 54);
            this.cekCumartesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekCumartesi.Name = "cekCumartesi";
            this.cekCumartesi.Size = new System.Drawing.Size(95, 23);
            this.cekCumartesi.TabIndex = 6;
            this.cekCumartesi.Text = "Cumartesi";
            this.cekCumartesi.UseVisualStyleBackColor = true;
            // 
            // cekCuma
            // 
            this.cekCuma.AutoSize = true;
            this.cekCuma.Location = new System.Drawing.Point(378, 54);
            this.cekCuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekCuma.Name = "cekCuma";
            this.cekCuma.Size = new System.Drawing.Size(66, 23);
            this.cekCuma.TabIndex = 5;
            this.cekCuma.Text = "Cuma";
            this.cekCuma.UseVisualStyleBackColor = true;
            // 
            // cekPersembe
            // 
            this.cekPersembe.AutoSize = true;
            this.cekPersembe.Location = new System.Drawing.Point(268, 54);
            this.cekPersembe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekPersembe.Name = "cekPersembe";
            this.cekPersembe.Size = new System.Drawing.Size(93, 23);
            this.cekPersembe.TabIndex = 4;
            this.cekPersembe.Text = "Perşembe";
            this.cekPersembe.UseVisualStyleBackColor = true;
            // 
            // cekCarsamba
            // 
            this.cekCarsamba.AutoSize = true;
            this.cekCarsamba.Location = new System.Drawing.Point(163, 54);
            this.cekCarsamba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekCarsamba.Name = "cekCarsamba";
            this.cekCarsamba.Size = new System.Drawing.Size(94, 23);
            this.cekCarsamba.TabIndex = 3;
            this.cekCarsamba.Text = "Çarşamba";
            this.cekCarsamba.UseVisualStyleBackColor = true;
            // 
            // cekSali
            // 
            this.cekSali.AutoSize = true;
            this.cekSali.Location = new System.Drawing.Point(104, 54);
            this.cekSali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekSali.Name = "cekSali";
            this.cekSali.Size = new System.Drawing.Size(53, 23);
            this.cekSali.TabIndex = 2;
            this.cekSali.Text = "Salı";
            this.cekSali.UseVisualStyleBackColor = true;
            // 
            // cekPazartesi
            // 
            this.cekPazartesi.AutoSize = true;
            this.cekPazartesi.Location = new System.Drawing.Point(10, 54);
            this.cekPazartesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekPazartesi.Name = "cekPazartesi";
            this.cekPazartesi.Size = new System.Drawing.Size(89, 23);
            this.cekPazartesi.TabIndex = 1;
            this.cekPazartesi.Text = "Pazartesi";
            this.cekPazartesi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışma günlerinizi aşağıdan seçiniz:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dudguncellemesure);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dudRAralık);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(11, 157);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(641, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dudguncellemesure
            // 
            this.dudguncellemesure.Location = new System.Drawing.Point(459, 71);
            this.dudguncellemesure.Name = "dudguncellemesure";
            this.dudguncellemesure.Size = new System.Drawing.Size(67, 27);
            this.dudguncellemesure.TabIndex = 6;
            this.dudguncellemesure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(532, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "dakikada bir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ağ üzerinden kullanım için otomatik güncelleme süresi her\r\n";
            // 
            // dudRAralık
            // 
            this.dudRAralık.Location = new System.Drawing.Point(142, 14);
            this.dudRAralık.Name = "dudRAralık";
            this.dudRAralık.Size = new System.Drawing.Size(120, 27);
            this.dudRAralık.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Randevu Aralığı:\r\n";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(448, 307);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(99, 33);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(553, 307);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(99, 33);
            this.btniptal.TabIndex = 3;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // frm_genelayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 347);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_genelayarlar";
            this.Text = "Genel Ayarlar";
            this.Load += new System.EventHandler(this.frm_genelayarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dudguncellemesure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudRAralık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown dudBitis;
        private System.Windows.Forms.DomainUpDown dudBaslangic;
        private System.Windows.Forms.CheckBox cekCalısmaSaatleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cekPazar;
        private System.Windows.Forms.CheckBox cekCumartesi;
        private System.Windows.Forms.CheckBox cekCuma;
        private System.Windows.Forms.CheckBox cekPersembe;
        private System.Windows.Forms.CheckBox cekCarsamba;
        private System.Windows.Forms.CheckBox cekSali;
        private System.Windows.Forms.CheckBox cekPazartesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dudRAralık;
        private System.Windows.Forms.NumericUpDown dudguncellemesure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btniptal;
    }
}