namespace sukkar_arıza_takip
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvArızalar = new System.Windows.Forms.DataGridView();
            this.btn_geriDön = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArızalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArızalar
            // 
            this.dgvArızalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArızalar.Location = new System.Drawing.Point(99, 58);
            this.dgvArızalar.Name = "dgvArızalar";
            this.dgvArızalar.RowHeadersWidth = 51;
            this.dgvArızalar.RowTemplate.Height = 24;
            this.dgvArızalar.Size = new System.Drawing.Size(601, 294);
            this.dgvArızalar.TabIndex = 0;
            // 
            // btn_geriDön
            // 
            this.btn_geriDön.Location = new System.Drawing.Point(704, 389);
            this.btn_geriDön.Name = "btn_geriDön";
            this.btn_geriDön.Size = new System.Drawing.Size(75, 44);
            this.btn_geriDön.TabIndex = 1;
            this.btn_geriDön.Text = "Geri Dön";
            this.btn_geriDön.UseVisualStyleBackColor = true;
            this.btn_geriDön.Click += new System.EventHandler(this.btn_geriDön_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_geriDön);
            this.Controls.Add(this.dgvArızalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Arıza Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArızalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArızalar;
        private System.Windows.Forms.Button btn_geriDön;
    }
}