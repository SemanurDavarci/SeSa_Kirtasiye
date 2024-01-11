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
    public partial class KategoriEkle : Form
    {
        private MySqlConnectionManager dbConnector;
        public KategoriEkle()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void kategoriEkleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kategoriEkleTamam_Click(object sender, EventArgs e)
        {
            Ekle();
            this.Close();

        }

        private void Ekle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_KategoriEkle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("p_KategoriAdi", kategoriAdiTextBox.Text);


                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori başarıyla eklendi.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            ChangeStyle();
        }
        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(kategoriEkleIptal);
            ChangeTamamButtonStyle(kategoriEkleTamam);
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
