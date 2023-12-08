using MySqlConnector;

namespace WinFormsApp1
{
    class DB
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=schoolhelper");

        public void openConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connect;
        }
    }

}
