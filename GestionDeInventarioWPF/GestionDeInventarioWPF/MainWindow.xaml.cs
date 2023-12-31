﻿using GestionDeInventarioWPF.Clases;
using GestionDeInventarioWPF.Screens;
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

namespace GestionDeInventarioWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;

            Messenger.PageRequested += (pageUri) => FramePaginas.NavigationService.Navigate(pageUri);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ListaDeProductos listaDeProductos = new ListaDeProductos();

            FramePaginas.NavigationService.Navigate(listaDeProductos);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();

            FramePaginas.NavigationService.Navigate(menuPrincipal);
        }
    }
}
