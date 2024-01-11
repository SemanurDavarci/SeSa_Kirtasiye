using MySql.Data.MySqlClient;
using SeSa_Kırtasiye_Semanur_Davarcı;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeSa_Kirtasiye
{
    public partial class SatısYap : Form
    {
        int secilenMusteriID;
        int secilenUrunID;
        private MySqlConnectionManager dbConnector;
        public SatısYap()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void musteriSec_Click(object sender, EventArgs e)
        {
            MusteriSec yeniForm = new MusteriSec();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.FormClosed += (s, args) =>
            {

                secilenMusteriID = yeniForm.SecilenMusteriID;
                MusteriAdiGetir(secilenMusteriID);
            };

            yeniForm.Show();
        }
        private void MusteriAdiGetir(int musteriID)
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT MusteriAdi FROM sesa_musteriler WHERE MusteriID = @MusteriID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string musteriAdi = reader["MusteriAdi"].ToString();
                                musteriAdiTextBox.Text = musteriAdi;
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

        private void urunSec_Click(object sender, EventArgs e)
        {
            UrunSec yeniForm = new UrunSec();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.FormClosed += (s, args) =>
            {

                secilenUrunID = yeniForm.SecilenUrunID;
                UrunAdiGetir(secilenUrunID);
                UrunFiyatiGetir(secilenUrunID);
            };
            

            yeniForm.Show();

        }
        private void UrunAdiGetir(int urunID)
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT UrunAdi FROM sesa_urunler WHERE UrunID = @UrunID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string urunAdi = reader["UrunAdi"].ToString();
                                urunAdiTextBox.Text = urunAdi;
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

        private void UrunFiyatiGetir(int urunID)
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT UrunBirimFiyat FROM sesa_urunler WHERE UrunID = @UrunID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string birimFiyat = reader["UrunBirimFiyat"].ToString();
                                adetFiyatiTextBox.Text = birimFiyat;
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

        private void SatısYap_Load(object sender, EventArgs e)
        {
            ChangeStyle();
        }
        private void satisAdetiTextBox_TextChanged(object sender, EventArgs e)
        {
        
            if (!string.IsNullOrEmpty(satisAdetiTextBox.Text) && int.TryParse(satisAdetiTextBox.Text, out int sayi))
            {
                int carpim = sayi * Int32.Parse(adetFiyatiTextBox.Text);
                satisFiyatiTextBox.Text = carpim.ToString(); 
            }
            else
            {
                satisFiyatiTextBox.Text = ""; 
            }
        }

        private void satisFiyatiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void satisYapTamam_Click(object sender, EventArgs e)
        {
            Ekle();
            this.Close();
        }

        private void Ekle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_SatisEkle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("p_MusteriID", secilenMusteriID);
                    cmd.Parameters.AddWithValue("p_UrunID", secilenUrunID);
                    cmd.Parameters.AddWithValue("p_SatisTarihi", tarihPicker.Value);
                    cmd.Parameters.AddWithValue("p_SatisFiyati", satisFiyatiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_SatisAdeti", satisAdetiTextBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Satış başarıyla eklendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void satisYapIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(satisYapIptal);
            ChangeTamamButtonStyle(satisYapTamam);
        }
     
        private void ChangeTamamButtonStyle(System.Windows.Forms.Button button)
        {

            button.BackColor = Color.LightGreen;
            button.Font = new Font("Arial", 8);

        }
        private void ChangeIptalButtonStyle(System.Windows.Forms.Button button)
        {

            button.BackColor = Color.OrangeRed;
            button.Font = new Font("Arial", 8);

        }
    }
}
