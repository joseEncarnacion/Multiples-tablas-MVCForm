using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using capaNegocio;



namespace capaPresentacion
{
    public partial class P_Productos : Form
    {
        E_Productos objEntidad = new E_Productos();
        N_Productos objNegocio = new N_Productos();

        public P_Productos()
        {
            InitializeComponent();
        }

        private void P_Productos_Load(object sender, EventArgs e)
        {
            ListarCategoria();
            ListarMarca();
            ListarProductos();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        void ListarCategoria()
        {
            DataTable dt = objNegocio.N_productos();
            BoxCategorias.DataSource = dt;
            BoxCategorias.DisplayMember = "Categoria";
            BoxCategorias.ValueMember = "IDCATEGORIA";
        }

        void ListarMarca()
        {
            DataTable dt = objNegocio.N_Marca();
            BoxMarca.DataSource = dt;
            BoxMarca.DisplayMember = "Marca";
            BoxMarca.ValueMember = "IDMarca";
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            InsertarDatos();
            Limpiar();
            ListarProductos();
        }

        void InsertarDatos()
        {
            objEntidad.idCategoria = Convert.ToInt32(BoxCategorias.SelectedValue);
            objEntidad.idMarca = Convert.ToInt32(BoxMarca.SelectedValue);
            objEntidad.Descripcion = txtDescricion.Text;
            objEntidad.precio = Convert.ToInt32(txtPrecio.Text);

            objNegocio.N_AddProduct(objEntidad);

            MessageBox.Show("Producto insertado con exito");

        }

        void Limpiar()
        {
            BoxCategorias.SelectedValue = BoxCategorias.SelectedIndex;
            txtDescricion.Text = "";
            txtPrecio.Text = "";
        }


        void ListarProductos()
        {
            DataTable dt = objNegocio.N_ListProductos();
            Stage_Productos.DataSource = dt;

        }
    }
}
