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
    public partial class KategoriDuzenle : Form
    {
        private MySqlConnectionManager dbConnector;
        int id = 0;
        public KategoriDuzenle(int id)
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
            this.id = id;
        }

        private void KategoriDuzenle_Load(object sender, EventArgs e)
        {
            BilgileriGetir();
            ChangeStyle();
        }

        private void BilgileriGetir()
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT KategoriAdi FROM sesa_kategoriler WHERE KategoriID = @KategoriID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@KategoriID", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                kategoriAdiTextBox.Text = reader["KategoriAdi"].ToString();
  
                            }
                            else
                            {

                                MessageBox.Show("Belirtilen KategoriID ile ilgili veri bulunamadı.");
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
        }

        private void kategoriDuzenleTamam_Click(object sender, EventArgs e)
        {
            Duzenle();
            this.Close();
        }

        private void Duzenle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_KategoriGuncelle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("p_KategoriID", id);
                    cmd.Parameters.AddWithValue("p_YeniKategoriAdi", kategoriAdiTextBox.Text);
               

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori başarıyla güncellendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void kategoriDuzenleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(kategoriDuzenleIptal);
            ChangeTamamButtonStyle(kategoriDuzenleTamam);
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
