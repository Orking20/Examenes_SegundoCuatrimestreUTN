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
    public partial class FrmMostrarProducto : Form
    {
        #region Carga los datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmMostrarProducto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMostrarProducto_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }

            MostrarProductos();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los productos
        /// </summary>
        private void MostrarProductos()
        {
            Producto producto;
            StringBuilder ids = new StringBuilder();
            StringBuilder nombres = new StringBuilder();
            StringBuilder marcas = new StringBuilder();
            StringBuilder tipos = new StringBuilder();
            StringBuilder precios = new StringBuilder();
            StringBuilder pesos = new StringBuilder();
            StringBuilder stocks = new StringBuilder();

            for (int i = 0; i < FrmLogin.Productos.Count; i++)
            {
                producto = FrmLogin.Productos[i];

                ids.AppendLine(producto.IdProducto.ToString());
                nombres.AppendLine(producto.Nombre);
                marcas.AppendLine(producto.Marca);
                tipos.AppendLine(producto.Tipo.ToString());
                precios.AppendLine(producto.Precio.ToString());
                pesos.AppendLine(producto.Peso.ToString());
                stocks.AppendLine(producto.Stock.ToString());
            }

            lblId.Visible = true;
            lblNombres.Visible = true;
            lblMarca.Visible = true;
            lblTipo.Visible = true;
            lblPrecio.Visible = true;
            lblPeso.Visible = true;
            lblStock.Visible = true;

            lblId.Text = ids.ToString();
            lblNombres.Text = nombres.ToString();
            lblMarca.Text = marcas.ToString();
            lblTipo.Text = tipos.ToString();
            lblPrecio.Text = precios.ToString();
            lblPeso.Text = pesos.ToString();
            lblStock.Text = stocks.ToString();
        }
        #endregion
    }
}
