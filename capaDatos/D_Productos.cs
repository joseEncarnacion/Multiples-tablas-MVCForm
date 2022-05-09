using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using capaEntidad;
using System.Configuration;

namespace capaDatos
{
    public class D_Productos
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString);

        public DataTable D_listarProduct()
        {
            SqlCommand cmd = new SqlCommand("D_listarProduct", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_listarMarca()
        {
            SqlCommand cmd = new SqlCommand("D_listarMarca", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void InsertarDatos(E_Productos product)
        {
            SqlCommand cmd = new SqlCommand("D_insertarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoriaID", product.idCategoria);
            cmd.Parameters.AddWithValue("@marcaID", product.idMarca);
            cmd.Parameters.AddWithValue("@Descripcion", product.Descripcion);
            cmd.Parameters.AddWithValue("@precion", product.precio);
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


        }

        public DataTable ListaDProductos()
        {
            SqlCommand cmd = new SqlCommand("ListarProd", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }





    }
}
