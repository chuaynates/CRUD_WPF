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
using System.Windows.Shapes;
using Entity;

using Business;

namespace Tecsup
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaProducto  listaproducto= new ListaProducto();
            listaproducto.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListaCategoria listaproducto = new ListaCategoria();
            listaproducto.ShowDialog();
        }
    }
}
