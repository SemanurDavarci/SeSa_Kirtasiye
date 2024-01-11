using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SeSa_Kırtasiye_Semanur_Davarcı
{
    public class MySqlConnectionManager
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection Connection
        {
            get { return connection; }
        }

        public MySqlConnectionManager()
        {
            Initialize();
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Bağlantı hatası oluştuğunda burada işlemler yapılabilir
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Bağlantı kapatma hatası oluştuğunda burada işlemler yapılabilir
                return false;
            }
        }

        private void Initialize()
        {
            server = "localhost"; // MySQL sunucu adresi
            database = "sesa_kirtasiye"; // Veritabanı adı
            uid = "root"; // Kullanıcı adı
            password = "Sema519712"; // Şifre

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }
    }
}