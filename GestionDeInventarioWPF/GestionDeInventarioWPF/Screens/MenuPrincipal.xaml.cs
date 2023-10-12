using GestionDeInventarioWPF.Clases;
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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void ListaDeProductos_Button____Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindows = new MainWindow();

            ListaDeProductos listaDeProductos = new ListaDeProductos();

            Messenger.RequestPage(new Uri("Screens/ListaDeProductos.xaml", UriKind.Relative));
        }

        private void AgregarProducto_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditarProducto_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarProducto_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clientes_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
