using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;


namespace GestionDeInventarioWPF.Clases
{
    public class DBManager
    {
        private string connectionString;
        private MySqlConnection connection;

        public DBManager()
        {
            connectionString = "Server=localhost;Port=3306;Database=inventario;Uid=root;Pwd=root;";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
