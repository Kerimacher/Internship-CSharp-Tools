namespace sukkar_seker_stok_kontrol
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
            this.txtPancarMiktari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnRaporlamayaGit = new System.Windows.Forms.Button();
            this.lblSeker = new System.Windows.Forms.Label();
            this.lblUretilenSeker = new System.Windows.Forms.Label();
            this.lblMelas = new System.Windows.Forms.Label();
            this.lblUretilenMelas = new System.Windows.Forms.Label();
            this.lblKuspe = new System.Windows.Forms.Label();
            this.lblUretilenKuspe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPancarMiktari
            // 
            this.txtPancarMiktari.Location = new System.Drawing.Point(177, 183);
            this.txtPancarMiktari.Name = "txtPancarMiktari";
            this.txtPancarMiktari.Size = new System.Drawing.Size(164, 22);
            this.txtPancarMiktari.TabIndex = 0;
            this.txtPancarMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPancarMiktari_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gelen Pancar Miktarı:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(346, 302);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(106, 58);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnRaporlamayaGit
            // 
            this.btnRaporlamayaGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlamayaGit.Location = new System.Drawing.Point(675, 380);
            this.btnRaporlamayaGit.Name = "btnRaporlamayaGit";
            this.btnRaporlamayaGit.Size = new System.Drawing.Size(113, 58);
            this.btnRaporlamayaGit.TabIndex = 3;
            this.btnRaporlamayaGit.Text = "Raporlamaya Git";
            this.btnRaporlamayaGit.UseVisualStyleBackColor = true;
            this.btnRaporlamayaGit.Click += new System.EventHandler(this.btnRaporlamayaGit_Click);
            // 
            // lblSeker
            // 
            this.lblSeker.AutoSize = true;
            this.lblSeker.Location = new System.Drawing.Point(441, 68);
            this.lblSeker.Name = "lblSeker";
            this.lblSeker.Size = new System.Drawing.Size(137, 16);
            this.lblSeker.TabIndex = 4;
            this.lblSeker.Text = "Üretilen Şeker Miktarı:";
            // 
            // lblUretilenSeker
            // 
            this.lblUretilenSeker.AutoSize = true;
            this.lblUretilenSeker.Location = new System.Drawing.Point(587, 68);
            this.lblUretilenSeker.Name = "lblUretilenSeker";
            this.lblUretilenSeker.Size = new System.Drawing.Size(0, 16);
            this.lblUretilenSeker.TabIndex = 5;
            // 
            // lblMelas
            // 
            this.lblMelas.AutoSize = true;
            this.lblMelas.Location = new System.Drawing.Point(441, 103);
            this.lblMelas.Name = "lblMelas";
            this.lblMelas.Size = new System.Drawing.Size(138, 16);
            this.lblMelas.TabIndex = 6;
            this.lblMelas.Text = "Üretilen Melas Miktarı:";
            // 
            // lblUretilenMelas
            // 
            this.lblUretilenMelas.AutoSize = true;
            this.lblUretilenMelas.Location = new System.Drawing.Point(587, 103);
            this.lblUretilenMelas.Name = "lblUretilenMelas";
            this.lblUretilenMelas.Size = new System.Drawing.Size(0, 16);
            this.lblUretilenMelas.TabIndex = 7;
            // 
            // lblKuspe
            // 
            this.lblKuspe.AutoSize = true;
            this.lblKuspe.Location = new System.Drawing.Point(441, 137);
            this.lblKuspe.Name = "lblKuspe";
            this.lblKuspe.Size = new System.Drawing.Size(139, 16);
            this.lblKuspe.TabIndex = 8;
            this.lblKuspe.Text = "Üretilen Küspe Miktarı:";
            // 
            // lblUretilenKuspe
            // 
            this.lblUretilenKuspe.AutoSize = true;
            this.lblUretilenKuspe.Location = new System.Drawing.Point(587, 137);
            this.lblUretilenKuspe.Name = "lblUretilenKuspe";
            this.lblUretilenKuspe.Size = new System.Drawing.Size(0, 16);
            this.lblUretilenKuspe.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "SUKKAR STOK TAKİP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUretilenKuspe);
            this.Controls.Add(this.lblKuspe);
            this.Controls.Add(this.lblUretilenMelas);
            this.Controls.Add(this.lblMelas);
            this.Controls.Add(this.lblUretilenSeker);
            this.Controls.Add(this.lblSeker);
            this.Controls.Add(this.btnRaporlamayaGit);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPancarMiktari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stok Takip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPancarMiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnRaporlamayaGit;
        private System.Windows.Forms.Label lblSeker;
        private System.Windows.Forms.Label lblUretilenSeker;
        private System.Windows.Forms.Label lblMelas;
        private System.Windows.Forms.Label lblUretilenMelas;
        private System.Windows.Forms.Label lblKuspe;
        private System.Windows.Forms.Label lblUretilenKuspe;
        private System.Windows.Forms.Label label2;
    }
}

