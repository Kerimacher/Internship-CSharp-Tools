using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sukkar_arıza_takip
{
    public partial class Form2 : Form
    {
        // Bağlantı dizesini bir kere tanımla
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        public Form2()
        {
            InitializeComponent();
            // DataGridView için olayları burada bağlayabiliriz (örneğin CellFormatting)
            dgvArızalar.CellFormatting += dgvArızalar_CellFormatting;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VerileriListele();
        }

        // Metot, gelecekte filtreleme yapmak için parametre alabilir
        private void VerileriListele(string filtreDurumu = "TÜMÜ")
        {
            // Filtreleme sorgusunu dinamik hale getirelim
            string query = "SELECT ArızaID, MakineAdi, ArızaTarihi, ArızaAçıklaması, OnarımDurumu FROM Arızalar";

            // Eğer filtreleme isteniyorsa sorguyu değiştir
            if (filtreDurumu != "TÜMÜ")
            {
                // Parametreli sorgu kullanarak SQL Enjeksiyonunu önleyin
                query += " WHERE OnarımDurumu = @Durum";
            }

            // Tarihe göre sıralama (En son arızalar üstte)
            query += " ORDER BY ArızaTarihi DESC";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                using (SqlCommand komut = new SqlCommand(query, baglanti)) // SqlCommand eklendi
                {
                    // Filtreleme parametresini ekle (varsa)
                    if (filtreDurumu != "TÜMÜ")
                    {
                        komut.Parameters.AddWithValue("@Durum", filtreDurumu);
                    }

                    baglanti.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(komut))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // DataGridView kontrol adını dgvArızalar varsayarak:
                        dgvArızalar.DataSource = dt;

                        // İsteğe bağlı: Başlıkları daha okunur hale getir (Opsiyonel)
                        dgvArızalar.Columns["ArızaID"].HeaderText = "ID";
                        dgvArızalar.Columns["ArızaAçıklaması"].Width = 250;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı bağlantısında veya sorguda hata: " + ex.Message, "SQL Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri listeleme sırasında genel bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Koşullu Biçimlendirme için Olay Metodu
        private void dgvArızalar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // "OnarımDurumu" kolonu 4. sütun (0'dan başlıyor) veya kolon adına göre kontrol edilmeli.
            // Kolon adına göre kontrol daha güvenlidir:
            if (dgvArızalar.Columns[e.ColumnIndex].Name == "OnarımDurumu")
            {
                string durum = e.Value?.ToString();

                if (durum == "Beklemede") // Varsayılan durumunuzu kontrol edin
                {
                    // Satırı veya hücreyi kırmızı yap
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (durum == "Tamamlandı")
                {
                    // Satırı veya hücreyi yeşil yap
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btn_geriDön_Click(object sender, EventArgs e)
        {
            // Var olan Form1'i göstermek daha iyi, ancak bu şekilde de çalışır.
            // Yeni bir Form1 oluşturup eskisini kapatmak yerine, 
            // Form1'in kendisini referans olarak alıp onu Show() yapmak daha iyidir. 
            // Fakat mevcut yapıyı bozmadan:
            Form1 anaForm = new Form1();
            anaForm.Show();

            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istediğinizden emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}