using Business;
using Entity;
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

namespace Tecsup
{
    /// <summary>
    /// Lógica de interacción para ManCategoria.xaml
    /// </summary>
    public partial class ManProducto : Window
    {
        public int ID { get; set; }
        public ManProducto(int Id)
        {
            ID = Id;
            InitializeComponent();
            ID = Id;
            if (ID > 0)
            {
                BProducto bProducto = new BProducto();
                List<Producto> productos = new List<Producto>();
                productos = bProducto.Listar(ID);
                if (productos.Count > 0)
                {
                    lblId.Content = productos[0].IdProducto.ToString();
                    txtNombre.Text = productos[0].NombreProducto;
                    txtProveedor.Text = productos[0].IdProveedor.ToString();
                    txtCategoria.Text = productos[0].IdCategoria.ToString();
                    txtCantidadU.Text = productos[0].CantidadPorUnidad;
                    txtPrecioU.Text = productos[0].PrecioUnidad.ToString();
                    txtCategoriaProd.Text = productos[0].CategoriaProducto;
                    txtUnidadesEx.Text = productos[0].UnidadesExistencia.ToString();
                    txtUnidadesPed.Text = productos[0].UnidadesPedido.ToString();
                    txtNuevoNivel.Text = productos[0].NivelNuevoPedido.ToString();
                    txtSuspendido.Text = productos[0].Suspendido.ToString();

                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            BProducto Bproducto = null;
            bool result = true;
            try
            {
                Bproducto = new BProducto();
                if (ID > 0)
                    result = Bproducto.Actualizar(new Producto { IdProducto = ID, NombreProducto = txtNombre.Text,IdProveedor = Convert.ToInt32(txtProveedor.Text), 
                                                                 IdCategoria=Convert.ToInt32(txtCategoria.Text),CantidadPorUnidad=txtCantidadU.Text,
                                                                 PrecioUnidad=Convert.ToDecimal(txtPrecioU.Text),UnidadesExistencia=Convert.ToInt32(txtUnidadesEx.Text),
                                                                 UnidadesPedido=Convert.ToInt32(txtUnidadesPed.Text),NivelNuevoPedido=Convert.ToInt32(txtNuevoNivel.Text),
                                                                 Suspendido=Convert.ToInt32(txtSuspendido.Text),CategoriaProducto=txtCategoriaProd.Text
                                                                });
                else
                    result = Bproducto.Insertar(new Producto {
                                                                NombreProducto = txtNombre.Text,
                                                                IdProveedor = Convert.ToInt32(txtProveedor.Text),
                                                                IdCategoria = Convert.ToInt32(txtCategoria.Text),
                                                                CantidadPorUnidad = txtCantidadU.Text,
                                                                PrecioUnidad = Convert.ToDecimal(txtPrecioU.Text),
                                                                UnidadesExistencia = Convert.ToInt32(txtUnidadesEx.Text),
                                                                UnidadesPedido = Convert.ToInt32(txtUnidadesPed.Text),
                                                                NivelNuevoPedido = Convert.ToInt32(txtNuevoNivel.Text),
                                                                Suspendido = Convert.ToInt32(txtSuspendido.Text),
                                                                CategoriaProducto = txtCategoriaProd.Text
                    });
                if (!result)
                    MessageBox.Show("Comunicarse con el administrador");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comunicarse con el administrador");
            }
            finally
            {
                Bproducto = null;
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            BProducto Bproducto = null;
            bool result = true;
            try
            {
                Bproducto = new BProducto();
                if (ID > 0)
                    result = Bproducto.Eliminar(ID);
                else
                    MessageBox.Show("Nada que eliminar");

                if (!result)
                    MessageBox.Show("Comunicarse con el administrador");


                Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGrabar_Click_1(object sender, RoutedEventArgs e)
        {
            BProducto Bproducto = null;
            bool result = true;
            try
            {
                Bproducto = new BProducto();
                if (ID > 0)
                    result = Bproducto.Actualizar(new Producto
                    {
                        IdProducto = ID,
                        NombreProducto = txtNombre.Text,
                        IdProveedor = Convert.ToInt32(txtProveedor.Text),
                        IdCategoria = Convert.ToInt32(txtCategoria.Text),
                        CantidadPorUnidad = txtCantidadU.Text,
                        PrecioUnidad = Convert.ToDecimal(txtPrecioU.Text),
                        UnidadesExistencia = Convert.ToInt32(txtUnidadesEx.Text),
                        UnidadesPedido = Convert.ToInt32(txtUnidadesPed.Text),
                        NivelNuevoPedido = Convert.ToInt32(txtNuevoNivel.Text),
                        Suspendido = Convert.ToInt32(txtSuspendido.Text),
                        CategoriaProducto = txtCategoriaProd.Text
                    });
                else
                    result = Bproducto.Insertar(new Producto
                    {
                        NombreProducto = txtNombre.Text,
                        IdProveedor = Convert.ToInt32(txtProveedor.Text),
                        IdCategoria = Convert.ToInt32(txtCategoria.Text),
                        CantidadPorUnidad = txtCantidadU.Text,
                        PrecioUnidad = Convert.ToDecimal(txtPrecioU.Text),
                        UnidadesExistencia = Convert.ToInt32(txtUnidadesEx.Text),
                        UnidadesPedido = Convert.ToInt32(txtUnidadesPed.Text),
                        NivelNuevoPedido = Convert.ToInt32(txtNuevoNivel.Text),
                        Suspendido = Convert.ToInt32(txtSuspendido.Text),
                        CategoriaProducto = txtCategoriaProd.Text
                    });
                if (!result)
                    MessageBox.Show("Comunicarse con el administrador");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comunicarse con el administrador");
            }
            finally
            {
                Bproducto = null;
            }
        }

        private void btnEliminar_Click_1(object sender, RoutedEventArgs e)
        {

            BProducto Bproducto = null;
            bool result = true;
            try
            {
                Bproducto = new BProducto();
                if (ID > 0)
                    result = Bproducto.Eliminar(ID);
                else
                    MessageBox.Show("Nada que eliminar");

                if (!result)
                    MessageBox.Show("Comunicarse con el administrador");


                Close();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
