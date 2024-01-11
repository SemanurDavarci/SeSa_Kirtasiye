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
    public partial class MusteriDuzenle : Form
    {
        int id = 0;
        private MySqlConnectionManager dbConnector;
        public MusteriDuzenle(int id)
        {
            InitializeComponent();
            this.id = id;
            dbConnector = new MySqlConnectionManager();
        }

        private void MusteriDuzenle_Load(object sender, EventArgs e)
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT MusteriAdi, MusteriSoyadi, MusteriTelefon, MusteriMail, MusteriAdres FROM sesa_musteriler WHERE MusteriID = @MusteriID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                adiTextBox.Text = reader["MusteriAdi"].ToString();
                                soyadiTextBox.Text = reader["MusteriSoyadi"].ToString();
                                telefonTextBox.Text = reader["MusteriTelefon"].ToString();
                                mailTextBox.Text = reader["MusteriMail"].ToString();
                                adresTextBox.Text = reader["MusteriAdres"].ToString();
                            }
                            else
                            {
                               
                                MessageBox.Show("Belirtilen MusteriID ile ilgili veri bulunamadı.");
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

        private void musteriEkleTamam_Click(object sender, EventArgs e)
        {
            Duzenle();
            
            this.Close();
        }

        private void Duzenle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_MusteriGuncelle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("p_MusteriID", id);
                    cmd.Parameters.AddWithValue("p_Adi", adiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Soyadi", soyadiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Telefon", telefonTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Mail", mailTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Adres", adresTextBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla güncellendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void musteriEkleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(musteriDuzenleIptal);
            ChangeTamamButtonStyle(musteriDuzenleTamam);
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
