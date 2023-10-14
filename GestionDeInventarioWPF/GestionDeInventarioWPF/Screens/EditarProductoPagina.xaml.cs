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
    /// Lógica de interacción para EditarProductoPagina.xaml
    /// </summary>
    public partial class EditarProductoPagina : Page
    {

        DBManager dbManager = new DBManager();

        public EditarProductoPagina()
        {
            InitializeComponent();
        }

        private void EditarProducto_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Código de inserción aquí
                string query = "UPDATE Producto SET nombre = @nombre, precio = @precio, descuento = @descuento, stock = @stock WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection()))
                {

                    dbManager.OpenConnection();

                    cmd.Parameters.AddWithValue("@id", IdProducto_TextBox.Text);
                    cmd.Parameters.AddWithValue("@nombre", NombreProducto_TextBox.Text);
                    cmd.Parameters.AddWithValue("@precio", float.Parse(PrecioProducto_TextBox.Text));
                    cmd.Parameters.AddWithValue("@descuento", float.Parse(DescuentoProducto_TextBox.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(StockProducto_TextBox.Text));

                    cmd.ExecuteNonQuery();

                    dbManager.CloseConnection();

                    MessageBox.Show("Producto Editado exitosamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                MessageBox.Show("Error al editar el producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
