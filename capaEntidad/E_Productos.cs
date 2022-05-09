using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class E_Productos
    {
        public int idProducto { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public string Descripcion { get; set; }
        public double precio { get; set; }
    }
}
