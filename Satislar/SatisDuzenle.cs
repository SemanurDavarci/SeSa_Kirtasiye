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
    public partial class SatisDuzenle : Form
    {
        private MySqlConnectionManager dbConnector;
        int id = 0;
        int urunID;
        int secilenUrunID;
        int musteriID;
        int secilenMusteriID;
        public SatisDuzenle(int satisID)
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
            this.id = satisID;
        }

        private void SatisDuzenle_Load(object sender, EventArgs e)
        {
            BilgileriGetir();
            UrunAdiGetir(urunID);
            MusteriAdiGetir(musteriID);
            UrunFiyatiGetir(urunID);
            ChangeStyle();
        }
        private void BilgileriGetir()
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT MusteriID, UrunID, SatisTarihi, SatisFiyati, SatisAdeti FROM sesa_satislar WHERE SatisID = @satisID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@satisID", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                musteriID = Convert.ToInt32(reader["MusteriID"]);
                                urunID = Convert.ToInt32(reader["UrunID"]);
                                tarihPicker.Value = Convert.ToDateTime(reader["SatisTarihi"]);
                                satisFiyatiTextBox.Text = reader["SatisFiyati"].ToString();
                                satisAdetiTextBox.Text = reader["SatisAdeti"].ToString();
                            }
                            else
                            {

                                MessageBox.Show("Belirtilen UrunID ile ilgili veri bulunamadı.");
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
        private void UrunAdiGetir(int urunID)
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT UrunAdi FROM sesa_urunler WHERE UrunID = @urunID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@urunID", urunID);


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

        private void satisYapTamam_Click(object sender, EventArgs e)
        {
            Duzenle();
            this.Close();
        }
        private void Duzenle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_SatisGuncelle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_SatisID", id);
                    cmd.Parameters.AddWithValue("p_MusteriID", secilenMusteriID);
                    cmd.Parameters.AddWithValue("p_UrunID", secilenUrunID);
                    cmd.Parameters.AddWithValue("p_SatisTarihi", tarihPicker.Value);
                    cmd.Parameters.AddWithValue("p_SatisFiyati", satisFiyatiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_SatisAdeti", satisAdetiTextBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Satış başarıyla düzenlendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void satisDuzenleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(satisDuzenleIptal);
            ChangeTamamButtonStyle(satisDuzenleTamam);
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
