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
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }

            MostrarFacturas();
        }

        private void MostrarFacturas()
        {
            Cliente cliente;
            Producto producto;
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
                for (int i = 0; i < FrmLogin.Productos.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];
                    if (FrmLogin.Facturas.ContainsKey(cliente))
                    {
                        producto = FrmLogin.Facturas[cliente];
                        stock = FrmLogin.Stocks[cliente];

                        precioTotal = producto.Precio * stock;

                        ids.AppendLine(cliente.IdCliente.ToString());
                        nombresClientes.AppendLine(cliente.Nombre);
                        nombresProductos.AppendLine(producto.Nombre);
                        preciosUnitarios.AppendLine(producto.Precio.ToString());
                        cantidades.AppendLine(stock.ToString());
                        preciosTotales.AppendLine(precioTotal.ToString());
                        break;
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
        }
    }
}
