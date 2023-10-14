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
    /// Lógica de interacción para AgregarProductoPagina.xaml
    /// </summary>
    public partial class AgregarProductoPagina : Page
    {
        DBManager dbManager = new DBManager();



        public AgregarProductoPagina()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Código de inserción aquí
                string query = "INSERT INTO Producto (nombre, precio, descuento, stock) VALUES (@nombre, @precio, @descuento, @stock)";

                using (MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection()))
                {

                    dbManager.OpenConnection();

                    cmd.Parameters.AddWithValue("@nombre", NombreProducto_TextBox.Text);
                    cmd.Parameters.AddWithValue("@precio", float.Parse(PrecioProducto_TextBox.Text));
                    cmd.Parameters.AddWithValue("@descuento", float.Parse(DescuentoProducto_TextBox.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(StockProducto_TextBox.Text));

                    cmd.ExecuteNonQuery();

                    dbManager.CloseConnection();

                    MessageBox.Show("Producto agregado exitosamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
