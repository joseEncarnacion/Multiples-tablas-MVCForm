using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocio
{
    public class N_Productos
    {
        D_Productos objDatos = new D_Productos();

        public DataTable N_productos()
        {
            return objDatos.D_listarProduct();
        }

        public DataTable N_Marca()
        {
            return objDatos.D_listarMarca();
        }

        public void N_AddProduct(E_Productos product)
        {
            objDatos.InsertarDatos(product);
        }

        public DataTable N_ListProductos()
        {
            return objDatos.ListaDProductos();
        }
    }
}
