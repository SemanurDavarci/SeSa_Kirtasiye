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
    public partial class MusteriSec : Form
    {
        private MySqlConnectionManager dbConnector;
        public int SecilenMusteriID { get; private set; }
        public MusteriSec()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void MusteriSec_Load(object sender, EventArgs e)
        {
            LoadData();
            ChangeStyle();
        }
        private void LoadData()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_MusteriDetay", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            musterilerGridView.DataSource = dataTable;
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

        private void müsteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle yeniForm = new MusteriEkle();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();
            yeniForm.FormClosed += YeniFormKapandi;
        }

        private void müsteriDuzenle_Click(object sender, EventArgs e)
        {
            int id = getID();
            if (id == -1)
            {

            }
            else
            {
                MusteriDuzenle yeniForm = new MusteriDuzenle(id);
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
           
            if (musterilerGridView.SelectedRows.Count > 0)
            {
                string deger = "";
                foreach (DataGridViewRow row in musterilerGridView.SelectedRows)
                {
                    deger = row.Cells["MusteriID"].Value.ToString();

                }
                return Int32.Parse(deger);
            }
            else
            {
                MessageBox.Show("Lütfen en az bir satır seçin.");
                return -1;
            }
        }

        private void musteriSil_Click(object sender, EventArgs e)
        {
            int id = getID();
            if (id == -1)
            {

            }
            else
            {
                MusteriSil(id);
                LoadData();
            }

        }


        private void MusteriSil(int id)
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_MusteriSil", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("@p_MusteriID", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla silindi.");
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

        private void satisYapTamam_Click(object sender, EventArgs e)
        {
            int id = getID();
            if(id == -1)
            {

            }
            else
            {
                SecilenMusteriID = id;
                this.Close();
            }
        }

        private void satisYapIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void müsterilerTabPage_Click(object sender, EventArgs e)
        {
            
        }
        private void musteriBul()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_MusteriBul", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@filtre", aranacakMusteri.Text);

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            musterilerGridView.DataSource = dataTable;
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

        private void musteriAra_Click(object sender, EventArgs e)
        {
            musteriBul();
        }

        private void ChangeStyle()
        {

            ChangeAltButtonStyle(musteriAra);
            ChangeAltButtonStyle(musteriSil);
            ChangeAltButtonStyle(musteriEkle);
            ChangeAltButtonStyle(musteriDuzenle);
            ChangeIptalButtonStyle(musteriSecIptal);
            ChangeTamamButtonStyle(musteriSecTamam);
        }

        private void ChangeAltButtonStyle(Button button)
        {

            button.BackColor = Color.LightBlue;
            button.Font = new Font("Arial", 8);

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

