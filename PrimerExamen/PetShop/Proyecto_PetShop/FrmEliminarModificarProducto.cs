using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmEliminarModificarProducto : Form
    {
        /// <summary>
        /// Inicializa los componentes gráficos de este formulario
        /// </summary>
        public FrmEliminarModificarProducto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos cuando se abre el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEliminarModificarProducto_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }

        #region BotonMostrar
        /// <summary>
        /// Muestra los datos del empleado con el ID ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Producto producto;

            if (FrmLogin.Productos.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Productos.Count; i++)
                {
                    producto = FrmLogin.Productos[i];

                    if (nupIdProductos.Value == producto.IdProducto)
                    {
                        lblInfo.Visible = false;
                        OcultarLebel();
                        OcultarTextBox();
                        lblMostrar.Visible = true;
                        lblMostrar.Text = producto.Mostrar();
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        lblMostrar.Visible = false;
                        OcultarLebel();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
            }
        }
        #endregion

        #region BotonModificar_AplicarCambios
        /// <summary>
        /// Entra en el modo modificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (FrmLogin.Productos.Count > 0)
            {
                OcultarLebel();
                MostrarLebel();
                MostrarTextBox();
                lblMostrar.Visible = false;
                btnAplicarCambios.Visible = true;
            }
            else
            {
                lblInfo.Visible = true;
            }
        }

        /// <summary>
        /// Sobreescribe los datos deseados del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            Producto producto;
            StringBuilder sb;

            for (int i = 0; i < FrmLogin.Productos.Count; i++)
            {
                producto = FrmLogin.Productos[i];

                if (nupIdProductos.Value == producto.IdProducto)
                {
                    lblInfo.Visible = false;

                    if (Validaciones(producto, out sb))
                    {
                        MessageBox.Show($"Estos campos no son válidos.\nAsegurese de cambiarlos\n{sb}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(MessageBox.Show("¿Seguro que desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            OcultarLebel();
                            OcultarTextBox();
                            LimpiarTextBox();
                            lblMostrar.Text = producto.Mostrar();
                            lblMostrar.Visible = true;
                            break;
                        }
                    }
                }
                else
                {
                    lblInfo.Visible = true;
                }
            }
        }
        #endregion

        #region BotonEliminar
        /// <summary>
        /// Elimina el producto con el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto producto;

            if (FrmLogin.Productos.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Productos.Count; i++)
                {
                    producto = FrmLogin.Productos[i];

                    if (nupIdProductos.Value == producto.IdProducto)
                    {
                        lblInfo.Visible = false;

                        if (MessageBox.Show("¿Estás seguro que desea eliminar este cliente?\nEsta acción no se puede deshacer", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Empleado.BajaProducto(FrmLogin.Productos, producto);
                            OcultarLebel();
                            lblMostrar.Visible = false;
                        }
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
            }
        }
        #endregion

        #region Validaciones
        private bool Validaciones(Producto producto, out StringBuilder sb)
        {
            bool error = false;
            double precio;
            double peso;
            int stock;
            sb = new StringBuilder();

            if (txtNombre.Text != string.Empty)
            {
                if (Producto.ValidarNombre(txtNombre.Text))
                {
                    producto.Nombre = txtNombre.Text;
                }
                else
                {
                    sb.AppendLine("Nombre");
                    error = true;
                }
            }
            if (txtMarca.Text != string.Empty)
            {
                producto.Marca = txtMarca.Text;
            }
            if (cmbTipo.SelectedItem != null)
            {
                producto.Tipo = (ETipo)cmbTipo.SelectedItem;
            }
            if (nudPrecio.Value != 0 && double.TryParse(nudPrecio.Text, out precio))
            {
                if (Producto.ValidarPrecio(precio))
                {
                    producto.Precio = precio;
                }
            }
            if (nudPeso.Value != 0 && double.TryParse(nudPeso.Text, out peso))
            {
                if (Producto.ValidarPeso(peso))
                {
                    producto.Peso = peso;
                }
            }
            if (nudStockSumar.Value != 0 && int.TryParse(nudStockSumar.Text, out stock))
            {
                if (Producto.ValidarStock(stock))
                {
                    producto.Stock += stock;
                }
            }
            if (nudStock.Value != 0 && int.TryParse(nudStock.Text, out stock))
            {
                if (Producto.ValidarStock(stock))
                {
                    producto.Stock = stock;
                }
            }

            return error;
        }
        #endregion

        #region Visibilidad Label/TextBox
        /// <summary>
        /// Establece la visibilidad de los text box en false
        /// </summary>
        private void OcultarTextBox()
        {
            btnAplicarCambios.Visible = false;
            txtNombre.Visible = false;
            txtMarca.Visible = false;
            cmbTipo.Visible = false;
            nudPrecio.Visible = false;
            nudPeso.Visible = false;
            nudStock.Visible = false;
            nudStockSumar.Visible = false;
        }

        /// <summary>
        /// Establece la visibilidad de los lebel en false
        /// </summary>
        private void OcultarLebel()
        {
            lblNombre.Visible = false;
            lblMarca.Visible = false;
            lblTipo.Visible = false;
            lblPrecio.Visible = false;
            lblPeso.Visible = false;
            lblStock.Visible = false;
            lblTotal.Visible = false;
            lblSumar.Visible = false;
        }

        /// <summary>
        /// Establece la visibilidad de los text box en true
        /// </summary>
        private void MostrarTextBox()
        {
            btnAplicarCambios.Visible = true;
            txtNombre.Visible = true;
            txtMarca.Visible = true;
            cmbTipo.Visible = true;
            nudPrecio.Visible = true;
            nudPeso.Visible = true;
            nudStock.Visible = true;
            nudStockSumar.Visible = true;
        }

        /// <summary>
        /// Establece la visibilidad de los lebel en true
        /// </summary>
        private void MostrarLebel()
        {
            lblNombre.Visible = true;
            lblMarca.Visible = true;
            lblTipo.Visible = true;
            lblPrecio.Visible = true;
            lblPeso.Visible = true;
            lblStock.Visible = true;
            lblTotal.Visible = true;
            lblSumar.Visible = true;
        }

        /// <summary>
        /// Borra cualquier texto que haya en los text box
        /// </summary>
        private void LimpiarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            nudPrecio.Value = 0;
            nudPeso.Value = 0;
            nudStock.Value = 0;
            nudStockSumar.Value = 0;
        }
        #endregion
    }
}
