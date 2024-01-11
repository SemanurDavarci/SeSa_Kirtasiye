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
    public partial class MusteriEkle : Form
    {
        private MySqlConnectionManager dbConnector;
        public MusteriEkle()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void musteriEkleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void musteriEkleTamam_Click(object sender, EventArgs e)
        {
            Ekle();
            this.Close();
        }
        private void Ekle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_MusteriEkle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("p_Adi", adiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Soyadi", soyadiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Telefon", telefonTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Mail", mailTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Adres", adresTextBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla eklendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            ChangeStyle();
        }
        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(musteriEkleIptal);
            ChangeTamamButtonStyle(musteriEkleTamam);
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
