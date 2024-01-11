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

namespace SeSa_Kirtasiye
{
    public partial class OdemeDuzenle : Form
    {
        private MySqlConnectionManager dbConnector;
        int id = 0;
        int musteriID;
        int secilenMusteriID;
        public OdemeDuzenle(int odemeID)
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
            this.id = odemeID;
        }

        private void OdemeDuzenle_Load(object sender, EventArgs e)
        {
            BilgileriGetir();
            MusteriAdiGetir(musteriID);
            ChangeStyle();
        }
        private void BilgileriGetir()
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT MusteriID, OdemeTarihi, OdemeTutari, OdemeTuru, Aciklama FROM sesa_odemeler WHERE OdemeID = @odemeID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@odemeID", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                musteriID = Convert.ToInt32(reader["MusteriID"]);
                                secilenMusteriID = musteriID;
                                tarihPicker.Value = Convert.ToDateTime(reader["OdemeTarihi"]);
                                odemeTutariTextBox.Text = reader["OdemeTutari"].ToString();
                                odemeTuruTextBox.Text = reader["OdemeTuru"].ToString();
                                aciklamaTextBox.Text = reader["Aciklama"].ToString();
                            }
                            else
                            {

                                MessageBox.Show("Belirtilen OdemeID ile ilgili veri bulunamadı.");
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

        private void odemeDuzenleTamam_Click(object sender, EventArgs e)
        {
            Duzenle();
            this.Close();
        }
        private void Duzenle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_OdemeGuncelle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_OdemeID", id);
                    cmd.Parameters.AddWithValue("p_MusteriID", secilenMusteriID);
                    cmd.Parameters.AddWithValue("p_OdemeTutari", odemeTutariTextBox.Text);
                    cmd.Parameters.AddWithValue("p_OdemeTarihi", tarihPicker.Value);
                    cmd.Parameters.AddWithValue("p_OdemeTuru", odemeTuruTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Aciklama", aciklamaTextBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla düzenlendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void odemeDuzenleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(odemeDuzenleIptal);
            ChangeTamamButtonStyle(odemeDuzenleTamam);
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
