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
    public partial class UrunSec : Form
    {
        private MySqlConnectionManager dbConnector;
        public int SecilenUrunID { get; private set; }
        public UrunSec()
        {
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void UrunSec_Load(object sender, EventArgs e)
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
            if (id == -1)
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

        private void urunSecTamam_Click(object sender, EventArgs e)
        {
            int id = getID();
            if(id == -1)
            {

            }
            else
            {
                SecilenUrunID = id;
                this.Close();
            }
        }

        private void urunSecIptal_Click(object sender, EventArgs e)
        {
            this.Close();
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
            ChangeAltButtonStyle(urunSil2);
            ChangeAltButtonStyle(urunEkle);
            ChangeAltButtonStyle(urunDuzenle);
            ChangeIptalButtonStyle(urunSecIptal);
            ChangeTamamButtonStyle(urunSecTamam);
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

        private void urunSil2_Click(object sender, EventArgs e)
        {
            int id = getID();
            if (id == -1)
            {

            }
            else
            {
                UrunSil(id);
                LoadData();
            }
        }


    }
}
