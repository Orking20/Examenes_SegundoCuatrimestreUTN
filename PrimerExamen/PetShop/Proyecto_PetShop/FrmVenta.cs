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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }

        private void btnMostrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = BuscarCliente();

            if (cliente != null)
            {
                lblNombreCliente.Text = cliente.Nombre;
                lblApellidoCliente.Text = cliente.Apellido;
                lblDniCliente.Text = cliente.Dni.ToString();

                lblNombreCliente.Visible = true;
                lblApellidoCliente.Visible = true;
                lblDniCliente.Visible = true;
            }
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = BuscarProducto();

            if (producto != null)
            {
                lblNombreProducto.Text = producto.Nombre;
                lblMarcaProducto.Text = producto.Marca;
                lblPrecioProducto.Text = producto.Precio.ToString();
                lblStockProducto.Text = producto.Stock.ToString();

                lblNombreProducto.Visible = true;
                lblMarcaProducto.Visible = true;
                lblPrecioProducto.Visible = true;
                lblStockProducto.Visible = true;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int stock = (int)nudStock.Value;
            string mensaje;

            mensaje = Venta.VenderProducto(BuscarProducto(), BuscarCliente(), stock);
            
            lblVendido.Visible = true;
            lblVendido.Text = mensaje;
        }

        private void nudStock_ValueChanged(object sender, EventArgs e)
        {
            Producto producto = BuscarProducto();
            double precio = producto.Precio;
            int stock = (int)nudStock.Value;

            lblPrecioTotalProducto.Text = Venta.PrecioTotal(precio, stock).ToString();
        }

        private Cliente BuscarCliente()
        {
            Cliente cliente = null;

            if (FrmMenu.Clientes.Count > 0)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nudIdClientes.Value == cliente.IdCliente)
                    {
                        lblInfoCliente.Visible = false;
                        break;
                    }
                    else
                    {
                        lblInfoCliente.Visible = true;
                        lblNombreCliente.Visible = false;
                        lblApellidoCliente.Visible = false;
                        lblDniCliente.Visible = false;
                        cliente = null;
                    }
                }
            }
            else
            {
                lblInfoCliente.Visible = true;
                lblNombreCliente.Visible = false;
                lblApellidoCliente.Visible = false;
                lblDniCliente.Visible = false;
            }

            return cliente;
        }

        private Producto BuscarProducto()
        {
            Producto producto = null;

            if (FrmLogin.Productos.Count > 0)
            {
                for (int j = 0; j < FrmLogin.Productos.Count; j++)
                {
                    producto = FrmLogin.Productos[j];

                    if (nudIdProducto.Value == producto.IdProducto)
                    {
                        lblInfoProducto.Visible = false;
                        break;
                    }
                    else
                    {
                        lblInfoProducto.Visible = true;
                        lblNombreProducto.Visible = false;
                        lblMarcaProducto.Visible = false;
                        lblPrecioProducto.Visible = false;
                        lblStockProducto.Visible = false;
                        producto = null;
                    }
                }
            }
            else
            {
                lblInfoProducto.Visible = true;
                lblNombreProducto.Visible = false;
                lblMarcaProducto.Visible = false;
                lblPrecioProducto.Visible = false;
                lblStockProducto.Visible = false;
            }

            return producto;
        }
    }
}
