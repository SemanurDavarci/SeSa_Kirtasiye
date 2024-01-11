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
    public partial class Main : Form
    {
        private MySqlConnectionManager dbConnector;
        public Main()
        {
            
            InitializeComponent();
            dbConnector = new MySqlConnectionManager();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadSatislar();
            ChangeStyle();
        }
        private void LoadSatislar()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_SatisDetay", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            satislarDataGrid.DataSource = dataTable;
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
        private void LoadOdemeler()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_OdemeDetay", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            odemelerDataGrid.DataSource = dataTable;
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

        private void musterilerGirisButton_Click(object sender, EventArgs e)
        {
            Musteriler yeniForm = new Musteriler();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();


        }
        private void mainTabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabPage.SelectedTab == satislarTabPage) 
            {
                LoadSatislar();
            }
            else if (mainTabPage.SelectedTab == odemelerTabPage)
            {
                LoadOdemeler();
            }
            
        }

        private void satislarDuzenleButton_Click(object sender, EventArgs e)
        {
            int id = satisGetID();
            if(id == -1)
            {

            }
            else
            {
                SatisDuzenle yeniForm = new SatisDuzenle(id);
                yeniForm.StartPosition = FormStartPosition.CenterScreen;
                yeniForm.Show();
                yeniForm.FormClosed += SatisYeniFormKapandi;
            }
        }
        private int satisGetID()
        {

            if (satislarDataGrid.SelectedRows.Count > 0)
            {
                string deger = "";
                foreach (DataGridViewRow row in satislarDataGrid.SelectedRows)
                {
                    deger = row.Cells["SatisID"].Value.ToString();

                }
                return Int32.Parse(deger);
            }
            else
            {
                MessageBox.Show("Lütfen en az bir satır seçin.");
                return -1;
            }
        }
        private int odemeGetID()
        {

            if (odemelerDataGrid.SelectedRows.Count > 0)
            {
                string deger = "";
                foreach (DataGridViewRow row in odemelerDataGrid.SelectedRows)
                {
                    deger = row.Cells["OdemeID"].Value.ToString();

                }
                return Int32.Parse(deger);
            }
            else
            {
                MessageBox.Show("Lütfen en az bir satır seçin.");
                return -1;
            }
        }
        private void satislarSilButton_Click(object sender, EventArgs e)
        {
            int id = satisGetID();
            if(id == -1)
            {
                
            }
            else
            {
                SatisSil(id);
                LoadSatislar();
            }
        }
        private void SatisSil(int id)
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_SatisSil", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_SatisID", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Satış başarıyla silindi.");
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

        private void urunlerGirisButton_Click(object sender, EventArgs e)
        {
            Urunler yeniForm = new Urunler();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();
        }

        private void kategorilerGirisButton_Click(object sender, EventArgs e)
        {
            Kategoriler yeniForm = new Kategoriler();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();
        }

        private void satısyapGirisButton_Click(object sender, EventArgs e)
        {
            SatısYap yeniForm = new SatısYap();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();
            yeniForm.FormClosed += SatisYeniFormKapandi;
        }
        private void SatisYeniFormKapandi(object sender, FormClosedEventArgs e)
        {
            LoadSatislar();
        }
        private void OdemeYeniFormKapandi(object sender, FormClosedEventArgs e)
        {
            LoadOdemeler();
        }

        private void odemeyapGirisButton_Click(object sender, EventArgs e)
        {
            OdemeYap yeniForm = new OdemeYap();
            yeniForm.StartPosition = FormStartPosition.CenterScreen;
            yeniForm.Show();
            yeniForm.FormClosed += OdemeYeniFormKapandi;
        }

        private void odemeDuzenle_Click(object sender, EventArgs e)
        {
            int id=odemeGetID();
            if(id == -1)
            {

            }
            else
            {
                OdemeDuzenle yeniForm = new OdemeDuzenle(id);
                yeniForm.StartPosition = FormStartPosition.CenterScreen;
                yeniForm.Show();
                yeniForm.FormClosed += OdemeYeniFormKapandi;
            }
        }

        private void odemeSil_Click(object sender, EventArgs e)
        {
            int id = odemeGetID();
            if(id == -1)
            {

            }
            else
            {
                OdemeSil(id);
                LoadOdemeler();
            }
        }
        private void OdemeSil(int id)
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_OdemeSil", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_OdemeID", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Odeme başarıyla silindi.");
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

        private void satisAra_Click(object sender, EventArgs e)
        {
            satisBul();
        }
        private void satisBul()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_SatisBul", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@filtre", aranacakSatis.Text);

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            satislarDataGrid.DataSource = dataTable;
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

        private void satislarDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void odemeAra_Click(object sender, EventArgs e)
        {
            odemeBul();
        }
        private void odemeBul()
        {
            if (dbConnector.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sesa_OdemeBul", dbConnector.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@filtre", aranacakOdeme.Text);

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            odemelerDataGrid.DataSource = dataTable;
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

            ChangeAnaButtonStyle(musterilerGirisButton);
            ChangeAnaButtonStyle(urunlerGirisButton);
            ChangeAnaButtonStyle(satisyapGirisButton);
            ChangeAnaButtonStyle(odemeyapGirisButton);
            ChangeAnaButtonStyle(kategorilerGirisButton);
            ChangeAltButtonStyle(satislarSilButton);
            ChangeAltButtonStyle(satislarDuzenleButton);
            ChangeAltButtonStyle(satisAra);
            ChangeAltButtonStyle(odemeSil);
            ChangeAltButtonStyle(odemeDuzenle);
            ChangeAltButtonStyle(odemeAra);
        }
        private void ChangeAnaButtonStyle(Button button)
        {
 
            button.BackColor = Color.BurlyWood;
            button.ForeColor = Color.DarkRed;
            button.Font = new Font("Arial", 9, FontStyle.Bold);

        }
        private void ChangeAltButtonStyle(Button button)
        {

            button.BackColor = Color.LightBlue;
            button.Font = new Font("Arial", 8);

        }
    }
}
