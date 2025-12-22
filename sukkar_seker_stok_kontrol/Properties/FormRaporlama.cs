using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; // Gerekliyse kalsın, iTextSharp için doğrudan kullanılmıyor
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text; // PDF dokümanı oluşturmak için
using iTextSharp.text.pdf; // PDF tablo ve yazıcı için

namespace sukkar_seker_stok_kontrol
{
    public partial class FormRaporlama : Form
    {
        public FormRaporlama()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;           
            this.Size = new Size(816, 493);
        }

        private void FormRaporlama_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KERIMROG\\SQLEXPRESS;Initial Catalog=seker_fabrikasi_db;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT islem_tarihi AS 'İşlem Tarihi', " +
                                   "gelen_pancar AS 'Gelen Pancar (ton)', " +
                                   "uretilen_seker AS 'Üretilen Şeker (ton)', " +
                                   "uretilen_melas AS 'Üretilen Melas (ton)', " +
                                   "uretilen_kuspe AS 'Üretilen Küspe (ton)' " +
                                   "FROM gunluk_rapor ORDER BY islem_tarihi DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dgvGunlukRaporlar.DataSource = dataTable;
                    dgvGunlukRaporlar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvGunlukRaporlar.Dock = DockStyle.None; // DataGridView'i formun tamamına yay (butonsuz kısım)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Raporlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dgvGunlukRaporlar.Rows.Count == 0)
            {
                MessageBox.Show("PDF'e dönüştürülecek veri bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";
            saveFileDialog.Title = "Raporu PDF Olarak Kaydet";
            saveFileDialog.FileName = "Gunluk_Uretim_Raporu.pdf"; 

          
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    Document doc = new Document(PageSize.A4);
                    
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    doc.Open(); 

                    // Başlık ekle
                    doc.Add(new Paragraph("Şeker Fabrikası Günlük Üretim Raporu\n\n"));

                    
                    PdfPTable pdfTable = new PdfPTable(dgvGunlukRaporlar.ColumnCount);
                    pdfTable.DefaultCell.Padding = 3; 
                    pdfTable.WidthPercentage = 100; 

                    // Sütun başlıklarını ekle
                    foreach (DataGridViewColumn column in dgvGunlukRaporlar.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY; 
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dgvGunlukRaporlar.Rows)
                    {
                        
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(new Phrase(cell.Value != null ? cell.Value.ToString() : ""));
                        }
                    }

                    doc.Add(pdfTable);
                    doc.Close(); 

                    MessageBox.Show("Rapor başarıyla PDF olarak kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void gerigel_btn_Click(object sender, EventArgs e) 
        {
            this.Close(); // FormRaporlama'yı kapatır ve Form1'e kontrolü geri verir.
        }
    }
}