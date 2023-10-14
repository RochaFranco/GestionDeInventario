using GestionDeInventarioWPF.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionDeInventarioWPF.Screens
{
    /// <summary>
    /// Lógica de interacción para ListaDeProductos.xaml
    /// </summary>
    public partial class ListaDeProductos : Page
    {

        DBManager dbManager = new DBManager();

        public ListaDeProductos()
        {
            InitializeComponent();

            DataTable dataTable = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Producto", dbManager.GetConnection()))
            {
                dbManager.OpenConnection();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                dbManager.CloseConnection();
            }

            DataGrid_Productos.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
