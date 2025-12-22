namespace sukkar_arıza_takip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMakineAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArizaAciklamasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOnarımDurumu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpArızaTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnArızaEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnArızalariListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMakineAdi
            // 
            this.txtMakineAdi.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtMakineAdi.Location = new System.Drawing.Point(160, 68);
            this.txtMakineAdi.Name = "txtMakineAdi";
            this.txtMakineAdi.Size = new System.Drawing.Size(133, 22);
            this.txtMakineAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Makina Adı";
            // 
            // txtArizaAciklamasi
            // 
            this.txtArizaAciklamasi.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtArizaAciklamasi.Location = new System.Drawing.Point(159, 128);
            this.txtArizaAciklamasi.Name = "txtArizaAciklamasi";
            this.txtArizaAciklamasi.Size = new System.Drawing.Size(296, 22);
            this.txtArizaAciklamasi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arıza Açıklaması";
            // 
            // cmbOnarımDurumu
            // 
            this.cmbOnarımDurumu.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbOnarımDurumu.FormattingEnabled = true;
            this.cmbOnarımDurumu.Items.AddRange(new object[] {
            "\"Beklemede\"",
            "\"Devam Ediyor\"",
            "\"Tamamlandı\""});
            this.cmbOnarımDurumu.Location = new System.Drawing.Point(32, 239);
            this.cmbOnarımDurumu.Name = "cmbOnarımDurumu";
            this.cmbOnarımDurumu.Size = new System.Drawing.Size(121, 24);
            this.cmbOnarımDurumu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Onarım Durumu";
            // 
            // dtpArızaTarihi
            // 
            this.dtpArızaTarihi.CalendarForeColor = System.Drawing.Color.SeaGreen;
            this.dtpArızaTarihi.CalendarMonthBackground = System.Drawing.Color.SeaGreen;
            this.dtpArızaTarihi.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dtpArızaTarihi.CalendarTitleForeColor = System.Drawing.Color.SeaGreen;
            this.dtpArızaTarihi.CalendarTrailingForeColor = System.Drawing.Color.SeaGreen;
            this.dtpArızaTarihi.Location = new System.Drawing.Point(530, 128);
            this.dtpArızaTarihi.Name = "dtpArızaTarihi";
            this.dtpArızaTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpArızaTarihi.TabIndex = 6;
            // 
            // btnArızaEkle
            // 
            this.btnArızaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArızaEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnArızaEkle.Location = new System.Drawing.Point(227, 335);
            this.btnArızaEkle.Name = "btnArızaEkle";
            this.btnArızaEkle.Size = new System.Drawing.Size(135, 42);
            this.btnArızaEkle.TabIndex = 7;
            this.btnArızaEkle.Text = "Arıza Ekle";
            this.btnArızaEkle.UseVisualStyleBackColor = true;
            this.btnArızaEkle.Click += new System.EventHandler(this.btnArızaEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGüncelle.Location = new System.Drawing.Point(427, 335);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(142, 42);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnArızalariListele
            // 
            this.btnArızalariListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArızalariListele.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnArızalariListele.Location = new System.Drawing.Point(658, 400);
            this.btnArızalariListele.Name = "btnArızalariListele";
            this.btnArızalariListele.Size = new System.Drawing.Size(118, 29);
            this.btnArızalariListele.TabIndex = 9;
            this.btnArızalariListele.Text = "Listeye Git";
            this.btnArızalariListele.UseVisualStyleBackColor = true;
            this.btnArızalariListele.Click += new System.EventHandler(this.btnArızalariListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArızalariListele);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnArızaEkle);
            this.Controls.Add(this.dtpArızaTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOnarımDurumu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArizaAciklamasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMakineAdi);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMakineAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArizaAciklamasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOnarımDurumu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpArızaTarihi;
        private System.Windows.Forms.Button btnArızaEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnArızalariListele;
    }
}

