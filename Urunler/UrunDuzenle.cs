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
    public partial class UrunDuzenle : Form
    {
        private MySqlConnectionManager dbConnector;
        int id = 0;
        int KategoriID;
        int secilenKategoriID;
        public UrunDuzenle(int id)
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
            this.id = id;
        }

        private void UrunDuzenle_Load(object sender, EventArgs e)
        {
            BilgileriGetir();
            KategoriAdiGetir(KategoriID);
            ChangeStyle();
        }
        private void BilgileriGetir()
        {
            if (dbConnector.OpenConnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT UrunAdi, KategoriID, UrunBirimFiyat, UrunDetay, UrunStokMiktari FROM sesa_urunler WHERE UrunID = @UrunID", dbConnector.Connection))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                urunAdiTextBox.Text = reader["UrunAdi"].ToString();
                                KategoriID = Convert.ToInt32(reader["KategoriID"]);
                                secilenKategoriID = KategoriID;
                                birimFiyatTextBox.Text = reader["UrunBirimFiyat"].ToString();
                                detayTextBox.Text = reader["UrunDetay"].ToString();
                                stokMiktariTextBox.Text = reader["UrunStokMiktari"].ToString();
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

        private void urunDuzenleTamam_Click(object sender, EventArgs e)
        {
            Duzenle();
            this.Close();
        }
        private void Duzenle()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_UrunGuncelle", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_UrunID", id);
                    cmd.Parameters.AddWithValue("p_UrunAdi", urunAdiTextBox.Text);
                    cmd.Parameters.AddWithValue("p_KategoriID", secilenKategoriID);
                    cmd.Parameters.AddWithValue("p_BirimFiyat", birimFiyatTextBox.Text);
                    cmd.Parameters.AddWithValue("p_Detay", detayTextBox.Text);
                    cmd.Parameters.AddWithValue("p_StokMiktari", stokMiktariTextBox.Text);

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

        private void urunDuzenleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeStyle()
        {

            ChangeIptalButtonStyle(urunDuzenleIptal);
            ChangeTamamButtonStyle(urunDuzenleTamam);
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


