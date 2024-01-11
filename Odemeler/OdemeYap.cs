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
    public partial class OdemeYap : Form
    {
        int secilenMusteriID;
        private MySqlConnectionManager dbConnector;

        public OdemeYap()
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

        private void odemeYapIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void odemeYapTamam_Click(object sender, EventArgs e)
        {
            Ekle();
            this.Close();
        }
        private void Ekle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_OdemeEkle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

    
                    cmd.Parameters.AddWithValue("p_MusteriID", secilenMusteriID);
                    cmd.Parameters.AddWithValue("p_OdemeTarihi", tarihPicker.Value);
                    cmd.Parameters.AddWithValue("p_OdemeTutari", odemeTutariTextBox.Text);
                    cmd.Parameters.AddWithValue("p_OdemeTuru", odemeTuruTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Aciklama", aciklamaTextBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ödeme başarıyla eklendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void OdemeYap_Load(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(odemeYapIptal);
            ChangeTamamButtonStyle(odemeYapTamam);
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
