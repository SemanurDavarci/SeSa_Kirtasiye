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
    public partial class Kategoriler : Form
    {
        private MySqlConnectionManager dbConnector;
        public Kategoriler()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            LoadData();
            ChangeStyle();
        }
        private void LoadData()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_KategoriDetay", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            kategorilerGridView.DataSource = dataTable;
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
        }

        private void kategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle yeniForm = new KategoriEkle();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();
            yeniForm.FormClosed += YeniFormKapandi;
        }
        private void YeniFormKapandi(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void kategoriDuzenle_Click(object sender, EventArgs e)
        {
            int id = getID();
            if (id == -1)
            {

            }
            else
            {
                KategoriDuzenle yeniForm = new KategoriDuzenle(id);
                yeniForm.StartPosition = FormStartPosition.CenterScreen;
                yeniForm.Show();
                yeniForm.FormClosed += YeniFormKapandi;
            }
            
        }
        private int getID()
        {
            // DataGridView'de en az bir satır seçili mi diye kontrol edin
            if (kategorilerGridView.SelectedRows.Count > 0)
            {
                string deger = "";
                foreach (DataGridViewRow row in kategorilerGridView.SelectedRows)
                {
                    deger = row.Cells["KategoriID"].Value.ToString();

                }
                return Int32.Parse(deger);
            }
            else
            {
                MessageBox.Show("Lütfen en az bir satır seçin.");
                return -1;
            }
        }

        private void kategoriSil_Click(object sender, EventArgs e)
        {
            int id = getID();
            if(id == -1)
            {

            }
            else
            {
                KategoriSil(id);
                LoadData();
            }
        }
        private void KategoriSil(int id)
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_KategoriSil", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    
                    cmd.Parameters.AddWithValue("@p_KategoriID", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori başarıyla silindi.");
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
        }

        private void kategoriAra_Click(object sender, EventArgs e)
        {
            KategoriBul();
        }

        private void KategoriBul()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_KategoriBul", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@filtre", aranacakKategori.Text);

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            kategorilerGridView.DataSource = dataTable;
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
        }

        private void ChangeStyle()
        {

            ChangeAltButtonStyle(kategoriAra);
            ChangeAltButtonStyle(kategoriSil);
            ChangeAltButtonStyle(kategoriEkle);
            ChangeAltButtonStyle(kategoriDuzenle);
        }

        private void ChangeAltButtonStyle(Button button)
        {

            button.BackColor = Color.LightBlue;
            button.Font = new Font("Arial", 8);

        }
    }
}
