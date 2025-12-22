using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace sukkar_arıza_takip
{
    public partial class Form1 : Form
    {
        // Bağlantı dizesini bir kez tanımla (Gereksiz tekrarı önle)
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArızaEkle_Click(object sender, EventArgs e)
        {
            // ***** BOŞ ALAN KONTROLLERİ *****
            if (string.IsNullOrWhiteSpace(txtMakineAdi.Text) || string.IsNullOrWhiteSpace(txtArizaAciklamasi.Text))
            {
                MessageBox.Show("Makine Adı ve Açıklama alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // İlk boş alana odaklanma eklenebilir
                return;
            }

            if (cmbOnarımDurumu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Onarım Durumu seçimi yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbOnarımDurumu.Focus();
                return;
            }
            // *********************************

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Arızalar (MakineAdi, ArızaTarihi, ArızaAçıklaması, OnarımDurumu) VALUES (@MakineAdi, @ArızaTarihi, @ArızaAçıklaması, @OnarımDurumu)";

                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        // Trim() kullanarak baştaki/sondaki boşlukları temizle
                        komut.Parameters.AddWithValue("@MakineAdi", txtMakineAdi.Text.Trim());
                        komut.Parameters.AddWithValue("@ArızaTarihi", dtpArızaTarihi.Value);
                        komut.Parameters.AddWithValue("@ArızaAçıklaması", txtArizaAciklamasi.Text.Trim());

                        // Null kontrolünden geçtiği için güvenli bir şekilde ToString() çağırabiliriz
                        komut.Parameters.AddWithValue("@OnarımDurumu", cmbOnarımDurumu.SelectedItem.ToString());

                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Arıza kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Alanları temizle
                        txtMakineAdi.Clear();
                        txtArizaAciklamasi.Clear();
                        dtpArızaTarihi.Value = DateTime.Now;
                        cmbOnarımDurumu.SelectedIndex = -1;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı Hatası oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Genel Bir Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArızalariListele_Click(object sender, EventArgs e)
        {
            Form2 arızaListesiFormu = new Form2();
            arızaListesiFormu.Show();

            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istediğinizden emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}