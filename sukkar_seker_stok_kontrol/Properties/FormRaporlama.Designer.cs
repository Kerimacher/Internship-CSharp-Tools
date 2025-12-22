namespace sukkar_seker_stok_kontrol
{
    partial class FormRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaporlama));
            this.dgvGunlukRaporlar = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gerigel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGunlukRaporlar
            // 
            this.dgvGunlukRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGunlukRaporlar.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGunlukRaporlar.Location = new System.Drawing.Point(0, 142);
            this.dgvGunlukRaporlar.Name = "dgvGunlukRaporlar";
            this.dgvGunlukRaporlar.RowHeadersWidth = 51;
            this.dgvGunlukRaporlar.RowTemplate.Height = 24;
            this.dgvGunlukRaporlar.Size = new System.Drawing.Size(800, 308);
            this.dgvGunlukRaporlar.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(345, 51);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 45);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gerigel_btn
            // 
            this.gerigel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gerigel_btn.Location = new System.Drawing.Point(13, 13);
            this.gerigel_btn.Name = "gerigel_btn";
            this.gerigel_btn.Size = new System.Drawing.Size(83, 36);
            this.gerigel_btn.TabIndex = 2;
            this.gerigel_btn.Text = "Geri Gel";
            this.gerigel_btn.UseVisualStyleBackColor = true;
            this.gerigel_btn.Click += new System.EventHandler(this.gerigel_btn_Click);
            // 
            // FormRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 446);
            this.Controls.Add(this.gerigel_btn);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvGunlukRaporlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRaporlama";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FormRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukRaporlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGunlukRaporlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button gerigel_btn;
    }
}