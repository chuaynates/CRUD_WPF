using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public string CantidadPorUnidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int UnidadesExistencia { get; set; }
        public int UnidadesPedido { get; set; }
        public int NivelNuevoPedido { get; set; }
        public int Suspendido { get; set; }
        public string CategoriaProducto { get; set; }

        public string cates { get; set; }

    }
}
