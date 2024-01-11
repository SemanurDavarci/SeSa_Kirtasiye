using MySql.Data.MySqlClient;
using SeSa_Kırtasiye_Semanur_Davarcı;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeSa_Kirtasiye
{
    public partial class UrunEkle : Form
    {
        int secilenKategoriID;
        private MySqlConnectionManager dbConnector;
        public UrunEkle()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void urunEkleTamam_Click(object sender, EventArgs e)
        {
            Ekle();
            this.Close();
        }
        private void Ekle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_UrunEkle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("p_UrunAdi", urunAdiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_KategoriID", secilenKategoriID);
                    cmd.Parameters.AddWithValue("p_BirimFiyat", birimFiyatTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Detay", detayTextBox.Text);
                    cmd.Parameters.AddWithValue("p_StokMiktari", stokMiktariTextBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla eklendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void kategoriSec_Click(object sender, EventArgs e)
        {
            KategoriSec yeniForm = new KategoriSec();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.FormClosed += (s, args) =>
            {
                
                secilenKategoriID = yeniForm.SecilenKategoriID;
                KategoriAdiGetir(secilenKategoriID);
            };

            yeniForm.Show();
        }
        private void KategoriAdiGetir(int kategoriID)
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT KategoriAdi FROM sesa_kategoriler WHERE KategoriID = @kategoriID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@kategoriID", kategoriID);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string kategoriAdi = reader["KategoriAdi"].ToString();
                                kategoriTextBox.Text = kategoriAdi;
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    dbConnector.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı.");
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(urunEkleIptal);
            ChangeTamamButtonStyle(urunEkleTamam);
        }
        private void ChangeTamamButtonStyle(Button button)
        {

            button.BackColor = Color.LightGreen;
            button.Font = new Font("Arial", 8);

        }
        private void ChangeIptalButtonStyle(Button button)
        {

            button.BackColor = Color.OrangeRed;
            button.Font = new Font("Arial", 8);

        }
    }
}
