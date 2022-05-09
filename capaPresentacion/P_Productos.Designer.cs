
namespace capaPresentacion
{
    partial class P_Productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Productos));
            this.Stage_Productos = new System.Windows.Forms.DataGridView();
            this.BoxCategorias = new System.Windows.Forms.ComboBox();
            this.BoxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.IDProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Stage_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Stage_Productos
            // 
            this.Stage_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stage_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProd,
            this.Categoria,
            this.Marca,
            this.Descripcion,
            this.precio,
            this.Editar,
            this.Eliminar});
            this.Stage_Productos.Location = new System.Drawing.Point(32, 32);
            this.Stage_Productos.Name = "Stage_Productos";
            this.Stage_Productos.RowHeadersWidth = 51;
            this.Stage_Productos.RowTemplate.Height = 24;
            this.Stage_Productos.Size = new System.Drawing.Size(902, 380);
            this.Stage_Productos.TabIndex = 0;
            // 
            // BoxCategorias
            // 
            this.BoxCategorias.FormattingEnabled = true;
            this.BoxCategorias.Location = new System.Drawing.Point(1048, 56);
            this.BoxCategorias.Name = "BoxCategorias";
            this.BoxCategorias.Size = new System.Drawing.Size(169, 24);
            this.BoxCategorias.TabIndex = 1;
            // 
            // BoxMarca
            // 
            this.BoxMarca.FormattingEnabled = true;
            this.BoxMarca.Location = new System.Drawing.Point(1048, 94);
            this.BoxMarca.Name = "BoxMarca";
            this.BoxMarca.Size = new System.Drawing.Size(169, 24);
            this.BoxMarca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(955, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categorias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(955, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marcas";
            // 
            // txtDescricion
            // 
            this.txtDescricion.Location = new System.Drawing.Point(1048, 128);
            this.txtDescricion.Name = "txtDescricion";
            this.txtDescricion.Size = new System.Drawing.Size(169, 22);
            this.txtDescricion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(955, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(955, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(1048, 160);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(169, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(1048, 205);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(169, 35);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // IDProd
            // 
            this.IDProd.DataPropertyName = "ID";
            this.IDProd.HeaderText = "ID";
            this.IDProd.MinimumWidth = 6;
            this.IDProd.Name = "IDProd";
            this.IDProd.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // P_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 446);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxMarca);
            this.Controls.Add(this.BoxCategorias);
            this.Controls.Add(this.Stage_Productos);
            this.Name = "P_Productos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.P_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stage_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Stage_Productos;
        private System.Windows.Forms.ComboBox BoxCategorias;
        private System.Windows.Forms.ComboBox BoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}

