using GestionDeInventarioWPF.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para EliminarProductoPagina.xaml
    /// </summary>
    public partial class EliminarProductoPagina : Page
    {

        DBManager dbManager = new DBManager();

        public EliminarProductoPagina()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                // Código de inserción aquí
                string query = "DELETE FROM Producto WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection()))
                {

                    cmd.Parameters.AddWithValue("@id", IdProducto_TextBox.Text);

                    dbManager.OpenConnection();
                    cmd.ExecuteNonQuery();
                    dbManager.CloseConnection();

                    MessageBox.Show("Producto Eliminado exitosamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
