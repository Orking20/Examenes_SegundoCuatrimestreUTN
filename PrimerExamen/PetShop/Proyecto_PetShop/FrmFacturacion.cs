using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmFacturacion : Form
    {
        #region Carga los datos
        /// <summary>
        /// Inicializa los componentes gráficos de este formulario
        /// </summary>
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos cuando se abre el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }

            MostrarFacturas();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra las facturas de todas las compras hechas
        /// </summary>
        private void MostrarFacturas()
        {
            Cliente cliente;
            Producto producto;
            Factura factura;
            StringBuilder ids = new StringBuilder();
            StringBuilder nombresClientes = new StringBuilder();
            StringBuilder nombresProductos = new StringBuilder();
            StringBuilder preciosUnitarios = new StringBuilder();
            StringBuilder cantidades = new StringBuilder();
            StringBuilder preciosTotales = new StringBuilder();
            double precioTotal;
            int stock;

            if (FrmLogin.Facturas.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Facturas.Count; i++)
                {
                    factura = FrmLogin.Facturas[i];

                    cliente = factura.Cliente;
                    producto = factura.Producto;
                    stock = factura.StockComprado;

                    precioTotal = producto.Precio * stock;

                    ids.AppendLine(cliente.IdCliente.ToString());
                    nombresClientes.AppendLine(cliente.Nombre);
                    nombresProductos.AppendLine(producto.Nombre);
                    preciosUnitarios.AppendLine(producto.Precio.ToString());
                    cantidades.AppendLine(stock.ToString());
                    preciosTotales.AppendLine(precioTotal.ToString());

                    TextWriter texto = new StreamWriter($"{FrmLogin.Path}\\Facturas.txt", true);
                    texto.WriteLine($"ID: {cliente.IdCliente} | Nombre cliente: {cliente.Nombre} | Nombre producto: {producto.Nombre} | Precio: {producto.Precio} | Stock: {stock} | Precio Total: {precioTotal}");
                    texto.Close();
                }
            }

            lblId.Visible = true;
            lblNombres.Visible = true;
            lblNombreProductos.Visible = true;
            lblPrecioUnitario.Visible = true;
            lblCantidadProductos.Visible = true;
            lblPrecioTotal.Visible = true;

            lblId.Text = ids.ToString();
            lblNombres.Text = nombresClientes.ToString();
            lblNombreProductos.Text = nombresProductos.ToString();
            lblPrecioUnitario.Text = preciosUnitarios.ToString();
            lblCantidadProductos.Text = cantidades.ToString();
            lblPrecioTotal.Text = preciosTotales.ToString();
        }
        #endregion
    }
}
