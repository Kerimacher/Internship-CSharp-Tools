using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace sukkar_seker_stok_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPancarMiktari.Text))
            {
                MessageBox.Show("Lütfen bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal gelenPancar = 0;
            if (!decimal.TryParse(txtPancarMiktari.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out gelenPancar))
            {
                MessageBox.Show("Geçerli bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal uretilenSeker = gelenPancar * 0.13m;
            decimal uretilenMelas = gelenPancar * 0.02m;
            decimal uretilenKuspe = gelenPancar * 0.50m;

            string connectionString = "Data Source=KERIMROG\\SQLEXPRESS;Initial Catalog=seker_fabrikasi_db;Integrated Security=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                string updateAnaStokQuery = "UPDATE ana_stok SET mevcut_stok = mevcut_stok + @miktar WHERE malzeme_adi = @malzeme";
                string insertGunlukRaporQuery = "INSERT INTO gunluk_rapor (islem_tarihi, gelen_pancar, uretilen_seker, uretilen_melas, uretilen_kuspe) VALUES (GETDATE(), @gelenPancar, @uretilenSeker, @uretilenMelas, @uretilenKuspe)";

                using (SqlCommand cmd = new SqlCommand(updateAnaStokQuery, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@miktar", gelenPancar);
                    cmd.Parameters.AddWithValue("@malzeme", "Şeker Pancarı");
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@miktar", uretilenSeker);
                    cmd.Parameters.AddWithValue("@malzeme", "Kristal Toz Şeker");
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@miktar", uretilenMelas);
                    cmd.Parameters.AddWithValue("@malzeme", "Melas");
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@miktar", uretilenKuspe);
                    cmd.Parameters.AddWithValue("@malzeme", "Yaş Küspe");
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand(insertGunlukRaporQuery, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@gelenPancar", gelenPancar);
                    cmd.Parameters.AddWithValue("@uretilenSeker", uretilenSeker);
                    cmd.Parameters.AddWithValue("@uretilenMelas", uretilenMelas);
                    cmd.Parameters.AddWithValue("@uretilenKuspe", uretilenKuspe);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Stoklar başarıyla güncellendi ve rapor kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblUretilenSeker.Text = uretilenSeker.ToString("N2", CultureInfo.CurrentCulture) + " ton";
                lblUretilenMelas.Text = uretilenMelas.ToString("N2", CultureInfo.CurrentCulture) + " ton";
                lblUretilenKuspe.Text = uretilenKuspe.ToString("N2", CultureInfo.CurrentCulture) + " ton";

                txtPancarMiktari.Clear();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void txtPancarMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparator))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == decimalSeparator) && ((sender as TextBox).Text.IndexOf(decimalSeparator) > -1))
            {
                e.Handled = true;
            }
        }

        private void btnRaporlamayaGit_Click(object sender, EventArgs e)
        {
            FormRaporlama raporFormu = new FormRaporlama();
            raporFormu.ShowDialog();
        }

    }
}