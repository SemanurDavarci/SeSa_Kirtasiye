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
    public partial class Urunler : Form
    {
        private MySqlConnectionManager dbConnector;
        public Urunler()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            LoadData();
            ChangeStyle();
        }
        private void LoadData()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_UrunDetay", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            urunlerGridView.DataSource = dataTable;
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

        private void urunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle yeniForm = new UrunEkle();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();
            yeniForm.FormClosed += YeniFormKapandi;
        }

        private void urunDuzenle_Click(object sender, EventArgs e)
        {
            int id = getID();
            if(id == -1)
            {

            }
            else
            {
                UrunDuzenle yeniForm = new UrunDuzenle(id);
                yeniForm.StartPosition = FormStartPosition.CenterScreen;
                yeniForm.Show();
                yeniForm.FormClosed += YeniFormKapandi;
            }
        }
        private void YeniFormKapandi(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }
        private int getID()
        {
            if (urunlerGridView.SelectedRows.Count > 0)
            {
                string deger = "";
                foreach (DataGridViewRow row in urunlerGridView.SelectedRows)
                {
                    deger = row.Cells["UrunID"].Value.ToString();

                }
                return Int32.Parse(deger);
            }
            else
            {
                MessageBox.Show("Lütfen en az bir satır seçin.");
                return -1;
            }
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
            int id = getID();
            if( id == -1)
            {

            }
            else
            {
                UrunSil(id);
                LoadData();
            }
        }
        private void UrunSil(int id)
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_UrunSil", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_UrunID", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla silindi.");
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

        private void urunAra_Click(object sender, EventArgs e)
        {
            UrunBul();
        }
        private void UrunBul()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_UrunBul", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@filtre", aranacakUrun.Text);

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            urunlerGridView.DataSource = dataTable;
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

            ChangeAltButtonStyle(urunAra);
            ChangeAltButtonStyle(urunSil);
            ChangeAltButtonStyle(urunEkle);
            ChangeAltButtonStyle(urunDuzenle);
        }

        private void ChangeAltButtonStyle(Button button)
        {

            button.BackColor = Color.LightBlue;
            button.Font = new Font("Arial", 8);

        }
    }
}
